namespace CRMSystem
{
    partial class ClientsControl
    {
        
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.panelClientsTop = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnExportClients = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.panelClientsTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridClients
            // 
            this.dataGridClients.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridClients.Location = new System.Drawing.Point(0, 100);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.RowHeadersWidth = 51;
            this.dataGridClients.RowTemplate.Height = 24;
            this.dataGridClients.Size = new System.Drawing.Size(673, 380);
            this.dataGridClients.TabIndex = 1;
            // 
            // panelClientsTop
            // 
            this.panelClientsTop.BackColor = System.Drawing.Color.Indigo;
            this.panelClientsTop.Controls.Add(this.btnReset);
            this.panelClientsTop.Controls.Add(this.panel2);
            this.panelClientsTop.Controls.Add(this.btnSearchClient);
            this.panelClientsTop.Controls.Add(this.btnAddClient);
            this.panelClientsTop.Controls.Add(this.btnExportClients);
            this.panelClientsTop.Controls.Add(this.btnEditClient);
            this.panelClientsTop.Controls.Add(this.btnDeleteClient);
            this.panelClientsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientsTop.Location = new System.Drawing.Point(0, 0);
            this.panelClientsTop.Name = "panelClientsTop";
            this.panelClientsTop.Size = new System.Drawing.Size(673, 100);
            this.panelClientsTop.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumPurple;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(577, 33);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 44);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtSearchClient);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panel2.Location = new System.Drawing.Point(338, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 44);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 5);
            this.panel3.TabIndex = 9;
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchClient.Location = new System.Drawing.Point(3, 8);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(143, 28);
            this.txtSearchClient.TabIndex = 5;
            this.txtSearchClient.Text = "Search client...";
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearchClient.FlatAppearance.BorderSize = 0;
            this.btnSearchClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchClient.ForeColor = System.Drawing.Color.White;
            this.btnSearchClient.Location = new System.Drawing.Point(493, 33);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(78, 44);
            this.btnSearchClient.TabIndex = 4;
            this.btnSearchClient.Text = "Search";
            this.btnSearchClient.UseVisualStyleBackColor = false;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(13, 33);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(66, 44);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnExportClients
            // 
            this.btnExportClients.BackColor = System.Drawing.Color.MediumPurple;
            this.btnExportClients.FlatAppearance.BorderSize = 0;
            this.btnExportClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExportClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportClients.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportClients.ForeColor = System.Drawing.Color.White;
            this.btnExportClients.Location = new System.Drawing.Point(253, 33);
            this.btnExportClients.Name = "btnExportClients";
            this.btnExportClients.Size = new System.Drawing.Size(79, 44);
            this.btnExportClients.TabIndex = 7;
            this.btnExportClients.Text = "Export ";
            this.btnExportClients.UseVisualStyleBackColor = false;
            this.btnExportClients.Click += new System.EventHandler(this.btnExportClients_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEditClient.FlatAppearance.BorderSize = 0;
            this.btnEditClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.Location = new System.Drawing.Point(90, 33);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(66, 44);
            this.btnEditClient.TabIndex = 2;
            this.btnEditClient.Text = "Edit";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDeleteClient.FlatAppearance.BorderSize = 0;
            this.btnDeleteClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Location = new System.Drawing.Point(162, 33);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(85, 44);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Delete";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ClientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridClients);
            this.Controls.Add(this.panelClientsTop);
            this.Name = "ClientsControl";
            this.Size = new System.Drawing.Size(673, 480);
            this.Load += new System.EventHandler(this.ClientsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.panelClientsTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.Panel panelClientsTop;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExportClients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
