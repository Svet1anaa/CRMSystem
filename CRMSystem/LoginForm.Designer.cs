namespace CRMSystem
{
    partial class LoginForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.email_lbl = new System.Windows.Forms.Label();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCompany = new System.Windows.Forms.Label();
            this.companyLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_lbl.ForeColor = System.Drawing.Color.Black;
            this.email_lbl.Location = new System.Drawing.Point(62, 154);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(63, 21);
            this.email_lbl.TabIndex = 0;
            this.email_lbl.Text = "E-mail:";
            this.email_lbl.Click += new System.EventHandler(this.email_lbl_Click);
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_lbl.ForeColor = System.Drawing.Color.Black;
            this.pass_lbl.Location = new System.Drawing.Point(59, 255);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(93, 21);
            this.pass_lbl.TabIndex = 1;
            this.pass_lbl.Text = "Password:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxEmail.Location = new System.Drawing.Point(3, 8);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(249, 23);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(3, 8);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(249, 23);
            this.textBoxPass.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_btn.ForeColor = System.Drawing.Color.Transparent;
            this.login_btn.Location = new System.Drawing.Point(63, 375);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(300, 46);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblCompany);
            this.panel1.Controls.Add(this.companyLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.email_lbl);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.pass_lbl);
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 600);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.textBoxPass);
            this.panel4.Location = new System.Drawing.Point(63, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 40);
            this.panel4.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(258, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGreen;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 5);
            this.panel5.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Location = new System.Drawing.Point(63, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 40);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 5);
            this.panel3.TabIndex = 9;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompany.Location = new System.Drawing.Point(167, 44);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(187, 20);
            this.lblCompany.TabIndex = 7;
            this.lblCompany.Text = "Place for your Company";
            // 
            // companyLogo
            // 
            this.companyLogo.Image = ((System.Drawing.Image)(resources.GetObject("companyLogo.Image")));
            this.companyLogo.Location = new System.Drawing.Point(54, 23);
            this.companyLogo.Name = "companyLogo";
            this.companyLogo.Size = new System.Drawing.Size(107, 55);
            this.companyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companyLogo.TabIndex = 6;
            this.companyLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome back!";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox companyLogo;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

