using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/*
    классы:

    DataSet
    DbDataAdapter
    DataTable

    1. Adapter
    2. -table/tables - read
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

                //1 all // select
                //SqlDataAdapter subject_adapter = new SqlDataAdapter("select * from dbo.Subjects order by 1", conn);

                //SqlCommandBuilder cmd_subject = new SqlCommandBuilder(subject_adapter);
                //DataSet ds_s = new DataSet();
                //subject_adapter.Fill(ds_s, "Subjects");
                //DataTable dt_subject = ds_s.Tables["Subjects"];
                //foreach (DataRow dr in dt_subject.Rows)
                //    Console.WriteLine($"{dr[0],5} {dr[1], 38}");

                //1 all // stored procedure
                //SqlDataAdapter subject_adapter = new SqlDataAdapter();

                //subject_adapter.InsertCommand = new SqlCommand("dbo.view_all", conn);
                //subject_adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                //subject_adapter.SelectCommand = subject_adapter.InsertCommand;

                //SqlCommandBuilder cmd_subject = new SqlCommandBuilder(subject_adapter);
                //DataSet ds_s = new DataSet();
                //subject_adapter.Fill(ds_s, "Subjects");
                //DataTable dt_subject = ds_s.Tables["Subjects"];
                //foreach (DataRow dr in dt_subject.Rows)
                //    Console.WriteLine($"{dr[0],5} {dr[1],38}");

                //2 insert
                //SqlDataAdapter subject_adapter = new SqlDataAdapter("select * from dbo.Subjects order by 1", conn);

                //SqlCommandBuilder cmd_subject = new SqlCommandBuilder(subject_adapter);
                //DataSet ds_s = new DataSet();
                //subject_adapter.Fill(ds_s, "Subjects");
                //DataTable dt_subject = ds_s.Tables["Subjects"];

                //DataRow new_subj = dt_subject.NewRow();
                //new_subj["Name_"] = "Sublect_30";
                //dt_subject.Rows.Add(new_subj);

                //subject_adapter.Update(ds_s, "Subjects"); // обновили
                //dt_subject.Clear(); // очистили память
                //subject_adapter.Fill(ds_s, "Subjects");

                //foreach (DataRow dr in dt_subject.Rows)
                //    Console.WriteLine($"{dr[0],5} {dr[1],38}");

                //3 delete
                SqlDataAdapter subject_adapter = new SqlDataAdapter("select * from dbo.Subjects order by 1", conn);

                SqlCommandBuilder cmd_subject = new SqlCommandBuilder(subject_adapter);
                DataSet ds_s = new DataSet();
                subject_adapter.Fill(ds_s, "Subjects");
                DataTable dt_subject = ds_s.Tables["Subjects"];

                dt_subject.PrimaryKey = new DataColumn[] { dt_subject.Columns["Id"] };
                DataRow row_subj_id = dt_subject.Rows.Find(9);

                if (row_subj_id != null)
                {
                    row_subj_id.Delete();
                    Console.WriteLine("Delete Ok!");
                }
                else
                    Console.WriteLine("Delete Error!");

                subject_adapter.Update(ds_s, "Subjects");
                dt_subject.Clear();
                subject_adapter.Fill(ds_s, "Subjects");

                foreach (DataRow dr in dt_subject.Rows)
                    Console.WriteLine($" {dr[0],-5} {dr[1],-60}");
            }
        }
    }
}
