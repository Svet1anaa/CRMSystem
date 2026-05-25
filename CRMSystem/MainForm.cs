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

namespace CRMSystem
{
    public partial class MainForm : Form
    {
        private string UserRole;
        private string FullName;

        public MainForm(string role, string fullName)
        {
            InitializeComponent();
            UserRole = role;
            FullName = fullName;
            ShowDashboard();
            ShowUserInfo();
            //LoadTaskNotifications();
            ApplyRolePermissions();
            ActivityLogger.Log(FullName, UserRole, "User logged in");

        }

        private void ShowUserInfo()
        {
            lblCurrentUser.Text = "Welcome, " + FullName;
            if (UserRole != "Admin")
            {
                btnUsers.Visible = false;
            }
        }

        /*private void LoadTaskNotifications()
        {
            int overdueTasks = 0;
            int todayTasks = 0;

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT
                SUM(CASE WHEN DueDate < CAST(GETDATE() AS DATE)
                         AND Status <> 'Completed' THEN 1 ELSE 0 END) AS OverdueTasks,
                SUM(CASE WHEN CAST(DueDate AS DATE) = CAST(GETDATE() AS DATE)
                         AND Status <> 'Completed' THEN 1 ELSE 0 END) AS TodayTasks
            FROM Tasks";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        overdueTasks = reader["OverdueTasks"] == DBNull.Value
                            ? 0
                            : Convert.ToInt32(reader["OverdueTasks"]);

                        todayTasks = reader["TodayTasks"] == DBNull.Value
                            ? 0
                            : Convert.ToInt32(reader["TodayTasks"]);
                    }
                }
            }

            if (overdueTasks > 0 || todayTasks > 0)
            {
                lblNotifications.Text =
                    $"⚠ You have {overdueTasks} overdue task(s) and {todayTasks} task(s) due today.";

                lblNotifications.Visible = true;
            }
            else
            {
                lblNotifications.Visible = false;
            }
        }
        */

        private void ShowDashboard()
        {
            foreach (Control control in panelContent.Controls)
            {
                control.Dispose();
            }

            panelContent.Controls.Clear();

            DashboardControl dashboardControl = new DashboardControl();
            dashboardControl.Dock = DockStyle.Fill;

            panelContent.Controls.Add(dashboardControl);
        }

        private void ShowSectionLabel(string sectionName)
        {
            panelContent.Controls.Clear();

            Label sectionLabel = new Label();
            sectionLabel.Text = sectionName;
            sectionLabel.AutoSize = true;
            sectionLabel.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            sectionLabel.Location = new Point(30, 30);

            panelContent.Controls.Add(sectionLabel);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
            //LoadTaskNotifications();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ClientsControl clientsControl = new ClientsControl(UserRole, FullName);
            clientsControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(clientsControl);
        }

        private void btnDeals_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            DealsControl dealsControl = new DealsControl(UserRole, FullName);
            dealsControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(dealsControl);
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            TaskControl tasksControl = new TaskControl(UserRole, FullName);
            tasksControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(tasksControl);
        }

        private void ShowUsers()
        {
            panelContent.Controls.Clear();
            UsersControl usersControl = new UsersControl();
            usersControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(usersControl);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivityLogger.Log(FullName, UserRole, "User logged out");
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }

        private void ApplyRolePermissions()
        {
            if (UserRole != "Admin")
            {
                btnActivityLog.Visible = false;
            }
        }

        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            ActivityLogControl activityLogControl = new ActivityLogControl();
            activityLogControl.Dock = DockStyle.Fill;

            panelContent.Controls.Add(activityLogControl);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}