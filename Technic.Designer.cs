namespace office_equipment_repair
{
    partial class TechnicForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewTechnic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTechnic;
        private System.Windows.Forms.ToolStripMenuItem создатьНовуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьИсториюРемонтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьИсториюДиагностикиToolStripMenuItem;
        private System.Windows.Forms.Button buttonSortByImportance;

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
            components = new System.ComponentModel.Container();
            dataGridViewTechnic = new DataGridView();
            contextMenuStripTechnic = new ContextMenuStrip(components);
            создатьНовуюЗаписьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьЗаписьToolStripMenuItem = new ToolStripMenuItem();
            удалитьЗаписьToolStripMenuItem = new ToolStripMenuItem();
            открытьИсториюРемонтаToolStripMenuItem = new ToolStripMenuItem();
            открытьИсториюДиагностикиToolStripMenuItem = new ToolStripMenuItem();
            buttonSortByImportance = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTechnic).BeginInit();
            contextMenuStripTechnic.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTechnic
            // 
            dataGridViewTechnic.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTechnic.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTechnic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTechnic.ContextMenuStrip = contextMenuStripTechnic;
            dataGridViewTechnic.Dock = DockStyle.Fill;
            dataGridViewTechnic.Location = new Point(0, 0);
            dataGridViewTechnic.Name = "dataGridViewTechnic";
            dataGridViewTechnic.RowHeadersWidth = 51;
            dataGridViewTechnic.RowTemplate.Height = 29;
            dataGridViewTechnic.Size = new Size(800, 450);
            dataGridViewTechnic.TabIndex = 0;
            // 
            // contextMenuStripTechnic
            // 
            contextMenuStripTechnic.ImageScalingSize = new Size(20, 20);
            contextMenuStripTechnic.Items.AddRange(new ToolStripItem[] { создатьНовуюЗаписьToolStripMenuItem, редактироватьЗаписьToolStripMenuItem, удалитьЗаписьToolStripMenuItem, открытьИсториюРемонтаToolStripMenuItem, открытьИсториюДиагностикиToolStripMenuItem });
            contextMenuStripTechnic.Name = "contextMenuStripTechnic";
            contextMenuStripTechnic.Size = new Size(246, 114);
            // 
            // создатьНовуюЗаписьToolStripMenuItem
            // 
            создатьНовуюЗаписьToolStripMenuItem.Name = "создатьНовуюЗаписьToolStripMenuItem";
            создатьНовуюЗаписьToolStripMenuItem.Size = new Size(245, 22);
            создатьНовуюЗаписьToolStripMenuItem.Text = "Создать новую запись";
            // 
            // редактироватьЗаписьToolStripMenuItem
            // 
            редактироватьЗаписьToolStripMenuItem.Name = "редактироватьЗаписьToolStripMenuItem";
            редактироватьЗаписьToolStripMenuItem.Size = new Size(245, 22);
            редактироватьЗаписьToolStripMenuItem.Text = "Редактировать запись";
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            удалитьЗаписьToolStripMenuItem.Size = new Size(245, 22);
            удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            // 
            // открытьИсториюРемонтаToolStripMenuItem
            // 
            открытьИсториюРемонтаToolStripMenuItem.Name = "открытьИсториюРемонтаToolStripMenuItem";
            открытьИсториюРемонтаToolStripMenuItem.Size = new Size(245, 22);
            открытьИсториюРемонтаToolStripMenuItem.Text = "Открыть историю ремонта";
            // 
            // открытьИсториюДиагностикиToolStripMenuItem
            // 
            открытьИсториюДиагностикиToolStripMenuItem.Name = "открытьИсториюДиагностикиToolStripMenuItem";
            открытьИсториюДиагностикиToolStripMenuItem.Size = new Size(245, 22);
            открытьИсториюДиагностикиToolStripMenuItem.Text = "Открыть историю диагностики";
            // 
            // buttonSortByImportance
            // 
            buttonSortByImportance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSortByImportance.BackColor = Color.Transparent;
            buttonSortByImportance.FlatAppearance.BorderSize = 0;
            buttonSortByImportance.FlatStyle = FlatStyle.Flat;
            buttonSortByImportance.Location = new Point(771, 0);
            buttonSortByImportance.Name = "buttonSortByImportance";
            buttonSortByImportance.Size = new Size(29, 24);
            buttonSortByImportance.TabIndex = 1;
            buttonSortByImportance.Text = "⇅";
            buttonSortByImportance.UseVisualStyleBackColor = false;
            buttonSortByImportance.Click += buttonSortByImportance_Click;
            // 
            // TechnicForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSortByImportance);
            Controls.Add(dataGridViewTechnic);
            Name = "TechnicForm";
Text = "Оргтехника";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTechnic).EndInit();
            contextMenuStripTechnic.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
