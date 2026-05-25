using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using ClosedXML.Excel;

namespace CRMSystem
{
    public partial class ClientsControl : UserControl
    {
        public string UserRole;
        public string FullName;

        public ClientsControl(string role, string fullName)
        {
            InitializeComponent();

            UserRole = role;
            FullName = fullName;

            dataGridClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClients.MultiSelect = false;

            LoadClientsFromDatabase();
            ApplyRolePermissions();
        }

        private void LoadClientsFromDatabase()
        {
            dataGridClients.Columns.Clear();
            dataGridClients.Rows.Clear();

            dataGridClients.Columns.Add("Id", "ID");
            dataGridClients.Columns.Add("Name", "Name");
            dataGridClients.Columns.Add("Email", "Email");
            dataGridClients.Columns.Add("Phone", "Phone");
            dataGridClients.Columns.Add("Company", "Company");
            dataGridClients.Columns.Add("Notes", "Notes");

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Name, Email, Phone, Company, Notes FROM Clients";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridClients.Rows.Add(
                            reader["Id"].ToString(),
                            reader["Name"].ToString(),
                            reader["Email"].ToString(),
                            reader["Phone"].ToString(),
                            reader["Company"].ToString(),
                            reader["Notes"].ToString()
                        );
                    }
                }
            }
        }

        private void ApplyRolePermissions()
        {
            if (UserRole == "Manager")
            {
                btnDeleteClient.Enabled = false;
            }
        }

        private void ClientsControl_Load(object sender, EventArgs e)
        {

        }

        private void SearchClients(string searchText)
        {
            searchText = searchText.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridClients.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string name = row.Cells["Name"].Value?.ToString()?.ToLower() ?? "";
                string email = row.Cells["Email"].Value?.ToString()?.ToLower() ?? "";
                string phone = row.Cells["Phone"].Value?.ToString()?.ToLower() ?? "";
                string company = row.Cells["Company"].Value?.ToString()?.ToLower() ?? "";

                bool matches =
                    name.Contains(searchText) ||
                    email.Contains(searchText) ||
                    phone.Contains(searchText) ||
                    company.Contains(searchText);

                row.Visible = matches;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();

            if (addClientForm.ShowDialog() == DialogResult.OK)
            {
                string connectionString = ConfigurationManager
                    .ConnectionStrings["CRMSystemConnection"]
                    .ConnectionString;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"INSERT INTO Clients (Name, Email, Phone, Company,Notes)
                 VALUES (@Name, @Email, @Phone, @Company, @Notes)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", addClientForm.ClientName);
                            command.Parameters.AddWithValue("@Email", addClientForm.ClientEmail);
                            command.Parameters.AddWithValue("@Phone", addClientForm.ClientPhone);
                            command.Parameters.AddWithValue("@Company", addClientForm.ClientCompany);
                            command.Parameters.AddWithValue("@Notes", addClientForm.Notes);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error saving client:\n" + ex.Message,
                        "Database error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                LoadClientsFromDatabase();
                ActivityLogger.Log(FullName, UserRole, "Client added");

                MessageBox.Show("Client saved successfully.");
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dataGridClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a client to edit.");
                return;
            }

            DataGridViewRow selectedRow = dataGridClients.SelectedRows[0];

            int clientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            string name = selectedRow.Cells["Name"].Value?.ToString() ?? "";
            string email = selectedRow.Cells["Email"].Value?.ToString() ?? "";
            string phone = selectedRow.Cells["Phone"].Value?.ToString() ?? "";
            string company = selectedRow.Cells["Company"].Value?.ToString() ?? "";
            string notes = selectedRow.Cells["Notes"].Value?.ToString() ?? "";

            AddClientForm editClientForm =
                new AddClientForm(clientId, name, email, phone, company, notes);

            if (editClientForm.ShowDialog() == DialogResult.OK)
            {
                string connectionString = ConfigurationManager
                    .ConnectionStrings["CRMSystemConnection"]
                    .ConnectionString;

                try
                {
                    using (SqlConnection connection =
                           new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"UPDATE Clients
                 SET Name=@Name,
                     Email=@Email,
                     Phone=@Phone,
                     Company=@Company
                     Notes=@Notes
                 WHERE Id=@Id";

                        using (SqlCommand command =
                               new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name",
                                editClientForm.ClientName);

                            command.Parameters.AddWithValue("@Email",
                                editClientForm.ClientEmail);

                            command.Parameters.AddWithValue("@Phone",
                                editClientForm.ClientPhone);

                            command.Parameters.AddWithValue("@Company",
                                editClientForm.ClientCompany);

                            command.Parameters.AddWithValue("@Notes", 
                                editClientForm.Notes);

                            command.Parameters.AddWithValue("@Id", clientId);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error updating client:\n" + ex.Message,
                        "Database error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
              
                LoadClientsFromDatabase();
                ActivityLogger.Log(FullName, UserRole, "Client updated");
                MessageBox.Show("Client updated successfully.");
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a client to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this client?",
                "Delete Client",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dataGridClients.SelectedRows[0];

                int clientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (ClientHasRelatedRecords(clientId))
                {
                    MessageBox.Show(
                        "This client cannot be deleted because related deals or tasks exist.",
                        "Delete not allowed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }


                string connectionString = ConfigurationManager
                    .ConnectionStrings["CRMSystemConnection"]
                    .ConnectionString;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM Clients WHERE Id=@Id";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", clientId);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error deleting client:\n" + ex.Message,
                        "Database error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                LoadClientsFromDatabase();
                ActivityLogger.Log(FullName, UserRole, "Client deleted");
                MessageBox.Show("Client deleted successfully.");
            }
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchClient.Text))
            {
                MessageBox.Show("Please enter search text.");
                return;
            }

            SearchClients(txtSearchClient.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchClient.Clear();

            foreach (DataGridViewRow row in dataGridClients.Rows)
            {
                if (!row.IsNewRow)
                    row.Visible = true;
            }
        }

        private bool ClientHasRelatedRecords(int clientId)
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT 
                (SELECT COUNT(*) FROM Deals WHERE ClientId=@ClientId) +
                (SELECT COUNT(*) FROM Tasks WHERE ClientId=@ClientId)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", clientId);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void btnExportClients_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "Clients.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Clients");

                    for (int i = 0; i < dataGridClients.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridClients.Columns[i].HeaderText;
                        worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                    }

                    for (int i = 0; i < dataGridClients.Rows.Count; i++)
                    {
                        if (!dataGridClients.Rows[i].IsNewRow)
                        {
                            for (int j = 0; j < dataGridClients.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value =
                                    dataGridClients.Rows[i].Cells[j].Value?.ToString();
                            }
                        }
                    }

                    worksheet.Columns().AdjustToContents();

                    workbook.SaveAs(saveFileDialog.FileName);
                }

                MessageBox.Show("Clients exported successfully.");
            }
        }

        private void lblClientsTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
