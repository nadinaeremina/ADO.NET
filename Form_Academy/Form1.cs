using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; // подключаем
using System.Data.SqlClient;

namespace Form_Academy
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null; // обьявили обьект
        SqlDataAdapter da = null;
        DataSet ds = null;
        SqlCommandBuilder cmd = null;
        string cs = "";
        public Form1()
        {
            InitializeComponent();

            conn = new SqlConnection(); // проинициализировали обьект
            cs = ConfigurationManager.ConnectionStrings["Academy_add"].ConnectionString; // подключаем его к нашей БД
            conn.ConnectionString = cs;
        }

        private void button_fill_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cs);

                ds = new DataSet();
                string str_sel = textBox1.Text;
                da = new SqlDataAdapter(str_sel, conn);

                // в 'DataGridView' есть есть строки и столбцы, данные - это 'DataSource'
                dataGridView1.DataSource = null; // старую строку обнуляем

                // 'SqlCommandBuilder' создает поля так, как они называются в талице, читает каждую строчку таблицы,
                // заполняет каждую строчку таблицы в соответствии с полями
                cmd = new SqlCommandBuilder(da); 

                da.Fill(ds, "table_1");
                dataGridView1.DataSource = ds.Tables["table_1"];
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

        private void button_update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            da.Update(ds, "table_1");
        }
    }
}
