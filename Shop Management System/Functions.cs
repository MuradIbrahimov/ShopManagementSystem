using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Shop_Management_System
{
    internal class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;
        public Functions()
        {
            ConStr = @"Data Source=(localDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Shop Management System\Shop Management System\HardwareDb.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;

            dt = new DataTable();
            sda = new SqlDataAdapter();

        }
        public DataTable GetData(string Query)
        {
            dt.Clear();
            using (SqlCommand command = new SqlCommand(Query, Con))
            {
                using (sda = new SqlDataAdapter(command))
                {
                    sda.Fill(dt);
                }
            }
            return dt;
        }

        public int SetData(string Query, List<SqlParameter> parameters)
        {
            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

            // Create a new SqlCommand for each SetData call
            using (SqlCommand command = new SqlCommand(Query, Con))
            {
                // Clear existing parameters before adding new ones
                command.Parameters.Clear();

                // Add parameters to the command
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }

                cnt = command.ExecuteNonQuery();
            }

            return cnt;
        }

    }
}
