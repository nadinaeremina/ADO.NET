using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace MyAsync
{
    public partial class Form1 : Form
    {

        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet set = null;
        SqlCommandBuilder cmd = null;
        DataTable table = null;
        string cs = "";

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection();
            cs = ConfigurationManager.ConnectionStrings["Academy_add"].ConnectionString;
            conn.ConnectionString = cs;
        }

        // 1 /////////////////////////////////////////// использование классического паттерна
        private void bt_async_Click(object sender, EventArgs e)
        {
            // 1
            // модификация троки подключения - она должна содержать "Asynchronous Processing=true"
            const string AsyncEnable = "Asynchronous Processing=true";

            // если записи нет - то мы ее добавляем
            if (!cs.Contains(AsyncEnable))
                cs = String.Format("{0}; {1}", cs, AsyncEnable);

            conn = new SqlConnection(cs);
            SqlCommand comm = conn.CreateCommand();

            // 2 "WAITFOR DELAY '00:00:05' - замедляет работу БД на 5 секунд
            comm.CommandText = "WAITFOR DELAY '00:00:05'; select * from dbo.Teachers;";
            comm.CommandType = CommandType.Text;
            // по умолчанию это 30 секунд - время, кот выделяется на подключение к БД и на выполнение запроса
            comm.CommandTimeout = 30; 

            // 3 сама работа по ассинхронному режиму
            try
            {
                conn.Open();
                // создаем делегат типа 'AsyncCallback', в который заносится адрес callback-метода (GetDataCallBack - наше название метода)
                AsyncCallback cb = new AsyncCallback(GetDataCallBack);
                // добавляем '...Begin...' - тк работаем в ассинхронном режиме
                comm.BeginExecuteReader(cb, comm);
                // это сообщение выводится - когда блокируется запрос ("WAITFOR DELAY '00:00:05')
                MessageBox.Show("Added thread is working");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // callback-метод
        private void GetDataCallBack(IAsyncResult ar)
        {
            SqlDataReader reader = null;

            try
            {
                // 1 // забираем из входного пар-ра переданный об-т 'command, с кот собираемся вып-ть действия
                // тк мы будем работать с командой в ассинхронном режиме - мы ей определяем св-во - 'AsyncState'
                SqlCommand command = (SqlCommand)ar.AsyncState;
                reader = command.EndExecuteReader(ar);
                table = new DataTable();
                
                // 2
                int line = 0;

                do
                {
                    while (reader.Read())
                    {
                        if (line == 0)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)

                                table.Columns.Add(reader.GetName(i));

                            line++;
                        }

                        DataRow row = table.NewRow();

                        for (int i = 0; i < reader.FieldCount; i++)
                            row[i] = reader[i];

                        table.Rows.Add(row);
                    }
                } while (reader.NextResult());

                DGVAction(); // метод для передачи данных из буферной таблички на внешний поток
            }
            catch (Exception ex)
            {
                MessageBox.Show("From CB 1:" + ex.Message);
            }
            finally
            {
                try
                {
                    if (!reader.IsClosed)
                        reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("From CB 2:" + ex.Message);
                }
            }
        }

        private void DGVAction()
        {
            if (dataGridView1.InvokeRequired)
            {
                // при событии чтения наших данных - создаем наш action delegate
                dataGridView1.Invoke(new Action(DGVAction));
                return;
            }

            // передаем данные в 'DataGridView'
            dataGridView1.DataSource = table;
        }

        private void bt_fill_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cs);
                set = new DataSet();
                string str_sel = tbReq.Text;
                da = new SqlDataAdapter(str_sel, conn);
                dataGridView1.DataSource = null;
                cmd = new SqlCommandBuilder(da);
                da.Fill(set, "table_1");
                dataGridView1.DataSource = set.Tables["table_1"];
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                if (conn != null) { conn.Close(); }
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            da.Update(set, "table_1");
        }

        private void bt_WH_Click(object sender, EventArgs e)
        {
            const string AsyncEnable = "Asynchronous Processing=true";

            if (!cs.Contains(AsyncEnable))
                cs = String.Format("{0}; {1}", cs, AsyncEnable);

            conn = new SqlConnection(cs);
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "WAITFOR DELAY '00:00:05'; select * from dbo.Teachers;";
            comm.CommandType = CommandType.Text;
            comm.CommandTimeout = 30;

            try
            {
                conn.Open();
                // в 'BeginExecuteReader()' не передаем пар-ры // callback-делегата нет
                IAsyncResult res = comm.BeginExecuteReader();
                if (!res.IsCompleted)
                    Console.WriteLine("End");        

                WaitHandle handle = res.AsyncWaitHandle;
                if (handle.WaitOne(10000)) // тормозим
                    GetData(comm, res); // метод нужен, чтобы получить рез-т

                else
                    MessageBox.Show("Timeout exceeded");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetData(SqlCommand comm, IAsyncResult res)
        {
            SqlDataReader reader = null;

            try
            {
                reader = comm.EndExecuteReader(res); // останавливаем наш поток
                table = new DataTable();
                dataGridView1.DataSource = null;

                int line = 0;

                do
                {
                    while (reader.Read())
                    {
                        if (line == 0)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                                table.Columns.Add(reader.GetName(i));

                            line++;
                        }

                        DataRow row = table.NewRow();

                        for (int i = 0; i < reader.FieldCount; i++)
                            row[i] = reader[i];

                        table.Rows.Add(row);
                    }
                } while (reader.NextResult());

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("From GetData" + ex.Message);
            }
            finally
            {
                try
                {
                    if (!reader.IsClosed)
                        reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("From CB 2:" + ex.Message);
                }
            }
        }

        // 2 ///////////////////////////////////////////////// Async await
        private async void bt_show_Click(object sender, EventArgs e)
        {
            await conn.OpenAsync(); // вызываем с помощью 'await'
            DbCommand comm = conn.CreateCommand();
           
            comm.CommandText = "WAITFOR DELAY '00:00:05' ;";
            comm.CommandText += tbReq.Text.ToString();

            DataTable table = new DataTable();

            using (DbDataReader red = await comm.ExecuteReaderAsync()) // вызываем с помощью 'await'
            {
                int line = 0;
                do
                {
                    while (await red.ReadAsync()) // вызываем с помощью 'await'
                    {
                        if (line == 0)
                        {
                            for (int i = 0; i < red.FieldCount; i++)
                                table.Columns.Add(red.GetName(i));

                            line++;
                        }

                        DataRow row = table.NewRow();

                        for (int i = 0; i < red.FieldCount; i++)
                            row[i] = await red.GetFieldValueAsync<Object>(i); //читаем [i]-ый об-т

                        table.Rows.Add(row);
                    }
                } while (red.NextResult());
            }

            dataGridView1.DataSource = table;
        }

        //////////////////////////////////// create ///////////////////////////////////////
        
        // 1 
        //async void Method_1()
        //{
        //    //action
        //}

        //// 2
        //async Task<int> Method_2()
        //{
        //    int res;
        //    //action
        //    return res;
        //}

        ///////////////////////////////////// function ////////////////////////////////////
        
        // 1
        // await Method_1();

        // 2
        // int n = await Method_2();

        // Если ызываем стандартную функцию - она должна об-но называться с 'async' в конце,
        // а вызываться 'await'
    }
}
