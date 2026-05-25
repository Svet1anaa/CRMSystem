namespace CRMSystem
{
    partial class DashboardControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTotalClients = new System.Windows.Forms.Label();
            this.lblTotalDeals = new System.Windows.Forms.Label();
            this.lblTotalTasks = new System.Windows.Forms.Label();
            this.lblCompletedDeals = new System.Windows.Forms.Label();
            this.lblActiveDeals = new System.Windows.Forms.Label();
            this.lblOverdueTasks = new System.Windows.Forms.Label();
            this.lblTasksDueToday = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblAverageAmount = new System.Windows.Forms.Label();
            this.chartTasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDeals = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableDashboard = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chartTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDeals)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalClients
            // 
            this.lblTotalClients.AutoSize = true;
            this.lblTotalClients.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalClients.Location = new System.Drawing.Point(27, 176);
            this.lblTotalClients.Name = "lblTotalClients";
            this.lblTotalClients.Size = new System.Drawing.Size(119, 21);
            this.lblTotalClients.TabIndex = 0;
            this.lblTotalClients.Text = "Total Clients:";
            // 
            // lblTotalDeals
            // 
            this.lblTotalDeals.AutoSize = true;
            this.lblTotalDeals.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalDeals.Location = new System.Drawing.Point(27, 100);
            this.lblTotalDeals.Name = "lblTotalDeals";
            this.lblTotalDeals.Size = new System.Drawing.Size(108, 21);
            this.lblTotalDeals.TabIndex = 1;
            this.lblTotalDeals.Text = "Total Deals:";
            // 
            // lblTotalTasks
            // 
            this.lblTotalTasks.AutoSize = true;
            this.lblTotalTasks.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalTasks.Location = new System.Drawing.Point(27, 64);
            this.lblTotalTasks.Name = "lblTotalTasks";
            this.lblTotalTasks.Size = new System.Drawing.Size(102, 21);
            this.lblTotalTasks.TabIndex = 2;
            this.lblTotalTasks.Text = "Total Tasks:";
            // 
            // lblCompletedDeals
            // 
            this.lblCompletedDeals.AutoSize = true;
            this.lblCompletedDeals.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompletedDeals.Location = new System.Drawing.Point(60, 180);
            this.lblCompletedDeals.Name = "lblCompletedDeals";
            this.lblCompletedDeals.Size = new System.Drawing.Size(166, 21);
            this.lblCompletedDeals.TabIndex = 3;
            this.lblCompletedDeals.Text = "Completed Deals:";
            // 
            // lblActiveDeals
            // 
            this.lblActiveDeals.AutoSize = true;
            this.lblActiveDeals.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActiveDeals.Location = new System.Drawing.Point(60, 86);
            this.lblActiveDeals.Name = "lblActiveDeals";
            this.lblActiveDeals.Size = new System.Drawing.Size(123, 21);
            this.lblActiveDeals.TabIndex = 4;
            this.lblActiveDeals.Text = "Active Deals:";
            this.lblActiveDeals.Click += new System.EventHandler(this.lblActiveDeals_Click);
            // 
            // lblOverdueTasks
            // 
            this.lblOverdueTasks.AutoSize = true;
            this.lblOverdueTasks.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOverdueTasks.Location = new System.Drawing.Point(60, 131);
            this.lblOverdueTasks.Name = "lblOverdueTasks";
            this.lblOverdueTasks.Size = new System.Drawing.Size(133, 21);
            this.lblOverdueTasks.TabIndex = 5;
            this.lblOverdueTasks.Text = "Overdue Tasks:";
            this.lblOverdueTasks.Click += new System.EventHandler(this.lblOverdueTasks_Click);
            // 
            // lblTasksDueToday
            // 
            this.lblTasksDueToday.AutoSize = true;
            this.lblTasksDueToday.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTasksDueToday.Location = new System.Drawing.Point(60, 41);
            this.lblTasksDueToday.Name = "lblTasksDueToday";
            this.lblTasksDueToday.Size = new System.Drawing.Size(151, 21);
            this.lblTasksDueToday.TabIndex = 6;
            this.lblTasksDueToday.Text = "Tasks Due Today:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalAmount.Location = new System.Drawing.Point(27, 136);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(128, 21);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "Total Amount:";
            this.lblTotalAmount.Click += new System.EventHandler(this.lblTotalAmount_Click);
            // 
            // lblAverageAmount
            // 
            this.lblAverageAmount.AutoSize = true;
            this.lblAverageAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAverageAmount.Location = new System.Drawing.Point(27, 29);
            this.lblAverageAmount.Name = "lblAverageAmount";
            this.lblAverageAmount.Size = new System.Drawing.Size(159, 21);
            this.lblAverageAmount.TabIndex = 8;
            this.lblAverageAmount.Text = "Average Amount:";
            this.lblAverageAmount.Click += new System.EventHandler(this.lblAverageAmount_Click);
            // 
            // chartTasks
            // 
            this.chartTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea15.Name = "ChartArea1";
            this.chartTasks.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chartTasks.Legends.Add(legend15);
            this.chartTasks.Location = new System.Drawing.Point(3, 264);
            this.chartTasks.Name = "chartTasks";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chartTasks.Series.Add(series15);
            this.chartTasks.Size = new System.Drawing.Size(395, 256);
            this.chartTasks.TabIndex = 9;
            this.chartTasks.Text = "chart1";
            // 
            // chartDeals
            // 
            chartArea16.Name = "ChartArea1";
            this.chartDeals.ChartAreas.Add(chartArea16);
            this.chartDeals.Dock = System.Windows.Forms.DockStyle.Fill;
            legend16.Name = "Legend1";
            this.chartDeals.Legends.Add(legend16);
            this.chartDeals.Location = new System.Drawing.Point(404, 3);
            this.chartDeals.Name = "chartDeals";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.chartDeals.Series.Add(series16);
            this.chartDeals.Size = new System.Drawing.Size(395, 255);
            this.chartDeals.TabIndex = 10;
            this.chartDeals.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblActiveDeals);
            this.panel1.Controls.Add(this.lblCompletedDeals);
            this.panel1.Controls.Add(this.lblOverdueTasks);
            this.panel1.Controls.Add(this.lblTasksDueToday);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 255);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.lblTotalTasks);
            this.panel2.Controls.Add(this.lblTotalDeals);
            this.panel2.Controls.Add(this.lblTotalAmount);
            this.panel2.Controls.Add(this.lblAverageAmount);
            this.panel2.Controls.Add(this.lblTotalClients);
            this.panel2.Location = new System.Drawing.Point(404, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 256);
            this.panel2.TabIndex = 12;
            // 
            // tableDashboard
            // 
            this.tableDashboard.ColumnCount = 2;
            this.tableDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDashboard.Controls.Add(this.panel1, 0, 0);
            this.tableDashboard.Controls.Add(this.panel2, 1, 1);
            this.tableDashboard.Controls.Add(this.chartDeals, 1, 0);
            this.tableDashboard.Controls.Add(this.chartTasks, 0, 1);
            this.tableDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDashboard.Location = new System.Drawing.Point(0, 0);
            this.tableDashboard.Name = "tableDashboard";
            this.tableDashboard.RowCount = 2;
            this.tableDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDashboard.Size = new System.Drawing.Size(802, 523);
            this.tableDashboard.TabIndex = 13;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.tableDashboard);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(802, 523);
            ((System.ComponentModel.ISupportInitialize)(this.chartTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDeals)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotalClients;
        private System.Windows.Forms.Label lblTotalDeals;
        private System.Windows.Forms.Label lblTotalTasks;
        private System.Windows.Forms.Label lblCompletedDeals;
        private System.Windows.Forms.Label lblActiveDeals;
        private System.Windows.Forms.Label lblOverdueTasks;
        private System.Windows.Forms.Label lblTasksDueToday;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblAverageAmount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTasks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDeals;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableDashboard;
    }
}
