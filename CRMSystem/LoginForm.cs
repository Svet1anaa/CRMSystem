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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPass.Text.Trim();

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT FullName, Role, PasswordHash
                                 FROM Users
                                 WHERE Email=@Email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);            

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show(
                                "Invalid email or password",
                                "Login Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return;
                        }

                        string storedHash = reader["PasswordHash"].ToString();
                        if (!PasswordHelper.VerifyPassword(password, storedHash))
                        {
                            MessageBox.Show(
                                "Invalid email or password",
                                "Login Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return;
                        }

                        string fullName = reader["FullName"].ToString();
                        string role = reader["Role"].ToString();

                        MainForm mainForm = new MainForm(role, fullName);
                        mainForm.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void email_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }

}