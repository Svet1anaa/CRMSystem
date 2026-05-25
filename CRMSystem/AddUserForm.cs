using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CRMSystem
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text;

            if (fullName == "" || email == "" || password == "" || role == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string passwordHash = PasswordHelper.HashPassword(password);

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            INSERT INTO Users (FullName, Email, PasswordHash, Role)
            VALUES (@FullName, @Email, @PasswordHash, @Role)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    command.Parameters.AddWithValue("@Role", role);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User added successfully.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
