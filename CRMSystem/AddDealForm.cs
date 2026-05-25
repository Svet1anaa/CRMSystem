using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRMSystem
{
    public partial class AddDealForm : Form
    {
        public int SelectedClientId { get; private set; }
        public string DealName { get; private set; }
        public decimal Amount { get; private set; }
        public string Status { get; private set; }
        public AddDealForm()
        {
            InitializeComponent();
            LoadClients();
            LoadStatuses();
        } 

        public AddDealForm(int clientId, string dealName, decimal amount, string status)
        {
            InitializeComponent();
            LoadClients();
            LoadStatuses();

            for (int i = 0; i < cmbClients.Items.Count; i++)
            {
                if (((ComboBoxItem)cmbClients.Items[i]).Value == clientId)
                {
                    cmbClients.SelectedIndex = i;
                    break;
                }
            }

            txtDealName.Text = dealName;
            txtAmount.Text = amount.ToString();
            cmbStatus.SelectedItem = status;
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
            {
                cmbClients.SelectedIndex = 0;
            }
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

            if (string.IsNullOrWhiteSpace(txtDealName.Text))
            {
                MessageBox.Show("Deal name is required.");
                txtDealName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Amount is required.");
                txtAmount.Focus();
                return;
            }

            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal parsedAmount))
            {
                MessageBox.Show("Please enter a valid amount.");
                txtAmount.Focus();
                return;
            }

            if (parsedAmount <= 0)
            {
                MessageBox.Show("Amount must be greater than zero.");
                txtAmount.Focus();
                return;
            }

            SelectedClientId = ((ComboBoxItem)cmbClients.SelectedItem).Value;
            DealName = txtDealName.Text.Trim();
            Amount = parsedAmount;
            Status = cmbStatus.SelectedItem.ToString();

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

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblClient_Click(object sender, EventArgs e)
        {

        }
    }
}
