using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRMSystem
{
    public partial class ActivityLogControl : UserControl
    {
        public ActivityLogControl()
        {
            InitializeComponent();
            LoadActivityLog();
        }

        private void LoadActivityLog()
        {
            try
            {
                string connectionString = ConfigurationManager
                    .ConnectionStrings["CRMSystemConnection"]
                    .ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT
                    Id AS [ID],
                    UserName AS [User Name],
                    UserRole AS [Role],
                    Action AS [Action],
                    CreatedDate AS [Date]
                FROM ActivityLog
                ORDER BY CreatedDate DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridActivityLog.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading activity log:\n" + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }



    }
}
