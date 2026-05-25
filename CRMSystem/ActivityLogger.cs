using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CRMSystem
{
    public static class ActivityLogger
    {
        public static void Log(string userName, string userRole, string action)
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO ActivityLog
                                 (UserName, UserRole, Action)
                                 VALUES
                                 (@UserName, @UserRole, @Action)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@UserRole", userRole);
                    command.Parameters.AddWithValue("@Action", action);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
