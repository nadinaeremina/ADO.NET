using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using My_DataLayer.Models_folder;

namespace My_DataLayer.Data_Layer_folder
{
    public class Data_Layer
    {
        // сюда можно вынести строку для подключения, чтобы она не была в 'main' - она будет статическим св-вом
        // 'Data Layer' - это статический класс - создаем статическое св-во 'connectionstring'
        //  в данном случае у 'set' установили дефолтное знчение
        // класс будет статическим, тк нам не нужно создавать экземпляры класс, а нужно только обращаться к методам
        public static string connectionstring { get; set; } = ConfigurationManager.ConnectionStrings["Academy_add"].ConnectionString;
        // создаем вложенные классы
        public static class Teacher // наш первый класс // также можно здесь создавать и другие классы ('Student')
        {
            // TeacherById // метод
            public static TeacherModel TeacherById(int t_id)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string teacher_id = "dbo.stp_TeacherById";
                    SqlCommand cmd = new SqlCommand(teacher_id, conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@teacherId", t_id);
                    SqlDataReader dr = cmd.ExecuteReader();
                    TeacherModel tm = null;

                    while (dr.Read())
                    {
                        int ID = (int)dr[0]; // 'object' конвертируем в 'int'
                        string FN = dr[2].ToString(); // 'object' конвертируем в 'string'
                        string LN = dr[3].ToString(); // 'object' конвертируем в 'string'
                        decimal salary = (decimal)dr[5]; // 'object' конвертируем в 'decimal'
                        tm = new TeacherModel(ID, FN, LN, salary);
                    }

                    dr.Close();
                    return tm;
                }
            }

            // Teacher_All // метод
            public static List<TeacherModel> TeachersAll()
            {
                //stp_Teacher_All
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string techer_comm = "dbo.stp_Teacher_All";
                    SqlCommand cmd = new SqlCommand(techer_comm, conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<TeacherModel> teachers = new List<TeacherModel>();
                    while (dr.Read())
                    {
                        teachers.Add(new TeacherModel((int)dr[0], dr[2].ToString(), dr[3].ToString(), (decimal)dr[5]));
                    }
                    dr.Close();
                    return teachers;
                }
            }

            // Teacher_add
            public static int Insert(TeacherModel tmp)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();
                    string techer_command = "dbo.stp_TeacherAdd_1";
                    SqlCommand cmd = new SqlCommand(techer_command, conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name_", tmp.FirstName);
                    cmd.Parameters.AddWithValue("@IsAssistent", 0);
                    cmd.Parameters.AddWithValue("@IsProfessor", 0);
                    cmd.Parameters.AddWithValue("@Surname", tmp.LastName);
                    cmd.Parameters.AddWithValue("@Premium", tmp.Premium);
                    cmd.Parameters.AddWithValue("@Salary", tmp.Salary);
                    cmd.Parameters.AddWithValue("@PositionId", 1);
                    cmd.Parameters.AddWithValue("@EmploymentDate", tmp.ED.ToShortDateString());
                    cmd.Parameters.Add("@TeacherID", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
                    cmd.ExecuteReader();
                    int t_id = Convert.ToInt32(cmd.Parameters["@TeacherID"].Value);
                    return t_id;
                }
            }

            // Delete
            public static bool Delete(int id)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();
                    string teacher_coommand = "dbo.stp_teacherDelete_1";
                    SqlCommand cmd = new SqlCommand(teacher_coommand, conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@teacherID", id);
                    cmd.Parameters.Add("@Result", System.Data.SqlDbType.Bit).Direction = System.Data.ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    bool res = Convert.ToBoolean(cmd.Parameters["@Result"].Value);
                    return res;
                }
            }
        }
    }
}
