using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Models;

namespace Exam.Data_Layer_folder
{
    public class Date_Layer_model
    {
        public static string connectionstring { get; set; } = ConfigurationManager.ConnectionStrings["Events"].ConnectionString;
        public static class Event_category
        {
            public static void Insert(string tmp)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string event_command = "dbo.Event_category_add";
                    SqlCommand cmd = new SqlCommand(event_command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Title", tmp);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static class Country
        {
            public static void Insert(string tmp)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string event_command = "dbo.Country_add";
                    SqlCommand cmd = new SqlCommand(event_command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Title", tmp);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static class City
        {
            public static void Insert(string tmp, int country_id)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string event_command = "dbo.Citi_add";
                    SqlCommand cmd = new SqlCommand(event_command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Title", tmp);
                    cmd.Parameters.AddWithValue("@CountryId", country_id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static class Client
        {
            public static void Insert(Client_model client)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string event_command = "dbo.Client_add";
                    SqlCommand cmd = new SqlCommand(event_command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommandBuilder.DeriveParameters(cmd);

                    cmd.Parameters[0].Value = DBNull.Value;
                    cmd.Parameters[1].Value = client.First_name;
                    cmd.Parameters[2].Value = client.Last_name;
                    cmd.Parameters[3].Value = client.Middle_name;
                    cmd.Parameters[4].Value = client.Email;
                    cmd.Parameters[5].Value = client.Birthday;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
