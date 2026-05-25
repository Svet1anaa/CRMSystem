using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMSystem
{
    public partial class AddClientForm : Form
    {
        private int editingClientId = 0;
        public string ClientName { get; private set; }
        public string ClientEmail { get; private set; }
        public string ClientPhone { get; private set; }
        public string ClientCompany { get; private set; }
        public string Notes { get; private set; }

        public AddClientForm()
        {
            InitializeComponent();
        }

        public AddClientForm(int clientId, string name, string email, string phone, string company, string notes)
        {
            InitializeComponent();
            editingClientId = clientId;
            txtName.Text = name;
            txtEmail.Text = email;
            txtPhone.Text = phone;
            txtCompany.Text = company;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string company = txtCompany.Text.Trim();
            Notes = txtNotes.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Client name is required.");
                txtName.Focus();
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
                return;
            }

            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Please enter a valid phone number.");
                txtPhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(company))
            {
                MessageBox.Show("Company is required.");
                txtCompany.Focus();
                return;
            }

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery;

                if (editingClientId == 0)
                {
                    checkQuery = "SELECT COUNT(*) FROM Clients WHERE Email=@Email";
                }
                else
                {
                    checkQuery = "SELECT COUNT(*) FROM Clients WHERE Email=@Email AND Id<>@ClientId";
                }

                using (SqlCommand command = new SqlCommand(checkQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    if (editingClientId != 0)
                    {
                        command.Parameters.AddWithValue("@ClientId", editingClientId);
                    }

                    int existingCount = (int)command.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show("Client with this email already exists.");
                        txtEmail.Focus();
                        return;
                    }
                }
            }

            ClientName = name;
            ClientEmail = email;
            ClientPhone = phone;
            ClientCompany = company;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhone(string phone)
        {
            string pattern = @"^[+\d\s\-()]{6,20}$";
            return Regex.IsMatch(phone, pattern);
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }
    }
    }
