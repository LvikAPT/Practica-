namespace office_equipment_repair
{
    partial class EditHistoryRepairForm
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
            this.labelRepairDate = new System.Windows.Forms.Label();
            this.dateTimePickerRepairDate = new System.Windows.Forms.DateTimePicker();
            this.labelWorkDone = new System.Windows.Forms.Label();
            this.textBoxWorkDone = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRepairDate
            // 
            this.labelRepairDate.AutoSize = true;
            this.labelRepairDate.Location = new System.Drawing.Point(12, 15);
            this.labelRepairDate.Name = "labelRepairDate";
            this.labelRepairDate.Size = new System.Drawing.Size(72, 15);
            this.labelRepairDate.TabIndex = 0;
            this.labelRepairDate.Text = "Дата ремонта:";
            // 
            // dateTimePickerRepairDate
            // 
            this.dateTimePickerRepairDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRepairDate.Location = new System.Drawing.Point(100, 12);
            this.dateTimePickerRepairDate.Name = "dateTimePickerRepairDate";
            this.dateTimePickerRepairDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerRepairDate.TabIndex = 1;
            // 
            // labelWorkDone
            // 
            this.labelWorkDone.AutoSize = true;
            this.labelWorkDone.Location = new System.Drawing.Point(12, 50);
            this.labelWorkDone.Name = "labelWorkDone";
            this.labelWorkDone.Size = new System.Drawing.Size(69, 15);
            this.labelWorkDone.TabIndex = 2;
            this.labelWorkDone.Text = "Выполненные работы:";
            // 
            // textBoxWorkDone
            // 
            this.textBoxWorkDone.Location = new System.Drawing.Point(100, 47);
            this.textBoxWorkDone.Multiline = true;
            this.textBoxWorkDone.Name = "textBoxWorkDone";
            this.textBoxWorkDone.Size = new System.Drawing.Size(200, 80);
            this.textBoxWorkDone.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(100, 140);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(225, 140);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // EditHistoryRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.ClientSize = new System.Drawing.Size(320, 180);
this.Controls.Add(this.buttonCancel);
this.Controls.Add(this.buttonSave);
this.Controls.Add(this.textBoxWorkDone);
this.Controls.Add(this.labelWorkDone);
this.Controls.Add(this.dateTimePickerRepairDate);
this.Controls.Add(this.labelRepairDate);
this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
this.MaximizeBox = false;
this.MinimizeBox = false;
this.Name = "EditHistoryRepairForm";
this.Text = "Редактирование истории ремонта";
this.ResumeLayout(false);
this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTechnic;
        private System.Windows.Forms.ComboBox comboBoxTechnic;
        private System.Windows.Forms.Label labelRepairDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerRepairDate;
        private System.Windows.Forms.Label labelWorkDone;
        private System.Windows.Forms.TextBox textBoxWorkDone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
