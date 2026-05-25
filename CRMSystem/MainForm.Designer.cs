namespace CRMSystem
{
    partial class MainForm
    {

        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnDeals = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnActivityLog = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SlateGray;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.lblMenu);
            this.panelMenu.Controls.Add(this.btnTasks);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.btnDeals);
            this.panelMenu.Controls.Add(this.btnClients);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 553);
            this.panelMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "System";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenu.Location = new System.Drawing.Point(15, 43);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(88, 37);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "CRM";
            // 
            // btnTasks
            // 
            this.btnTasks.BackColor = System.Drawing.Color.Transparent;
            this.btnTasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTasks.ForeColor = System.Drawing.Color.White;
            this.btnTasks.Location = new System.Drawing.Point(22, 401);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(160, 40);
            this.btnTasks.TabIndex = 3;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.UseVisualStyleBackColor = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.SlateGray;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboard.Location = new System.Drawing.Point(22, 152);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(160, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnDeals
            // 
            this.btnDeals.BackColor = System.Drawing.Color.Transparent;
            this.btnDeals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeals.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeals.ForeColor = System.Drawing.Color.White;
            this.btnDeals.Location = new System.Drawing.Point(22, 314);
            this.btnDeals.Name = "btnDeals";
            this.btnDeals.Size = new System.Drawing.Size(160, 40);
            this.btnDeals.TabIndex = 2;
            this.btnDeals.Text = "Deals";
            this.btnDeals.UseVisualStyleBackColor = false;
            this.btnDeals.Click += new System.EventHandler(this.btnDeals_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.Location = new System.Drawing.Point(22, 232);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(160, 40);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SlateBlue;
            this.panelTop.Controls.Add(this.lblNotifications);
            this.panelTop.Controls.Add(this.btnUsers);
            this.panelTop.Controls.Add(this.btnActivityLog);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Controls.Add(this.lblCurrentUser);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(200, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(682, 115);
            this.panelTop.TabIndex = 1;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Location = new System.Drawing.Point(161, 23);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(0, 16);
            this.lblNotifications.TabIndex = 6;
            this.lblNotifications.Visible = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.DarkViolet;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(342, 39);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(85, 41);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnActivityLog
            // 
            this.btnActivityLog.BackColor = System.Drawing.Color.DarkViolet;
            this.btnActivityLog.FlatAppearance.BorderSize = 0;
            this.btnActivityLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnActivityLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivityLog.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnActivityLog.ForeColor = System.Drawing.Color.White;
            this.btnActivityLog.Location = new System.Drawing.Point(433, 39);
            this.btnActivityLog.Name = "btnActivityLog";
            this.btnActivityLog.Size = new System.Drawing.Size(128, 41);
            this.btnActivityLog.TabIndex = 4;
            this.btnActivityLog.Text = "Activity Log";
            this.btnActivityLog.UseVisualStyleBackColor = false;
            this.btnActivityLog.Click += new System.EventHandler(this.btnActivityLog_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkViolet;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(567, 39);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 41);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrentUser.Location = new System.Drawing.Point(16, 39);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(152, 36);
            this.lblCurrentUser.TabIndex = 2;
            this.lblCurrentUser.Text = "Welcome back, ";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Silver;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 115);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(682, 438);
            this.panelContent.TabIndex = 2;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnDeals;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnActivityLog;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label label1;
    }
}