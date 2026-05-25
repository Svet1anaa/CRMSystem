namespace CRMSystem
{
    partial class TaskControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTask = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbTaskClientFilter = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTaskStatusFilter = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchTasks = new System.Windows.Forms.TextBox();
            this.btnExportTasks = new System.Windows.Forms.Button();
            this.btnOverdueTasks = new System.Windows.Forms.Button();
            this.btnClearSearchTasks = new System.Windows.Forms.Button();
            this.btnResetTaskFilter = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnSearchTasks = new System.Windows.Forms.Button();
            this.btnApplyTaskFilter = new System.Windows.Forms.Button();
            this.btnTodayTasks = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.dataGridTask = new System.Windows.Forms.DataGridView();
            this.panelTask.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTask)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask
            // 
            this.panelTask.BackColor = System.Drawing.Color.Indigo;
            this.panelTask.Controls.Add(this.panel3);
            this.panelTask.Controls.Add(this.panel2);
            this.panelTask.Controls.Add(this.panel1);
            this.panelTask.Controls.Add(this.btnExportTasks);
            this.panelTask.Controls.Add(this.btnOverdueTasks);
            this.panelTask.Controls.Add(this.btnClearSearchTasks);
            this.panelTask.Controls.Add(this.btnResetTaskFilter);
            this.panelTask.Controls.Add(this.btnDeleteTask);
            this.panelTask.Controls.Add(this.btnSearchTasks);
            this.panelTask.Controls.Add(this.btnApplyTaskFilter);
            this.panelTask.Controls.Add(this.btnTodayTasks);
            this.panelTask.Controls.Add(this.btnEditTask);
            this.panelTask.Controls.Add(this.btnAddTask);
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask.Location = new System.Drawing.Point(0, 0);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(673, 140);
            this.panelTask.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.cmbTaskClientFilter);
            this.panel3.Location = new System.Drawing.Point(349, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 44);
            this.panel3.TabIndex = 13;
            // 
            // cmbTaskClientFilter
            // 
            this.cmbTaskClientFilter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTaskClientFilter.FormattingEnabled = true;
            this.cmbTaskClientFilter.Location = new System.Drawing.Point(5, 8);
            this.cmbTaskClientFilter.Name = "cmbTaskClientFilter";
            this.cmbTaskClientFilter.Size = new System.Drawing.Size(132, 29);
            this.cmbTaskClientFilter.TabIndex = 4;
            this.cmbTaskClientFilter.Text = "Client";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.cmbTaskStatusFilter);
            this.panel2.Location = new System.Drawing.Point(203, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 44);
            this.panel2.TabIndex = 12;
            // 
            // cmbTaskStatusFilter
            // 
            this.cmbTaskStatusFilter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTaskStatusFilter.FormattingEnabled = true;
            this.cmbTaskStatusFilter.Location = new System.Drawing.Point(3, 8);
            this.cmbTaskStatusFilter.Name = "cmbTaskStatusFilter";
            this.cmbTaskStatusFilter.Size = new System.Drawing.Size(134, 29);
            this.cmbTaskStatusFilter.TabIndex = 3;
            this.cmbTaskStatusFilter.Text = "Task Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.txtSearchTasks);
            this.panel1.Location = new System.Drawing.Point(311, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 44);
            this.panel1.TabIndex = 11;
            // 
            // txtSearchTasks
            // 
            this.txtSearchTasks.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchTasks.Location = new System.Drawing.Point(3, 10);
            this.txtSearchTasks.Name = "txtSearchTasks";
            this.txtSearchTasks.Size = new System.Drawing.Size(161, 28);
            this.txtSearchTasks.TabIndex = 9;
            this.txtSearchTasks.Text = "Search task...";
            // 
            // btnExportTasks
            // 
            this.btnExportTasks.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExportTasks.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportTasks.ForeColor = System.Drawing.Color.White;
            this.btnExportTasks.Location = new System.Drawing.Point(228, 24);
            this.btnExportTasks.Name = "btnExportTasks";
            this.btnExportTasks.Size = new System.Drawing.Size(69, 44);
            this.btnExportTasks.TabIndex = 10;
            this.btnExportTasks.Text = "Export";
            this.btnExportTasks.UseVisualStyleBackColor = false;
            this.btnExportTasks.Click += new System.EventHandler(this.btnExportTasks_Click);
            // 
            // btnOverdueTasks
            // 
            this.btnOverdueTasks.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOverdueTasks.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOverdueTasks.ForeColor = System.Drawing.Color.White;
            this.btnOverdueTasks.Location = new System.Drawing.Point(99, 81);
            this.btnOverdueTasks.Name = "btnOverdueTasks";
            this.btnOverdueTasks.Size = new System.Drawing.Size(98, 44);
            this.btnOverdueTasks.TabIndex = 7;
            this.btnOverdueTasks.Text = "Overdue";
            this.btnOverdueTasks.UseVisualStyleBackColor = false;
            this.btnOverdueTasks.Click += new System.EventHandler(this.btnOverdueTasks_Click);
            // 
            // btnClearSearchTasks
            // 
            this.btnClearSearchTasks.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClearSearchTasks.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearSearchTasks.ForeColor = System.Drawing.Color.White;
            this.btnClearSearchTasks.Location = new System.Drawing.Point(577, 24);
            this.btnClearSearchTasks.Name = "btnClearSearchTasks";
            this.btnClearSearchTasks.Size = new System.Drawing.Size(78, 44);
            this.btnClearSearchTasks.TabIndex = 3;
            this.btnClearSearchTasks.Text = "Clear";
            this.btnClearSearchTasks.UseVisualStyleBackColor = false;
            this.btnClearSearchTasks.Click += new System.EventHandler(this.btnClearSearchTasks_Click);
            // 
            // btnResetTaskFilter
            // 
            this.btnResetTaskFilter.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnResetTaskFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetTaskFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetTaskFilter.Location = new System.Drawing.Point(577, 81);
            this.btnResetTaskFilter.Name = "btnResetTaskFilter";
            this.btnResetTaskFilter.Size = new System.Drawing.Size(78, 44);
            this.btnResetTaskFilter.TabIndex = 6;
            this.btnResetTaskFilter.Text = "Reset ";
            this.btnResetTaskFilter.UseVisualStyleBackColor = false;
            this.btnResetTaskFilter.Click += new System.EventHandler(this.btnResetTaskFilter_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteTask.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTask.Location = new System.Drawing.Point(152, 24);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(70, 44);
            this.btnDeleteTask.TabIndex = 2;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnSearchTasks
            // 
            this.btnSearchTasks.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearchTasks.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchTasks.ForeColor = System.Drawing.Color.White;
            this.btnSearchTasks.Location = new System.Drawing.Point(494, 24);
            this.btnSearchTasks.Name = "btnSearchTasks";
            this.btnSearchTasks.Size = new System.Drawing.Size(77, 44);
            this.btnSearchTasks.TabIndex = 2;
            this.btnSearchTasks.Text = "Search";
            this.btnSearchTasks.UseVisualStyleBackColor = false;
            this.btnSearchTasks.Click += new System.EventHandler(this.btnSearchTasks_Click);
            // 
            // btnApplyTaskFilter
            // 
            this.btnApplyTaskFilter.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnApplyTaskFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyTaskFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyTaskFilter.Location = new System.Drawing.Point(494, 81);
            this.btnApplyTaskFilter.Name = "btnApplyTaskFilter";
            this.btnApplyTaskFilter.Size = new System.Drawing.Size(72, 44);
            this.btnApplyTaskFilter.TabIndex = 5;
            this.btnApplyTaskFilter.Text = "Apply ";
            this.btnApplyTaskFilter.UseVisualStyleBackColor = false;
            this.btnApplyTaskFilter.Click += new System.EventHandler(this.btnApplyTaskFilter_Click);
            // 
            // btnTodayTasks
            // 
            this.btnTodayTasks.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTodayTasks.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTodayTasks.ForeColor = System.Drawing.Color.White;
            this.btnTodayTasks.Location = new System.Drawing.Point(16, 81);
            this.btnTodayTasks.Name = "btnTodayTasks";
            this.btnTodayTasks.Size = new System.Drawing.Size(77, 44);
            this.btnTodayTasks.TabIndex = 8;
            this.btnTodayTasks.Text = "Today ";
            this.btnTodayTasks.UseVisualStyleBackColor = false;
            this.btnTodayTasks.Click += new System.EventHandler(this.btnTodayTasks_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditTask.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTask.ForeColor = System.Drawing.Color.White;
            this.btnEditTask.Location = new System.Drawing.Point(83, 24);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(63, 44);
            this.btnEditTask.TabIndex = 1;
            this.btnEditTask.Text = "Edit";
            this.btnEditTask.UseVisualStyleBackColor = false;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddTask.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(16, 24);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(61, 44);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // dataGridTask
            // 
            this.dataGridTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTask.GridColor = System.Drawing.Color.Silver;
            this.dataGridTask.Location = new System.Drawing.Point(0, 140);
            this.dataGridTask.Name = "dataGridTask";
            this.dataGridTask.RowHeadersWidth = 51;
            this.dataGridTask.RowTemplate.Height = 24;
            this.dataGridTask.Size = new System.Drawing.Size(673, 340);
            this.dataGridTask.TabIndex = 1;
            this.dataGridTask.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridTask_RowPrePaint);
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridTask);
            this.Controls.Add(this.panelTask);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(673, 480);
            this.panelTask.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.DataGridView dataGridTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.ComboBox cmbTaskStatusFilter;
        private System.Windows.Forms.ComboBox cmbTaskClientFilter;
        private System.Windows.Forms.Button btnApplyTaskFilter;
        private System.Windows.Forms.Button btnResetTaskFilter;
        private System.Windows.Forms.Button btnOverdueTasks;
        private System.Windows.Forms.Button btnTodayTasks;
        private System.Windows.Forms.TextBox txtSearchTasks;
        private System.Windows.Forms.Button btnSearchTasks;
        private System.Windows.Forms.Button btnClearSearchTasks;
        private System.Windows.Forms.Button btnExportTasks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
