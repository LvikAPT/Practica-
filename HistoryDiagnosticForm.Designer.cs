namespace office_equipment_repair
{
    partial class HistoryDiagnosticForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewDiagnostics = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDiagnostics = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiagnostics)).BeginInit();
            this.contextMenuStripDiagnostics.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDiagnostics
            // 
            this.dataGridViewDiagnostics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDiagnostics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDiagnostics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiagnostics.ContextMenuStrip = this.contextMenuStripDiagnostics;
            this.dataGridViewDiagnostics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDiagnostics.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDiagnostics.Name = "dataGridViewDiagnostics";
            this.dataGridViewDiagnostics.RowHeadersWidth = 51;
            this.dataGridViewDiagnostics.RowTemplate.Height = 24;
            this.dataGridViewDiagnostics.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewDiagnostics.TabIndex = 0;
            // 
            // contextMenuStripDiagnostics
            // 
            this.contextMenuStripDiagnostics.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDiagnostics.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЗаписьToolStripMenuItem,
            this.изменитьЗаписьToolStripMenuItem,
            this.удалитьЗаписьToolStripMenuItem});
            this.contextMenuStripDiagnostics.Name = "contextMenuStripDiagnostics";
            this.contextMenuStripDiagnostics.Size = new System.Drawing.Size(181, 100);
            // 
            // создатьЗаписьToolStripMenuItem
            // 
            this.создатьЗаписьToolStripMenuItem.Name = "создатьЗаписьToolStripMenuItem";
            this.создатьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.создатьЗаписьToolStripMenuItem.Text = "Создать запись";
            // 
            // изменитьЗаписьToolStripMenuItem
            // 
            this.изменитьЗаписьToolStripMenuItem.Name = "изменитьЗаписьToolStripMenuItem";
            this.изменитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.изменитьЗаписьToolStripMenuItem.Text = "Изменить запись";
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            // 
            // HistoryDiagnosticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDiagnostics);
            this.Name = "HistoryDiagnosticForm";
            this.Text = "История диагностики";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiagnostics)).EndInit();
            this.contextMenuStripDiagnostics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDiagnostics;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDiagnostics;
        private System.Windows.Forms.ToolStripMenuItem создатьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
    }
}
