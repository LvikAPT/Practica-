﻿namespace office_equipment_repair
{
    partial class HistoryRepairForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewHistoryRepairs;
        private System.Windows.Forms.Label labelModelName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHistory;
        private System.Windows.Forms.ToolStripMenuItem создатьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        // Removed Dispose method to avoid duplicate definition with HistoryDiagnosticForm.cs
        // protected override void Dispose(bool disposing)
        // {
        //     if (disposing && (components != null))
        //     {
        //         components.Dispose();
        //     }
        //     base.Dispose(disposing);
        // }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewHistoryRepairs = new System.Windows.Forms.DataGridView();
            this.labelModelName = new System.Windows.Forms.Label();
            this.contextMenuStripHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryRepairs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModelName
            // 
            // Removed labelModelName control as per new layout
            // 
            // dataGridViewHistoryRepairs
            // 
            this.dataGridViewHistoryRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoryRepairs.ContextMenuStrip = this.contextMenuStripHistory;
            this.dataGridViewHistoryRepairs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistoryRepairs.Name = "dataGridViewHistoryRepairs";
            this.dataGridViewHistoryRepairs.RowHeadersWidth = 51;
            this.dataGridViewHistoryRepairs.RowTemplate.Height = 29;
            this.dataGridViewHistoryRepairs.TabIndex = 0;
            // 
            // contextMenuStripHistory
            // 
            this.contextMenuStripHistory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЗаписьToolStripMenuItem,
            this.изменитьЗаписьToolStripMenuItem,
            this.удалитьЗаписьToolStripMenuItem});
            this.contextMenuStripHistory.Name = "contextMenuStripHistory";
            this.contextMenuStripHistory.Size = new System.Drawing.Size(270, 76);
            // 
            // создатьЗаписьToolStripMenuItem
            // 
            this.создатьЗаписьToolStripMenuItem.Name = "создатьЗаписьToolStripMenuItem";
            this.создатьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(269, 24);
            this.создатьЗаписьToolStripMenuItem.Text = "Создать запись";
            // 
            // изменитьЗаписьToolStripMenuItem
            // 
            this.изменитьЗаписьToolStripMenuItem.Name = "изменитьЗаписьToolStripMenuItem";
            this.изменитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(269, 24);
            this.изменитьЗаписьToolStripMenuItem.Text = "Изменить запись о ремонте";
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(269, 24);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            // 
            // HistoryRepairForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewHistoryRepairs);
            // Removed labelModelName from Controls collection
            this.Name = "HistoryRepairForm";
            this.Text = "История ремонта";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryRepairs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
