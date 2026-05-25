using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace CRMSystem
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            LoadStatistics();
            LoadTaskPriorityChart();
            LoadDealsStatusChart();
        }

        private void LoadStatistics()
        {
            try
            {
                string connectionString = ConfigurationManager
                    .ConnectionStrings["CRMSystemConnection"]
                    .ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    lblTotalClients.Text =
                        "Total Clients: " +
                        ExecuteCount(connection, "SELECT COUNT(*) FROM Clients");

                    lblTotalDeals.Text =
                       "Total Deals: " +
                        ExecuteCount(connection, "SELECT COUNT(*) FROM Deals");

                    lblTotalTasks.Text =
                        "Total Tasks: " +
                        ExecuteCount(connection, "SELECT COUNT(*) FROM Tasks");

                    lblCompletedDeals.Text =
                        "Completed Deals: " +
                        ExecuteCount(connection, "SELECT COUNT(*) FROM Deals WHERE Status='Completed'");

                    lblActiveDeals.Text =
                        "Active Deals: " +
                        ExecuteCount(connection, "SELECT COUNT(*) FROM Deals WHERE Status='In Progress'");

                    lblOverdueTasks.Text =
                        "Overdue Tasks: " +
                        ExecuteCount(connection, "SELECT COUNT(*) FROM Tasks WHERE DueDate < GETDATE() AND Status <> 'Completed'");

                    lblTasksDueToday.Text =
                        "Tasks Due Today: " +
                        ExecuteCount(connection, "SELECT COUNT(*) FROM Tasks WHERE CAST(DueDate AS DATE) = CAST(GETDATE() AS DATE)");

                    lblTotalAmount.Text =
                        "Total Deal Amount: " +
                        ExecuteDecimal(connection, "SELECT ISNULL(SUM(Amount),0) FROM Deals").ToString("C" ,new CultureInfo("lv-LV"));

                    lblAverageAmount.Text =
                      "Average Deal Amount: " +
                       ExecuteDecimal(connection, "SELECT ISNULL(AVG(Amount),0) FROM Deals").ToString("C", new CultureInfo("lv-LV"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading dashboard statistics:\n" + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private int ExecuteCount(SqlConnection connection, string query)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                return (int)command.ExecuteScalar();
            }
        }

        private decimal ExecuteDecimal(SqlConnection connection, string query)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                return Convert.ToDecimal(command.ExecuteScalar());
            }
        }

        private void LoadTaskPriorityChart()
        {
            chartTasks.Series.Clear();

            Series series = new Series("Tasks");
            series.ChartType = SeriesChartType.Pie;

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT Priority, COUNT(*) AS Total
            FROM Tasks
            GROUP BY Priority";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string priority = reader["Priority"].ToString();
                        int total = Convert.ToInt32(reader["Total"]);

                        series.Points.AddXY(priority, total);
                    }
                }
            }

            chartTasks.Series.Add(series);

            chartTasks.Legends[0].Enabled = true;
        }

        private void LoadDealsStatusChart()
        {
            chartDeals.Series.Clear();

            Series series = new Series("Deals");
            series.ChartType = SeriesChartType.Doughnut;

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT Status, COUNT(*) AS Total
            FROM Deals
            GROUP BY Status";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader["Status"].ToString();
                        int total = Convert.ToInt32(reader["Total"]);

                        series.Points.AddXY(status, total);
                    }
                }
            }

            chartDeals.Series.Add(series);

            chartDeals.Legends[0].Enabled = true;
        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblActiveDeals_Click(object sender, EventArgs e)
        {

        }

        private void lblOverdueTasks_Click(object sender, EventArgs e)
        {

        }

        private void lblAverageAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
