namespace CRMSystem
{
    partial class UsersControl
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
            this.panelUserControl = new System.Windows.Forms.Panel();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.panelUserControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUserControl
            // 
            this.panelUserControl.BackColor = System.Drawing.Color.Indigo;
            this.panelUserControl.Controls.Add(this.btnRefreshUsers);
            this.panelUserControl.Controls.Add(this.btnDeleteUser);
            this.panelUserControl.Controls.Add(this.btnEditUser);
            this.panelUserControl.Controls.Add(this.btnAddUser);
            this.panelUserControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserControl.Location = new System.Drawing.Point(0, 0);
            this.panelUserControl.Name = "panelUserControl";
            this.panelUserControl.Size = new System.Drawing.Size(673, 90);
            this.panelUserControl.TabIndex = 0;
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.BackColor = System.Drawing.Color.DarkViolet;
            this.btnRefreshUsers.FlatAppearance.BorderSize = 0;
            this.btnRefreshUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUsers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshUsers.ForeColor = System.Drawing.Color.White;
            this.btnRefreshUsers.Location = new System.Drawing.Point(512, 24);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(117, 44);
            this.btnRefreshUsers.TabIndex = 3;
            this.btnRefreshUsers.Text = "Refresh";
            this.btnRefreshUsers.UseVisualStyleBackColor = false;
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.DarkViolet;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(354, 24);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(117, 44);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.DarkViolet;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.Location = new System.Drawing.Point(192, 24);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(117, 44);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit ";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(35, 24);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(117, 44);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add ";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsers.Location = new System.Drawing.Point(0, 90);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RowHeadersWidth = 51;
            this.dataGridUsers.RowTemplate.Height = 24;
            this.dataGridUsers.Size = new System.Drawing.Size(673, 390);
            this.dataGridUsers.TabIndex = 1;
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridUsers);
            this.Controls.Add(this.panelUserControl);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(673, 480);
            this.panelUserControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserControl;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnRefreshUsers;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}
