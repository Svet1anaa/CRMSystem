namespace CRMSystem
{
    partial class AddTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateDueDate = new System.Windows.Forms.DateTimePicker();
            this.blDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAssignedTo = new System.Windows.Forms.ComboBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbClients
            // 
            this.cmbClients.BackColor = System.Drawing.Color.Silver;
            this.cmbClients.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(458, 38);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(186, 29);
            this.cmbClients.TabIndex = 0;
            // 
            // txtTaskName
            // 
            this.txtTaskName.BackColor = System.Drawing.Color.Silver;
            this.txtTaskName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTaskName.Location = new System.Drawing.Point(458, 131);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(186, 28);
            this.txtTaskName.TabIndex = 1;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Silver;
            this.cmbStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(458, 80);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(186, 29);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(210, 41);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(129, 21);
            this.lblClient.TabIndex = 3;
            this.lblClient.Text = "Choose client:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(210, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(134, 21);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Choose status:";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTask.ForeColor = System.Drawing.Color.White;
            this.lblTask.Location = new System.Drawing.Point(210, 138);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(92, 21);
            this.lblTask.TabIndex = 5;
            this.lblTask.Text = "Add task:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(214, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 44);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(464, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 44);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateDueDate
            // 
            this.dateDueDate.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dateDueDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDueDate.Location = new System.Drawing.Point(458, 230);
            this.dateDueDate.Name = "dateDueDate";
            this.dateDueDate.Size = new System.Drawing.Size(186, 28);
            this.dateDueDate.TabIndex = 8;
            // 
            // blDate
            // 
            this.blDate.AutoSize = true;
            this.blDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blDate.ForeColor = System.Drawing.Color.White;
            this.blDate.Location = new System.Drawing.Point(210, 237);
            this.blDate.Name = "blDate";
            this.blDate.Size = new System.Drawing.Size(136, 21);
            this.blDate.TabIndex = 9;
            this.blDate.Text = "Enter deadline:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Assigned To:";
            // 
            // cmbAssignedTo
            // 
            this.cmbAssignedTo.BackColor = System.Drawing.Color.Silver;
            this.cmbAssignedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignedTo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAssignedTo.FormattingEnabled = true;
            this.cmbAssignedTo.Location = new System.Drawing.Point(458, 180);
            this.cmbAssignedTo.Name = "cmbAssignedTo";
            this.cmbAssignedTo.Size = new System.Drawing.Size(186, 29);
            this.cmbAssignedTo.TabIndex = 11;
            // 
            // cmbPriority
            // 
            this.cmbPriority.BackColor = System.Drawing.Color.Silver;
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Low",
            "High",
            "Medium"});
            this.cmbPriority.Location = new System.Drawing.Point(458, 281);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(186, 29);
            this.cmbPriority.TabIndex = 12;
            this.cmbPriority.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriority.ForeColor = System.Drawing.Color.White;
            this.lblPriority.Location = new System.Drawing.Point(210, 284);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(138, 21);
            this.lblPriority.TabIndex = 13;
            this.lblPriority.Text = "Choose priority:";
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.cmbAssignedTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blDate);
            this.Controls.Add(this.dateDueDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.cmbClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateDueDate;
        private System.Windows.Forms.Label blDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAssignedTo;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblPriority;
    }
}