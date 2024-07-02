using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //подключаем
using System.Configuration; //подключаем

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["Academy_add"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();

                ////TeacherById

                //string teacher_id = "dbo.stp_TeacherByID"; // выбираем хранимую процедуру
                //SqlCommand cmd = new SqlCommand(teacher_id, conn);
                //// определаем у нашей команды тип - 'StoredProcedure', дефолтно - текст (как раньше делали)
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //// public SqlParameterCollection Parametrs { get; }
                //// к параметрам мы будем обращаться, когда у нас будет какое-то возвращаемое значение
                //// Мы должны сказать, что @teacherID - это входной пар-р для нашей хранимой процедуры
                //// 1 пар-р: имя входящего пар-ра, 2 пар-р: тип этого входящего пар-ра

                //// a
                ////SqlParameter t_id = cmd.Parameters.Add("@teacherID", System.Data.SqlDbType.Int);
                ////t_id.Value = 15; // зададим айдишник 't_id', значение 'Value' // передали айди в хранимую процедуру

                //// b // сокращенный способ передачи пар-ра // неявное попадание
                //cmd.Parameters.AddWithValue("@teacherID", 15); // нужно быть уверенным, что второй пар-р нужного типа

                //SqlDataReader dr = cmd.ExecuteReader(); // достаем строку, а это не одно значение, а целый массив записей

                //while (dr.Read()) 
                //{
                //    var f0 = dr[0];
                //    var f3 = dr[3];
                //    var f2 = dr[2];
                //    var f5 = dr[5];
                //    Console.WriteLine($"{f0,4} {f3,4} {f2,4} {f5,4}");
                //}

                //dr.Close(); // желательно закрывать

                //Insert - 1

                //a

                //string teacher_add = "dbo.stp_TeacherAdd_1";
                //SqlCommand cmd = new SqlCommand(teacher_add, conn);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //// добавляем все пар-ры, кот. 'not null', остальные не обязательно добавлять
                //cmd.Parameters.AddWithValue("@EmploymentDate", DateTime.Now.ToShortDateString());
                //cmd.Parameters.AddWithValue("@Name_", "Ella");
                //cmd.Parameters.AddWithValue("@Surname", "Chornogor");
                //cmd.Parameters.AddWithValue("@Premium", 300);
                //cmd.Parameters.AddWithValue("@Salary", 1000);
                //cmd.Parameters.AddWithValue("@IsAssistent", 0);
                //cmd.Parameters.AddWithValue("@IsProfessor", 1);
                //cmd.Parameters.AddWithValue("@PositionId", 1);

                //SqlParameter t_id = cmd.Parameters.Add("@TeacherID", System.Data.SqlDbType.Int);

                //// если наша процедура вернет нам айди об-та, кот. мы добавим
                //t_id.Direction = System.Data.ParameterDirection.Output;// говори что этот пар-р типа 'output'
                //// здесь не 'value', а 'direction', тк у нас возвращать должно

                //cmd.ExecuteNonQuery();
                //Console.WriteLine((int)t_id.Value); //изначально 't_id' - это 'object', поэтому приводим к 'int'

                //b // с исп-ем 'SqlCommandBuilder'

                //string teacher_add = "dbo.stp_TeacherAdd_1"; //output
                //SqlCommand cmd = new SqlCommand(teacher_add, conn);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlCommandBuilder.DeriveParameters(cmd);

                //cmd.Parameters[9].Value = DBNull.Value; // это нащ айди
                //cmd.Parameters[1].Value = DateTime.Now.AddYears(-1).ToShortDateString();
                //cmd.Parameters[2].Value = "Elena_new";
                //cmd.Parameters[3].Value = "Chornogor_new";
                //cmd.Parameters[4].Value = 100;
                //cmd.Parameters[5].Value = 1000;
                //cmd.Parameters[6].Value = 0;
                //cmd.Parameters[7].Value = 1;
                //cmd.Parameters[8].Value = 1;

                //cmd.ExecuteNonQuery();

                //int new_t = (int)cmd.Parameters[9].Value; //возвращаем наш айди
                //Console.WriteLine(new_t);

                //Insert - 2

                //a

                //string teacher_add = "dbo.stp_TeacherAdd_2";
                //SqlCommand cmd = new SqlCommand(teacher_add, conn);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@EmploymentDate", DateTime.Now.ToShortDateString());
                //cmd.Parameters.AddWithValue("@Name_", "Иван");
                //cmd.Parameters.AddWithValue("@Surname", "Иванов");
                //cmd.Parameters.AddWithValue("@Premium", 300);
                //cmd.Parameters.AddWithValue("@Salary", 5300);
                //cmd.Parameters.AddWithValue("@IsAssistent", 0);
                //cmd.Parameters.AddWithValue("@Isprofessor", 0);
                //cmd.Parameters.AddWithValue("@PositionId", 1);

                //SqlParameter t_id = cmd.Parameters.Add("@TeacherID", System.Data.SqlDbType.Int);
                //t_id.Direction = System.Data.ParameterDirection.ReturnValue; // не 'output', а 'return'

                //cmd.ExecuteNonQuery();
                //int new_id = (int)cmd.Parameters["@TeacherID"].Value;
                //Console.WriteLine(new_id);

                //b // с исп-ем 'SqlCommandBuilder'

                //string teacher_add = "dbo.stp_TeacherAdd_2"; //return
                //SqlCommand cmd = new SqlCommand(teacher_add, conn);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //// для того, чтобы не запоминать имена пар-ов - исп-ем этот класс // можно обращаться по индексу
                //SqlCommandBuilder.DeriveParameters(cmd);

                //cmd.Parameters[0].Value = DBNull.Value; // пока ничего не передаем
                //cmd.Parameters[1].Value = DateTime.Now.AddYears(-1).ToShortDateString();// сегодняшняя дата минус 1 год
                //cmd.Parameters[2].Value = "Ella";
                //cmd.Parameters[3].Value = "Chornogor";
                //cmd.Parameters[4].Value = 100;
                //cmd.Parameters[5].Value = 1000;
                //cmd.Parameters[6].Value = 0;
                //cmd.Parameters[7].Value = 1;
                //cmd.Parameters[8].Value = 1;

                //cmd.ExecuteNonQuery();

                //int new_t = (int)cmd.Parameters[0].Value; // сюда встанет айди, можно его уже просмотреть
                //Console.WriteLine(new_t);

                // delete

                //string teacher_delete = "dbo.stp_teacherDelete";
                //SqlCommand cmd = new SqlCommand(teacher_delete, conn);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@teacherID", 71);
                //int rowsAffected = cmd.ExecuteNonQuery();
                //Console.WriteLine(rowsAffected);
            }

            Console.ReadKey();
        }
    }
}
