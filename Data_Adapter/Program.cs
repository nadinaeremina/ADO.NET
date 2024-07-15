using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/*
    // присоединенный режим - БД всегда открытая, с командами работаем напрямую 
    // преимущества - получаем данные из первоисточника, работаем моментально
    // недостатки - выполняем подключение единолично и данными мы не моем поделиться с другими частями программы до тех
    // пор, пока мы не отключим подсоединение к БД // если БД сильно загружена

    В отсоединенном режиме нужна будет подписка на изменения

    классы:
    - DataSet - об-т, кот яв-ся массивом таблиц в памяти, кот мы скопируем из БД - пользователь может работать с копиями,
    это набор разнообразных данных, копий одной или нескольких таблиц из БД, эти копии поставляет класс Adapter

    - DbDataAdapter - буферный класс, посредник м/у БД и DataSet

    - DataTable

    1. Создаем Adapter
    2. Определяем таблицы , которые будем читать (одну или несколько) 
    3. Из DataSet читаем данные и загружаем их в DataAdapter - будет создаваться табличка (DataTable)
 */

namespace Data_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["Academy_add"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();

                ////1 all // select
                //// сюда сгружаем данные // сколько у нас табличек, которые мы хотим считывать - столько адаптеров будем создавать
                //// SqlDataAdapter subject_adapter = new SqlDataAdapter("select * from dbo.Subjects order by 1", conn);

                //// структурируем данные, чтобы к ним было удобнее обращаться // передаем в него будущую копию
                //// SqlCommandBuilder cmd_subject = new SqlCommandBuilder(subject_adapter);

                //// создаем об-т 'DataSet'
                //DataSet ds_s = new DataSet();

                //// наш адаптер яв-ся кол-цией, у них есть метод 'Fill', создаем массив (DataSet) и придумываем ему имя
                //// наши данные из 'DataAdapter' передадутся в 'DataSet' ('ds_s')
                ///DataSet - хранилище данных из таблиц из БД, получаем мы их с помощью Adapter
                //subject_adapter.Fill(ds_s, "Subjects");

                //// создаем таблицу // берем из 'Dataset' (множество таблиц) таблицу по ключу
                //DataTable dt_subject = ds_s.Tables["Subjects"];

                //// читаем данные (наш об-т - как двумерный массиы, есть таблицы, а есть строки) 
                /// 'Datarow' - это массивстолбцов
                //foreach (DataRow dr in dt_subject.Rows)
                //    Console.WriteLine($"{dr[0],5} {dr[1], 38}");
                //// показываем первый столбец и второй из строки

                ////1 all // stored procedure
                //SqlDataAdapter subject_adapter = new SqlDataAdapter();

                //// ничего не вписали в SqlDataAdapter(), тк можем воспользоваться спец командой 'InsertCommand'
                //subject_adapter.InsertCommand = new SqlCommand("dbo.view_all", conn);
                //subject_adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                //subject_adapter.SelectCommand = subject_adapter.InsertCommand;

                //SqlCommandBuilder cmd_subject = new SqlCommandBuilder(subject_adapter);

                //DataSet ds_s = new DataSet();

                //subject_adapter.Fill(ds_s, "Subjects");

                //DataTable dt_subject = ds_s.Tables["Subjects"];

                //foreach (DataRow dr in dt_subject.Rows)
                //    Console.WriteLine($"{dr[0],5} {dr[1],38}");

                ////2 insert
                //SqlDataAdapter subject_adapter = new SqlDataAdapter("select * from dbo.Subjects order by 1", conn);

                //SqlCommandBuilder cmd_subject = new SqlCommandBuilder(subject_adapter);
                //DataSet ds_s = new DataSet();
                //subject_adapter.Fill(ds_s, "Subjects");
                //DataTable dt_subject = ds_s.Tables["Subjects"];

                //// создаем Row, чтобы добавить в коллекцию
                //DataRow new_subj = dt_subject.NewRow();
                //new_subj["Name_"] = "Sublect_30";
                
                //// добавляем строку в таблицу
                //dt_subject.Rows.Add(new_subj);

                //// обновляем таблицу, которая наход-ся в нашем буферном классе
                //subject_adapter.Update(ds_s, "Subjects");

                //// очистили память // наш DataSet
                //dt_subject.Clear(); 

                //// заполняем нашу буферную таблицу
                //subject_adapter.Fill(ds_s, "Subjects");

                //// читаем заново
                //foreach (DataRow dr in dt_subject.Rows)
                //    Console.WriteLine($"{dr[0],5} {dr[1],38}");

                ////3 delete // без хранимой процедуры, по запросу нашей колонки
                //SqlDataAdapter subject_adapter = new SqlDataAdapter("select * from dbo.Subjects order by 1", conn);

                //SqlCommandBuilder cmd_subject = new SqlCommandBuilder(subject_adapter);
                //DataSet ds_s = new DataSet();
                //subject_adapter.Fill(ds_s, "Subjects");
                //DataTable dt_subject = ds_s.Tables["Subjects"];

                //// находим колонку, чтобы создать в ней ключ // нам нужна колонка с ключ 'id'
                //dt_subject.PrimaryKey = new DataColumn[] { dt_subject.Columns["Id"] };

                //// создаем строку, которая будет нам из 'DataTable' искать ('Find') по индексу
                //DataRow row_subj_id = dt_subject.Rows.Find(9);

                //if (row_subj_id != null)
                //{
                //    row_subj_id.Delete();
                //    Console.WriteLine("Delete Ok!");
                //}
                //else
                //    Console.WriteLine("Delete Error!");

                //// обновляем адаптер
                //subject_adapter.Update(ds_s, "Subjects");

                //// очистили
                //dt_subject.Clear();

                //// считали данные обратно из таблички
                //subject_adapter.Fill(ds_s, "Subjects");

                //// показываем записи, которые остались
                //foreach (DataRow dr in dt_subject.Rows)
                //    Console.WriteLine($" {dr[0],-5} {dr[1],-60}");

                conn.Close();
            }
        }
    }
}
