using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CRMSystem
{
    public partial class UsersControl : UserControl
    {
        public UsersControl()
        {
            InitializeComponent();
            LoadUsersFromDatabase();
        }

        private void LoadUsersFromDatabase()
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
                FullName AS [Full Name],
                Email AS [Email],
                Role AS [Role]
            FROM Users
            ORDER BY Id DESC";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridUsers.DataSource = table;
                }
            }
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            LoadUsersFromDatabase();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUsersFromDatabase();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            int id = Convert.ToInt32(dataGridUsers.CurrentRow.Cells["ID"].Value);
            string fullName = dataGridUsers.CurrentRow.Cells["Full Name"].Value.ToString();
            string email = dataGridUsers.CurrentRow.Cells["Email"].Value.ToString();
            string role = dataGridUsers.CurrentRow.Cells["Role"].Value.ToString();

            EditUserForm form = new EditUserForm(id, fullName, email, role);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUsersFromDatabase();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            int id = Convert.ToInt32(dataGridUsers.CurrentRow.Cells["ID"].Value);

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Users WHERE Id=@Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User deleted successfully.");

            LoadUsersFromDatabase();
        }
    }
}
