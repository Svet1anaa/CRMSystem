namespace CRMSystem
{
    partial class DealsControl
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbClientFilter = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchDeals = new System.Windows.Forms.TextBox();
            this.btnClearSearchDeals = new System.Windows.Forms.Button();
            this.btnExportDeals = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnSearchDeals = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnDeleteDeal = new System.Windows.Forms.Button();
            this.btnAddDeal = new System.Windows.Forms.Button();
            this.btnEditDeal = new System.Windows.Forms.Button();
            this.dataGridDeals = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeals)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Indigo;
            this.panelTop.Controls.Add(this.panel3);
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.btnClearSearchDeals);
            this.panelTop.Controls.Add(this.btnExportDeals);
            this.panelTop.Controls.Add(this.btnResetFilter);
            this.panelTop.Controls.Add(this.btnSearchDeals);
            this.panelTop.Controls.Add(this.btnApplyFilter);
            this.panelTop.Controls.Add(this.btnDeleteDeal);
            this.panelTop.Controls.Add(this.btnAddDeal);
            this.panelTop.Controls.Add(this.btnEditDeal);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(673, 145);
            this.panelTop.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.cmbStatusFilter);
            this.panel3.Location = new System.Drawing.Point(190, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 44);
            this.panel3.TabIndex = 10;
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(0, 12);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(154, 28);
            this.cmbStatusFilter.TabIndex = 3;
            this.cmbStatusFilter.Text = "Status";
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.cmbClientFilter);
            this.panel2.Location = new System.Drawing.Point(21, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 44);
            this.panel2.TabIndex = 9;
            // 
            // cmbClientFilter
            // 
            this.cmbClientFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbClientFilter.FormattingEnabled = true;
            this.cmbClientFilter.Location = new System.Drawing.Point(0, 12);
            this.cmbClientFilter.Name = "cmbClientFilter";
            this.cmbClientFilter.Size = new System.Drawing.Size(148, 28);
            this.cmbClientFilter.TabIndex = 2;
            this.cmbClientFilter.Text = "Client";
            this.cmbClientFilter.SelectedIndexChanged += new System.EventHandler(this.cmbClientFilter_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.txtSearchDeals);
            this.panel1.Location = new System.Drawing.Point(282, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 44);
            this.panel1.TabIndex = 8;
            // 
            // txtSearchDeals
            // 
            this.txtSearchDeals.BackColor = System.Drawing.Color.White;
            this.txtSearchDeals.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchDeals.Location = new System.Drawing.Point(3, 11);
            this.txtSearchDeals.Name = "txtSearchDeals";
            this.txtSearchDeals.Size = new System.Drawing.Size(187, 28);
            this.txtSearchDeals.TabIndex = 4;
            this.txtSearchDeals.Text = "Search deal...";
            // 
            // btnClearSearchDeals
            // 
            this.btnClearSearchDeals.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClearSearchDeals.FlatAppearance.BorderSize = 0;
            this.btnClearSearchDeals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClearSearchDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearchDeals.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearSearchDeals.ForeColor = System.Drawing.Color.White;
            this.btnClearSearchDeals.Location = new System.Drawing.Point(577, 21);
            this.btnClearSearchDeals.Name = "btnClearSearchDeals";
            this.btnClearSearchDeals.Size = new System.Drawing.Size(77, 44);
            this.btnClearSearchDeals.TabIndex = 6;
            this.btnClearSearchDeals.Text = "Clear";
            this.btnClearSearchDeals.UseVisualStyleBackColor = false;
            this.btnClearSearchDeals.Click += new System.EventHandler(this.btnClearSearchDeals_Click);
            // 
            // btnExportDeals
            // 
            this.btnExportDeals.BackColor = System.Drawing.Color.MediumPurple;
            this.btnExportDeals.FlatAppearance.BorderSize = 0;
            this.btnExportDeals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExportDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportDeals.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportDeals.ForeColor = System.Drawing.Color.White;
            this.btnExportDeals.Location = new System.Drawing.Point(562, 88);
            this.btnExportDeals.Name = "btnExportDeals";
            this.btnExportDeals.Size = new System.Drawing.Size(92, 44);
            this.btnExportDeals.TabIndex = 7;
            this.btnExportDeals.Text = "Export ";
            this.btnExportDeals.UseVisualStyleBackColor = false;
            this.btnExportDeals.Click += new System.EventHandler(this.btnExportDeals_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnResetFilter.FlatAppearance.BorderSize = 0;
            this.btnResetFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.Location = new System.Drawing.Point(447, 88);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(109, 43);
            this.btnResetFilter.TabIndex = 3;
            this.btnResetFilter.Text = "Reset Filter";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // btnSearchDeals
            // 
            this.btnSearchDeals.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearchDeals.FlatAppearance.BorderSize = 0;
            this.btnSearchDeals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearchDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDeals.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchDeals.ForeColor = System.Drawing.Color.White;
            this.btnSearchDeals.Location = new System.Drawing.Point(494, 21);
            this.btnSearchDeals.Name = "btnSearchDeals";
            this.btnSearchDeals.Size = new System.Drawing.Size(77, 44);
            this.btnSearchDeals.TabIndex = 2;
            this.btnSearchDeals.Text = "Search";
            this.btnSearchDeals.UseVisualStyleBackColor = false;
            this.btnSearchDeals.Click += new System.EventHandler(this.btnSearchDeals_Click);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Location = new System.Drawing.Point(350, 88);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(91, 44);
            this.btnApplyFilter.TabIndex = 2;
            this.btnApplyFilter.Text = "Apply ";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // btnDeleteDeal
            // 
            this.btnDeleteDeal.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDeleteDeal.FlatAppearance.BorderSize = 0;
            this.btnDeleteDeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDeal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteDeal.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDeal.Location = new System.Drawing.Point(190, 22);
            this.btnDeleteDeal.Name = "btnDeleteDeal";
            this.btnDeleteDeal.Size = new System.Drawing.Size(75, 44);
            this.btnDeleteDeal.TabIndex = 2;
            this.btnDeleteDeal.Text = "Delete";
            this.btnDeleteDeal.UseVisualStyleBackColor = false;
            this.btnDeleteDeal.Click += new System.EventHandler(this.btnDeleteDeal_Click);
            // 
            // btnAddDeal
            // 
            this.btnAddDeal.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddDeal.FlatAppearance.BorderSize = 0;
            this.btnAddDeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDeal.ForeColor = System.Drawing.Color.White;
            this.btnAddDeal.Location = new System.Drawing.Point(21, 21);
            this.btnAddDeal.Name = "btnAddDeal";
            this.btnAddDeal.Size = new System.Drawing.Size(66, 44);
            this.btnAddDeal.TabIndex = 1;
            this.btnAddDeal.Text = "Add";
            this.btnAddDeal.UseVisualStyleBackColor = false;
            this.btnAddDeal.Click += new System.EventHandler(this.btnAddDeal_Click);
            // 
            // btnEditDeal
            // 
            this.btnEditDeal.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEditDeal.FlatAppearance.BorderSize = 0;
            this.btnEditDeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDeal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditDeal.ForeColor = System.Drawing.Color.White;
            this.btnEditDeal.Location = new System.Drawing.Point(106, 21);
            this.btnEditDeal.Name = "btnEditDeal";
            this.btnEditDeal.Size = new System.Drawing.Size(66, 44);
            this.btnEditDeal.TabIndex = 0;
            this.btnEditDeal.Text = "Edit";
            this.btnEditDeal.UseVisualStyleBackColor = false;
            this.btnEditDeal.Click += new System.EventHandler(this.btnEditDeal_Click);
            // 
            // dataGridDeals
            // 
            this.dataGridDeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDeals.GridColor = System.Drawing.Color.Violet;
            this.dataGridDeals.Location = new System.Drawing.Point(0, 145);
            this.dataGridDeals.Name = "dataGridDeals";
            this.dataGridDeals.ReadOnly = true;
            this.dataGridDeals.RowHeadersWidth = 51;
            this.dataGridDeals.RowTemplate.Height = 24;
            this.dataGridDeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDeals.Size = new System.Drawing.Size(673, 335);
            this.dataGridDeals.TabIndex = 1;
            this.dataGridDeals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDeals_CellContentClick);
            // 
            // DealsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridDeals);
            this.Controls.Add(this.panelTop);
            this.Name = "DealsControl";
            this.Size = new System.Drawing.Size(673, 480);
            this.Load += new System.EventHandler(this.DealsControl_Load);
            this.panelTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView dataGridDeals;
        private System.Windows.Forms.Button btnDeleteDeal;
        private System.Windows.Forms.Button btnAddDeal;
        private System.Windows.Forms.Button btnEditDeal;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.ComboBox cmbClientFilter;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.TextBox txtSearchDeals;
        private System.Windows.Forms.Button btnSearchDeals;
        private System.Windows.Forms.Button btnClearSearchDeals;
        private System.Windows.Forms.Button btnExportDeals;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}
