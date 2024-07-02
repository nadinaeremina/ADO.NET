using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Configuration;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["Event_poster_add"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();

                string sqlcommand_1 = "select en.Title as N'Название события:', ec.Date_ as N'Дата:' " +
                    "from [Event_poster].[events_].[Event_content] ec join [Event_poster].[events_].[Event_name] " +
                    "en on ec.Event_nameId = en.ID where ec.Date_ = '2024-06-25'",

                sqlcommand_2 = "select en.Title as N'Название события:', eca.Title as N'Категория:', " +
                    "Convert(date, ec.Date_) as N'Дата:', ec.Time_ as N'Время:' from [Event_poster].[events_].[Event_content] " +
                    "ec join [Event_poster].[events_].[Event_name] en on ec.Event_nameId = en.ID join " +
                    "[Event_poster].[events_].[Event_category] eca on en.Event_categoryId = eca.ID where " +
                    "eca.Title = N'Детям' and ec.Date_ > '2024-06-25'",

                sqlcommand_3 = "delete from [Event_poster].[sold].[Buy_tickets] where id = 2",

                sqlcommand_4 = "update [Event_poster].[sold].[Buy_tickets] set [Value_] = 4500.00 " +
                    "where id = 3",

                sqlcommand_5 = "select count(en.Title), ec.Date_ as N'Дата:' from " +
                    "[Event_poster].[events_].[Event_content] ec join [Event_poster].[events_].[Event_name]" +
                    " en on ec.Event_nameId = en.ID group by ec.Date_ having ec.Date_ = '2024-06-25'",

                sqlcommand_6 = "select sum(b.Value_) from [Event_poster].[sold].[Buy_tickets] b join" +
                " [Event_poster].[clients].[Clients] c on b.ClientId = c.ID where c.ID = 236";

                /////////////////////////////////////// ExecuteReader ///////////////////////////////////////////

                // 1 

                //SqlCommand cmd_1 = new SqlCommand(sqlcommand_1, conn);
                //SqlDataReader dr_1 = cmd_1.ExecuteReader();
                //Console.WriteLine("Названия событий, которые пройдут 25 июня 2024 года: \n");

                //while (dr_1.Read())
                //{
                //    var f0 = dr_1[0];
                //    Console.WriteLine($"{f0,4}");
                //}

                //Console.WriteLine("\n");

                // 2

                //SqlCommand cmd_2 = new SqlCommand(sqlcommand_2, conn);
                //SqlDataReader dr_2 = cmd_2.ExecuteReader();
                //Console.WriteLine("Дата и время детских мероприятий: \n");

                //while (dr_2.Read())
                //{
                //    var f0 = dr_2[0];
                //    var f2 = dr_2[2];
                //    var f3 = dr_2[3];
                //    Console.WriteLine($"{f0,4} {(DateTime)f2,4:dd/MM/yyyy} {f3,4}");
                //}

                //Console.WriteLine("\n");

                ///////////////////////////////////////// ExecuteNonQuery ////////////////////////////////////////

                // 1

                // Прикреплено 2 Скриншота называются "Удаление-до" и "Удаление-после"
                //SqlCommand cmd_3 = new SqlCommand(sqlcommand_3, conn);
                //int res = cmd_3.ExecuteNonQuery();
                //Console.WriteLine("Ok");

                // 2

                // Прикреплено 2 Скриншота называются "Изменение-до" и "Изменение-после"
                //SqlCommand cmd_4 = new SqlCommand(sqlcommand_4, conn);
                //int res = cmd_4.ExecuteNonQuery();
                //Console.WriteLine("Ok");

                //////////////////////////////////////// Executescalar ////////////////////////////////////////////

                // 1

                //SqlCommand cmd_5 = new SqlCommand(sqlcommand_5, conn);
                //object res = cmd_5.ExecuteScalar();
                //Console.WriteLine($"Количество событий, которые пройдут 25.06.2024: {res}");
                //Console.WriteLine("\n");

                // 2

                //SqlCommand cmd_6 = new SqlCommand(sqlcommand_6, conn);
                //object res = cmd_6.ExecuteScalar();
                //Console.WriteLine($"У клиента с id = 236 куплено билетов на общую сумму: {Convert.ToDouble(res)}");
                //Console.WriteLine("\n");
            }
        }
    }
}
