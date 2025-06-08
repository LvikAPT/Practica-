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
            labelRepairDate = new Label();
            dateTimePickerRepairDate = new DateTimePicker();
            labelWorkDone = new Label();
            textBoxWorkDone = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelRepairDate
            // 
            labelRepairDate.AutoSize = true;
            labelRepairDate.Location = new Point(12, 15);
            labelRepairDate.Name = "labelRepairDate";
            labelRepairDate.Size = new Size(85, 15);
            labelRepairDate.TabIndex = 0;
            labelRepairDate.Text = "Дата ремонта:";
            // 
            // dateTimePickerRepairDate
            // 
            dateTimePickerRepairDate.Format = DateTimePickerFormat.Short;
            dateTimePickerRepairDate.Location = new Point(100, 12);
            dateTimePickerRepairDate.Name = "dateTimePickerRepairDate";
            dateTimePickerRepairDate.Size = new Size(200, 23);
            dateTimePickerRepairDate.TabIndex = 1;
            // 
            // labelWorkDone
            // 
            labelWorkDone.AutoSize = true;
            labelWorkDone.Location = new Point(12, 38);
            labelWorkDone.Name = "labelWorkDone";
            labelWorkDone.Size = new Size(154, 15);
            labelWorkDone.TabIndex = 2;
            labelWorkDone.Text = "Выполненныеs работы:";
            labelWorkDone.Click += labelWorkDone_Click;
            // 
            // textBoxWorkDone
            // 
            textBoxWorkDone.Location = new Point(100, 51);
            textBoxWorkDone.Multiline = true;
            textBoxWorkDone.Name = "textBoxWorkDone";
            textBoxWorkDone.Size = new Size(200, 80);
            textBoxWorkDone.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(100, 140);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(225, 140);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // EditHistoryRepairForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 180);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxWorkDone);
            Controls.Add(labelWorkDone);
            Controls.Add(dateTimePickerRepairDate);
            Controls.Add(labelRepairDate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditHistoryRepairForm";
            Text = "Редактирование истории ремонта";
            ResumeLayout(false);
            PerformLayout();
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
