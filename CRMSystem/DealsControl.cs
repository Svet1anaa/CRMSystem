using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace CRMSystem
{
    public partial class DealsControl : UserControl
    {
        private string UserRole;
        private string FullName;
        public DealsControl(string role, string fullName)
        {
            InitializeComponent();

            UserRole = role;
            FullName = fullName;
            LoadDealsFromDatabase();
            LoadClientsToFilter();
            LoadStatusFilter();
            ApplyRolePermissions();
        }

        private void LoadDealsFromDatabase()
        {
            try
            {
                string connectionString = ConfigurationManager
                    .ConnectionStrings["CRMSystemConnection"]
                    .ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    Deals.Id AS [ID],
                    Clients.Name AS [Client],
                    Deals.DealName AS [Deal Name],
                    Deals.Amount AS [Amount],
                    Deals.Status AS [Status],
                    CONVERT(varchar, Deals.CreatedDate, 23) AS [Created Date]
                FROM Deals
                INNER JOIN Clients ON Deals.ClientId = Clients.Id
                ORDER BY Deals.Id DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridDeals.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading deals:\n" + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SearchDeals()
        {
            string searchText = txtSearchDeals.Text.Trim();

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT 
                Deals.Id AS [ID],
                Clients.Name AS [Client],
                Deals.DealName AS [Deal Name],
                Deals.Amount AS [Amount],
                Deals.Status AS [Status],
                CONVERT(varchar, Deals.CreatedDate, 23) AS [Created Date]
            FROM Deals
            INNER JOIN Clients ON Deals.ClientId = Clients.Id
            WHERE 
                Deals.DealName LIKE @Search
                OR Clients.Name LIKE @Search
                OR Deals.Status LIKE @Search
            ORDER BY Deals.Id DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Search", "%" + searchText + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridDeals.DataSource = table;
                    }
                }
            }
        }

        private void ApplyRolePermissions()
        {
            if (UserRole == "Manager")
            {
                btnDeleteDeal.Enabled = false;
            }
        }

        private void DealsControl_Load(object sender, EventArgs e)
        {

        }

        private void btnEditDeal_Click(object sender, EventArgs e)
        {
            if (dataGridDeals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a deal to edit.");
                return;
            }

            DataGridViewRow selectedRow = dataGridDeals.SelectedRows[0];

            int dealId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            string clientName = selectedRow.Cells["Client"].Value.ToString();
            string dealName = selectedRow.Cells["Deal Name"].Value.ToString();
            decimal amount = Convert.ToDecimal(selectedRow.Cells["Amount"].Value);
            string status = selectedRow.Cells["Status"].Value.ToString();

            int clientId = GetClientIdByName(clientName);

            AddDealForm editForm = new AddDealForm(clientId, dealName, amount, status);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string connectionString = ConfigurationManager
                        .ConnectionStrings["CRMSystemConnection"]
                        .ConnectionString;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"UPDATE Deals
                 SET ClientId=@ClientId,
                     DealName=@DealName,
                     Amount=@Amount,
                     Status=@Status
                 WHERE Id=@Id";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ClientId", editForm.SelectedClientId);
                            command.Parameters.AddWithValue("@DealName", editForm.DealName);
                            command.Parameters.AddWithValue("@Amount", editForm.Amount);
                            command.Parameters.AddWithValue("@Status", editForm.Status);
                            command.Parameters.AddWithValue("@Id", dealId);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error updating deal:\n" + ex.Message,
                        "Database error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                LoadDealsFromDatabase();
                ActivityLogger.Log(FullName, UserRole, "Deal updated");
                MessageBox.Show("Deal updated successfully.");
            }

        }


        private void btnAddDeal_Click(object sender, EventArgs e)
        {
            AddDealForm addDealForm = new AddDealForm();

            if (addDealForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string connectionString = ConfigurationManager
                        .ConnectionStrings["CRMSystemConnection"]
                        .ConnectionString;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"INSERT INTO Deals (ClientId, DealName, Amount, Status)
                 VALUES (@ClientId, @DealName, @Amount, @Status)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ClientId", addDealForm.SelectedClientId);
                            command.Parameters.AddWithValue("@DealName", addDealForm.DealName);
                            command.Parameters.AddWithValue("@Amount", addDealForm.Amount);
                            command.Parameters.AddWithValue("@Status", addDealForm.Status);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error saving deal:\n" + ex.Message,
                        "Database error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                LoadDealsFromDatabase();
                ActivityLogger.Log(FullName, UserRole, "Deal added");
                MessageBox.Show("Deal saved successfully.");
            }

        }

        private void btnDeleteDeal_Click(object sender, EventArgs e)
        {
            if (dataGridDeals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a deal to delete.");
                return;
            }

            int dealId = Convert.ToInt32(
                dataGridDeals.SelectedRows[0].Cells["ID"].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this deal?",
                "Delete Deal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                string connectionString = ConfigurationManager
                    .ConnectionStrings["CRMSystemConnection"]
                    .ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Deals WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", dealId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error deleting deal:\n" + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            LoadDealsFromDatabase();
            ActivityLogger.Log(FullName, UserRole, "Deal deleted");
            MessageBox.Show("Deal deleted successfully.");

        }

        private int GetClientIdByName(string clientName)
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id FROM Clients WHERE Name=@Name";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", clientName);

                    return (int)command.ExecuteScalar();
                }
            }
        }


        private void LoadClientsToFilter()
        {
            cmbClientFilter.Items.Clear();

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Name FROM Clients ORDER BY Name";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    cmbClientFilter.Items.Add("All");

                    while (reader.Read())
                    {
                        cmbClientFilter.Items.Add(reader["Name"].ToString());
                    }
                }
            }

            cmbClientFilter.SelectedIndex = 0;
        }

        private void LoadStatusFilter()
        {
            cmbStatusFilter.Items.Clear();

            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("New");
            cmbStatusFilter.Items.Add("In Progress");
            cmbStatusFilter.Items.Add("Completed");
            cmbStatusFilter.Items.Add("Cancelled");

            cmbStatusFilter.SelectedIndex = 0;
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadFilteredDeals()
        {
            try
            {
                string selectedStatus = cmbStatusFilter.SelectedItem?.ToString();
                string selectedClient = cmbClientFilter.SelectedItem?.ToString();

                string connectionString = ConfigurationManager
                    .ConnectionStrings["CRMSystemConnection"]
                    .ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    Deals.Id AS [ID],
                    Clients.Name AS [Client],
                    Deals.DealName AS [Deal Name],
                    Deals.Amount AS [Amount],
                    Deals.Status AS [Status],
                    CONVERT(varchar, Deals.CreatedDate, 23) AS [Created Date]
                FROM Deals
                INNER JOIN Clients ON Deals.ClientId = Clients.Id
                WHERE 1=1";

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;

                        if (selectedStatus != "All")
                        {
                            query += " AND Deals.Status = @Status";
                            command.Parameters.AddWithValue("@Status", selectedStatus);
                        }

                        if (selectedClient != "All")
                        {
                            query += " AND Clients.Name = @ClientName";
                            command.Parameters.AddWithValue("@ClientName", selectedClient);
                        }

                        query += " ORDER BY Deals.Id DESC";

                        command.CommandText = query;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dataGridDeals.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error filtering deals:\n" + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            LoadFilteredDeals();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            cmbStatusFilter.SelectedIndex = 0;
            cmbClientFilter.SelectedIndex = 0;

            LoadDealsFromDatabase();
        }

        private void btnSearchDeals_Click(object sender, EventArgs e)
        {
            SearchDeals();

        }

        private void btnClearSearchDeals_Click(object sender, EventArgs e)
        {
            txtSearchDeals.Clear();
            LoadDealsFromDatabase();
        }

        private void btnExportDeals_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "Deals.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Deals");

                    for (int i = 0; i < dataGridDeals.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridDeals.Columns[i].HeaderText;
                        worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                    }

                    for (int i = 0; i < dataGridDeals.Rows.Count; i++)
                    {
                        if (!dataGridDeals.Rows[i].IsNewRow)
                        {
                            for (int j = 0; j < dataGridDeals.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value =
                                    dataGridDeals.Rows[i].Cells[j].Value?.ToString();
                            }
                        }
                    }

                    worksheet.Columns().AdjustToContents();

                    workbook.SaveAs(saveFileDialog.FileName);
                }

                MessageBox.Show("Deals exported successfully.");
            }

        }

        private void cmbClientFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridDeals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
