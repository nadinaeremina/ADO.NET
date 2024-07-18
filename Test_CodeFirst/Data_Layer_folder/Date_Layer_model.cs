using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        public static class Event_name
        {
            public static void Insert(Event_name_model ev_mod)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string event_command = "dbo.Event_name_add";
                    SqlCommand cmd = new SqlCommand(event_command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommandBuilder.DeriveParameters(cmd);

                    cmd.Parameters[0].Value = DBNull.Value;
                    cmd.Parameters[1].Value = ev_mod.Title;
                    cmd.Parameters[2].Value = ev_mod.event_category;

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static class Place
        {
            public static void Insert(Place_model place)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string event_command = "dbo.Place_add";
                    SqlCommand cmd = new SqlCommand(event_command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommandBuilder.DeriveParameters(cmd);

                    cmd.Parameters[0].Value = DBNull.Value;
                    cmd.Parameters[1].Value = place.Title;
                    cmd.Parameters[2].Value = place.city_id;

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static class Event_content
        {
            public static void Insert(Event_content_model ev_content)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string event_command = "dbo.Event_content_add";
                    SqlCommand cmd = new SqlCommand(event_command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommandBuilder.DeriveParameters(cmd);

                    cmd.Parameters[0].Value = DBNull.Value;
                    cmd.Parameters[1].Value = ev_content.Date_;
                    cmd.Parameters[2].Value = ev_content.Description_;
                    cmd.Parameters[3].Value = ev_content.Min_age;
                    cmd.Parameters[4].Value = ev_content.Max_tickets;
                    cmd.Parameters[5].Value = ev_content.Sold_tickets;
                    cmd.Parameters[6].Value = ev_content.event_name_id;
                    cmd.Parameters[7].Value = ev_content.place_id;
                    
                    cmd.ExecuteNonQuery();
                }
            }

            //public static void Add_picture(byte[] pic)
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionstring))
            //    {
            //        conn.Open();

            //        string event_command = "dbo.add_picture1";
            //        SqlCommand cmd = new SqlCommand(event_command, conn);

            //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //        SqlCommandBuilder.DeriveParameters(cmd);

            //        cmd.Parameters["Image"].Value = pic;

            //        cmd.ExecuteNonQuery();
            //    }
            //}
        }
        public static class Buy_tickets
        {
            public static void Insert(Buy_tickets_model buy_tickets)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string event_command = "dbo.Buy_tickets_add";
                    SqlCommand cmd = new SqlCommand(event_command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommandBuilder.DeriveParameters(cmd);

                    cmd.Parameters[0].Value = DBNull.Value;
                    cmd.Parameters[1].Value = buy_tickets.Value;
                    cmd.Parameters[2].Value = buy_tickets.date_of_bought;
                    cmd.Parameters[3].Value = buy_tickets.client;
                    cmd.Parameters[4].Value = buy_tickets.event_name;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
