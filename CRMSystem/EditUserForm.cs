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
    public partial class EditUserForm : Form
    {
        private int UserId;
        public EditUserForm(int id, string fullName, string email, string role)
        {
            InitializeComponent();
            UserId = id;

            txtFullName.Text = fullName;
            txtEmail.Text = email;
            cmbRole.Text = role;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.Text;

            if (fullName == "" || email == "" || role == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    UPDATE Users
                    SET FullName=@FullName,
                        Email=@Email,
                        Role=@Role
                    WHERE Id=@Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@Id", UserId);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User updated successfully.");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}

