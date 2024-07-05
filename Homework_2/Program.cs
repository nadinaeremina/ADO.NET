using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Configuration; 

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["Academy_add"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();

                // Update

                // 1

                string change_premium = "dbo.change_premium";
                SqlCommand cmd = new SqlCommand(change_premium, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected);

                // 2

                //string change_status = "dbo.change_status";
                //SqlCommand cmd = new SqlCommand(change_status, conn);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;

                ////SqlParameter t_id = cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                //cmd.Parameters.AddWithValue("@id", 70);

                //SqlDataReader dr = cmd.ExecuteReader();

                //while (dr.Read())
                //{
                //    var f0 = dr[0];
                //    var f3 = dr[3];
                //    var f2 = dr[2];
                //    var f7 = dr[7];
                //    Console.WriteLine($"{f0,4} {f3,4} {f2,4} {f7,4}");
                //}

                //Console.WriteLine("Ok!");

                //dr.Close(); 
            }
        }
    }
}
