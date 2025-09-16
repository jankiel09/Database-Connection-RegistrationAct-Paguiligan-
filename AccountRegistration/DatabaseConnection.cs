using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AccountRegistration
{
    public class DatabaseConnection
    {
        // Connection string 
        private static string connectionString = @"Data Source=KIEL;Initial Catalog=StudentRegistrationDB;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
