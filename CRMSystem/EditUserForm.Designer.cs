namespace CRMSystem
{
    partial class EditUserForm
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Silver;
            this.txtFullName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFullName.Location = new System.Drawing.Point(424, 82);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(186, 28);
            this.txtFullName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Silver;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(424, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 28);
            this.txtEmail.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(209, 89);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(136, 21);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Enter full name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(209, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 21);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Enter email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.Silver;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Manager",
            "Admin"});
            this.cmbRole.Location = new System.Drawing.Point(424, 246);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(186, 29);
            this.cmbRole.TabIndex = 4;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(209, 254);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(114, 21);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Choose role:";
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSaveUser.FlatAppearance.BorderSize = 0;
            this.btnSaveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Location = new System.Drawing.Point(213, 360);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(180, 44);
            this.btnSaveUser.TabIndex = 6;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelUser.FlatAppearance.BorderSize = 0;
            this.btnCancelUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelUser.ForeColor = System.Drawing.Color.White;
            this.btnCancelUser.Location = new System.Drawing.Point(430, 360);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(180, 44);
            this.btnCancelUser.TabIndex = 7;
            this.btnCancelUser.Text = "Cancel";
            this.btnCancelUser.UseVisualStyleBackColor = false;
            this.btnCancelUser.Click += new System.EventHandler(this.btnCancelUser_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelUser);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnCancelUser;
    }
}