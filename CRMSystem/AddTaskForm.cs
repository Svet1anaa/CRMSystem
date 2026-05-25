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
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using static CRMSystem.AddDealForm;

namespace CRMSystem
{
    public partial class AddTaskForm : Form
    {
        public int SelectedClientId { get; private set; }
        public string TaskName { get; private set; }
        public DateTime DueDate { get; private set; }
        public string Status { get; private set; }

        public string AssignedTo { get; private set; }

        public string Priority { get; private set; }
        public AddTaskForm()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            InitializeComponent();
            dateDueDate.Format = DateTimePickerFormat.Custom;
            dateDueDate.CustomFormat = "dd/MM/yyyy";
            LoadClients();
            LoadStatuses();
            LoadUsersToAssignedComboBox();
        }

        public AddTaskForm(int clientId, string taskName, DateTime dueDate, string status,string assignedTo)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            InitializeComponent();
            dateDueDate.Format = DateTimePickerFormat.Custom;
            dateDueDate.CustomFormat = "dd/MM/yyyy";
            LoadClients();
            LoadStatuses();
            LoadUsersToAssignedComboBox();

            for (int i = 0; i < cmbClients.Items.Count; i++)
            {
                if (((ComboBoxItem)cmbClients.Items[i]).Value == clientId)
                {
                    cmbClients.SelectedIndex = i;
                    break;
                }
            }

            txtTaskName.Text = taskName;
            dateDueDate.Value = dueDate;
            cmbStatus.SelectedItem = status;

            if (!string.IsNullOrWhiteSpace(assignedTo))
            {
                cmbAssignedTo.SelectedItem = assignedTo;
            }
        }

        private void LoadClients()
        {
            cmbClients.Items.Clear();

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Name FROM Clients ORDER BY Name";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbClients.Items.Add(
                            new ComboBoxItem(
                                reader["Name"].ToString(),
                                Convert.ToInt32(reader["Id"])
                            )
                        );
                    }
                }
            }

            if (cmbClients.Items.Count > 0)
                cmbClients.SelectedIndex = 0;
        }

        private void LoadStatuses()
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("New");
            cmbStatus.Items.Add("In Progress");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Cancelled");

            cmbStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbClients.SelectedItem == null)
            {
                MessageBox.Show("Please select a client.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Task name is required.");
                return;
            }

            if (cmbAssignedTo.SelectedItem == null)
            {
                MessageBox.Show("Please select assigned user.");
                return;
            }

            if (cmbPriority.SelectedItem == null)
            {
                MessageBox.Show("Please select priority.");
                return;
            }

            SelectedClientId =
                ((ComboBoxItem)cmbClients.SelectedItem).Value;

            TaskName = txtTaskName.Text.Trim();
            DueDate = dateDueDate.Value;
            Status = cmbStatus.SelectedItem.ToString();
            AssignedTo = cmbAssignedTo.SelectedItem?.ToString();
            Priority = cmbPriority.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void LoadUsersToAssignedComboBox()
        {
            cmbAssignedTo.Items.Clear();

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT FullName FROM Users ORDER BY FullName";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbAssignedTo.Items.Add(reader["FullName"].ToString());
                    }
                }
            }

            if (cmbAssignedTo.Items.Count > 0)
            {
                cmbAssignedTo.SelectedIndex = 0;
            }
        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
