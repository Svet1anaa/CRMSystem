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
using ClosedXML.Excel;

namespace CRMSystem
{
    public partial class TaskControl : UserControl
    {
        private string UserRole;
        private string FullName;
        private bool isLoadingTasks = false;
        public TaskControl(string role, string fullName)
        {
            InitializeComponent();

            UserRole = role;
            FullName = fullName;
            dataGridTask.AllowUserToAddRows = false;

            dataGridTask.CurrentCellDirtyStateChanged += dataGridTask_CurrentCellDirtyStateChanged;
            dataGridTask.CellValueChanged += dataGridTask_CellValueChanged;

            LoadTasksFromDatabase();
            LoadClientsToFilter();
            LoadStatusFilter();
            ApplyRolePermissions();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();

            if (addTaskForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string connectionString = ConfigurationManager
                        .ConnectionStrings["CRMSystemConnection"]
                        .ConnectionString;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"INSERT INTO Tasks
                 (ClientId, TaskName, DueDate, Status, AssignedTo, Priority)
                 VALUES
                 (@ClientId, @TaskName, @DueDate, @Status, @AssignedTo, @Priority)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ClientId", addTaskForm.SelectedClientId);
                            command.Parameters.AddWithValue("@TaskName", addTaskForm.TaskName);
                            command.Parameters.AddWithValue("@DueDate", addTaskForm.DueDate);
                            command.Parameters.AddWithValue("@Status", addTaskForm.Status);
                            command.Parameters.AddWithValue("@AssignedTo", addTaskForm.AssignedTo);
                            command.Parameters.AddWithValue("@Priority", addTaskForm.Priority);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error saving task:\n" + ex.Message,
                        "Database error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                LoadTasksFromDatabase();
                ActivityLogger.Log(FullName, UserRole, "Task added");
                MessageBox.Show("Task saved successfully.");
            }

        }

        private void ApplyRolePermissions()
        {
            if (UserRole == "Manager")
            {
                btnDeleteTask.Enabled = false;
            }
        }

        private void LoadTasksFromDatabase()
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
                    Tasks.Id AS [ID],
                    Clients.Name AS [Client],
                    Tasks.TaskName AS [Task Name],
                    Tasks.DueDate AS [Due Date],
                    Tasks.Status AS [Status],
                    CAST(CASE WHEN Tasks.Status = 'Completed' THEN 1 ELSE 0 END AS bit) AS [Done],
                    Tasks.AssignedTo AS [Assigned To],
                    Tasks.Priority AS [Priority]
                FROM Tasks
                INNER JOIN Clients ON Tasks.ClientId = Clients.Id
                ORDER BY Tasks.Id DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridTask.DataSource = table;
                    }
                }

                //AddCompletedCheckboxColumn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading tasks:\n" + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SearchTasks()
        {
            string searchText = txtSearchTasks.Text.Trim();

            string connectionString = ConfigurationManager
                .ConnectionStrings["CRMSystemConnection"]
                .ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT 
                        Tasks.Id AS [ID],
                        Clients.Name AS [Client],
                        Tasks.TaskName AS [Task Name],
                        Tasks.DueDate AS [Due Date],
                        Tasks.Status AS [Status],
                        Tasks.AssignedTo AS [Assigned To],
                        Tasks.Priority AS [Priority]
                    FROM Tasks
                    INNER JOIN Clients ON Tasks.ClientId = Clients.Id
                    WHERE
                        Tasks.TaskName LIKE @Search
                        OR Tasks.Status LIKE @Search
                        OR Tasks.AssignedTo LIKE @Search
                        OR Tasks.Priority LIKE @Search
                        OR Clients.Name LIKE @Search
                        ORDER BY Tasks.Id DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Search", "%" + searchText + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridTask.DataSource = table;
                        AddCompletedCheckboxColumn();
                    }
                }
            }
        }

        private void AddCompletedCheckboxColumn()
        {
            isLoadingTasks = true;

            if (!dataGridTask.Columns.Contains("Completed"))
            {
                DataGridViewCheckBoxColumn completedColumn =
                    new DataGridViewCheckBoxColumn();

                completedColumn.Name = "Completed";
                completedColumn.HeaderText = "Done";
                completedColumn.Width = 60;
                completedColumn.TrueValue = true;
                completedColumn.FalseValue = false;

                dataGridTask.Columns.Add(completedColumn);
            }

            foreach (DataGridViewRow row in dataGridTask.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string status = row.Cells["Status"].Value?.ToString().Trim() ?? "";

                row.Cells["Completed"].Value =
                    status.Equals("Completed", StringComparison.OrdinalIgnoreCase);
            }

            isLoadingTasks = false;
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (dataGridTask.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to edit.");
                return;
            }

            DataGridViewRow selectedRow = dataGridTask.SelectedRows[0];

            int taskId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            string clientName = selectedRow.Cells["Client"].Value.ToString();
            string taskName = selectedRow.Cells["Task Name"].Value.ToString();
            DateTime dueDate = Convert.ToDateTime(selectedRow.Cells["Due Date"].Value);
            string status = selectedRow.Cells["Status"].Value.ToString();
            string assignedTo = selectedRow.Cells["Assigned To"].Value?.ToString() ?? "";

            int clientId = GetClientIdByName(clientName);

            AddTaskForm editForm = new AddTaskForm(clientId, taskName, dueDate, status, assignedTo);

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

                        string query = @"UPDATE Tasks
                 SET ClientId=@ClientId,
                     TaskName=@TaskName,
                     DueDate=@DueDate,
                     Status=@Status,
                     AssignedTo=@AssignedTo
                 WHERE Id=@Id";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ClientId", editForm.SelectedClientId);
                            command.Parameters.AddWithValue("@TaskName", editForm.TaskName);
                            command.Parameters.AddWithValue("@DueDate", editForm.DueDate);
                            command.Parameters.AddWithValue("@Status", editForm.Status);
                            command.Parameters.AddWithValue("@AssignedTo", editForm.AssignedTo);
                            command.Parameters.AddWithValue("@Id", taskId);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error updating task:\n" + ex.Message,
                        "Database error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                LoadTasksFromDatabase();
                ActivityLogger.Log(FullName, UserRole, "Task updated");
                MessageBox.Show("Task updated successfully.");
            }
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

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dataGridTask.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            int taskId = Convert.ToInt32(
                dataGridTask.SelectedRows[0].Cells["ID"].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this task?",
                "Delete Task",
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

                    string query = "DELETE FROM Tasks WHERE Id=@Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", taskId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error deleting task:\n" + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            LoadTasksFromDatabase();
            ActivityLogger.Log(FullName, UserRole, "Task deleted");
            MessageBox.Show("Task deleted successfully.");
        }


        private void LoadClientsToFilter()
        {
            cmbTaskClientFilter.Items.Clear();

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
                    cmbTaskClientFilter.Items.Add("All");

                    while (reader.Read())
                    {
                        cmbTaskClientFilter.Items.Add(reader["Name"].ToString());
                    }
                }
            }

            cmbTaskClientFilter.SelectedIndex = 0;
        }

        private void LoadStatusFilter()
        {
            cmbTaskStatusFilter.Items.Clear();

            cmbTaskStatusFilter.Items.Add("All");
            cmbTaskStatusFilter.Items.Add("New");
            cmbTaskStatusFilter.Items.Add("In Progress");
            cmbTaskStatusFilter.Items.Add("Completed");
            cmbTaskStatusFilter.Items.Add("Cancelled");

            cmbTaskStatusFilter.SelectedIndex = 0;
        }
        private void LoadFilteredTasks()
        {
            try
            {
                string selectedStatus = cmbTaskStatusFilter.SelectedItem?.ToString();
                string selectedClient = cmbTaskClientFilter.SelectedItem?.ToString();

                string connectionString = ConfigurationManager
                    .ConnectionStrings["CRMSystemConnection"]
                    .ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT
                    Tasks.Id AS [ID],
                    Clients.Name AS [Client],
                    Tasks.TaskName AS [Task Name],
                    Tasks.DueDate AS [Due Date],
                    Tasks.Status AS [Status],
                    Tasks.AssignedTo AS [Assigned To],
                    Tasks.Priority AS [Priority]
                FROM Tasks
                INNER JOIN Clients ON Tasks.ClientId = Clients.Id
                WHERE 1=1";

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;

                        if (selectedStatus != "All")
                        {
                            query += " AND Tasks.Status = @Status";
                            command.Parameters.AddWithValue("@Status", selectedStatus);
                        }

                        if (selectedClient != "All")
                        {
                            query += " AND Clients.Name = @ClientName";
                            command.Parameters.AddWithValue("@ClientName", selectedClient);
                        }

                        query += " ORDER BY Tasks.Id DESC";

                        command.CommandText = query;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dataGridTask.DataSource = table;
                            AddCompletedCheckboxColumn();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error filtering tasks:\n" + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnResetTaskFilter_Click(object sender, EventArgs e)
        {
            cmbTaskStatusFilter.SelectedIndex = 0;
            cmbTaskClientFilter.SelectedIndex = 0;

            LoadTasksFromDatabase();
        }

        private void btnOverdueTasks_Click(object sender, EventArgs e)
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
                    Tasks.Id AS [ID],
                    Clients.Name AS [Client],
                    Tasks.TaskName AS [Task Name],
                    Tasks.DueDate AS [Due Date],
                    Tasks.Status AS [Status],
                    Tasks.AssignedTo AS [Assigned To],
                    Tasks.Priority AS [Priority]
                FROM Tasks
                INNER JOIN Clients ON Tasks.ClientId = Clients.Id
                WHERE Tasks.DueDate < CAST(GETDATE() AS DATE)
                  AND Tasks.Status <> 'Completed'
                ORDER BY Tasks.DueDate ASC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridTask.DataSource = table;
                        AddCompletedCheckboxColumn();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading overdue tasks:\n" + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnTodayTasks_Click(object sender, EventArgs e)
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
                    Tasks.Id AS [ID],
                    Clients.Name AS [Client],
                    Tasks.TaskName AS [Task Name],
                    Tasks.DueDate AS [Due Date],
                    Tasks.Status AS [Status],
                    Tasks.AssignedTo AS [Assigned To],
                    Tasks.Priority AS [Priority]
                FROM Tasks
                INNER JOIN Clients ON Tasks.ClientId = Clients.Id
                WHERE CAST(Tasks.DueDate AS DATE) = CAST(GETDATE() AS DATE)
                ORDER BY Tasks.Id DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridTask.DataSource = table;
                        AddCompletedCheckboxColumn();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading today's tasks:\n" + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnApplyTaskFilter_Click(object sender, EventArgs e)
        {
            LoadFilteredTasks();
        }

        private void dataGridTask_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridTask.IsCurrentCellDirty)
            {
                dataGridTask.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridTask_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isLoadingTasks)
                return;

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridTask.Columns[e.ColumnIndex].Name != "Done")
                return;

            object idValue = dataGridTask.Rows[e.RowIndex].Cells["ID"].Value;

            if (idValue == null || idValue == DBNull.Value)
                return;

            int taskId = Convert.ToInt32(idValue);

            bool isChecked = Convert.ToBoolean(
                dataGridTask.Rows[e.RowIndex].Cells["Done"].Value
            );

            string newStatus = isChecked ? "Completed" : "New";

            try
            {
                string connectionString = ConfigurationManager
                    .ConnectionStrings["CRMSystemConnection"]
                    .ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                UPDATE Tasks
                SET Status = @Status
                WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", newStatus);
                        command.Parameters.AddWithValue("@Id", taskId);

                        command.ExecuteNonQuery();
                    }
                }

                dataGridTask.Rows[e.RowIndex].Cells["Status"].Value = newStatus;

                ActivityLogger.Log(
                    FullName,
                    UserRole,
                    isChecked ? "Task completed" : "Task reopened"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating task status:\n" + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnSearchTasks_Click(object sender, EventArgs e)
        {
            SearchTasks();

        }

        private void btnClearSearchTasks_Click(object sender, EventArgs e)
        {
            txtSearchTasks.Clear();
            LoadTasksFromDatabase();
        }

        private void btnExportTasks_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "Tasks.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Tasks");

                    for (int i = 0; i < dataGridTask.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridTask.Columns[i].HeaderText;
                        worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                    }

                    for (int i = 0; i < dataGridTask.Rows.Count; i++)
                    {
                        if (!dataGridTask.Rows[i].IsNewRow)
                        {
                            for (int j = 0; j < dataGridTask.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value =
                                    dataGridTask.Rows[i].Cells[j].Value?.ToString();
                            }
                        }
                    }

                    worksheet.Columns().AdjustToContents();

                    workbook.SaveAs(saveFileDialog.FileName);
                }

                MessageBox.Show("Tasks exported successfully.");
            }

        }
        private void dataGridTask_RowPrePaint(
            object sender,
            DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (!dataGridTask.Columns.Contains("Priority"))
                return;

            string priority = dataGridTask.Rows[e.RowIndex]
                .Cells["Priority"]
                .Value?
                .ToString();

            if (priority == "High")
            {
                dataGridTask.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    Color.LightCoral;
            }
            else if (priority == "Medium")
            {
                dataGridTask.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    Color.Khaki;
            }
            else if (priority == "Low")
            {
                dataGridTask.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    Color.LightGreen;
            }
            else
            {
                dataGridTask.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    Color.White;
            }
        }
    }

    }

