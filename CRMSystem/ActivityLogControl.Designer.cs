namespace CRMSystem
{
    partial class ActivityLogControl
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
            this.dataGridActivityLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivityLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridActivityLog
            // 
            this.dataGridActivityLog.AllowUserToAddRows = false;
            this.dataGridActivityLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridActivityLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActivityLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridActivityLog.Location = new System.Drawing.Point(0, 0);
            this.dataGridActivityLog.Name = "dataGridActivityLog";
            this.dataGridActivityLog.ReadOnly = true;
            this.dataGridActivityLog.RowHeadersWidth = 51;
            this.dataGridActivityLog.RowTemplate.Height = 24;
            this.dataGridActivityLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridActivityLog.Size = new System.Drawing.Size(673, 480);
            this.dataGridActivityLog.TabIndex = 0;
            // 
            // ActivityLogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridActivityLog);
            this.Name = "ActivityLogControl";
            this.Size = new System.Drawing.Size(673, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivityLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridActivityLog;
    }
}
