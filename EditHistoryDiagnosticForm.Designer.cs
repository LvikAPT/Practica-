namespace office_equipment_repair
{
    partial class EditHistoryDiagnosticForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastDiagnostic;
        private System.Windows.Forms.DateTimePicker dateTimePickerNextDiagnostic;
        private System.Windows.Forms.ComboBox comboBoxProblem;
        private System.Windows.Forms.Label labelLastDiagnostic;
        private System.Windows.Forms.Label labelNextDiagnostic;
        private System.Windows.Forms.Label labelProblem;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dateTimePickerLastDiagnostic = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNextDiagnostic = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProblem = new System.Windows.Forms.ComboBox();
            this.labelLastDiagnostic = new System.Windows.Forms.Label();
            this.labelNextDiagnostic = new System.Windows.Forms.Label();
            this.labelProblem = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerLastDiagnostic
            // 
            this.dateTimePickerLastDiagnostic.Location = new System.Drawing.Point(160, 20);
            this.dateTimePickerLastDiagnostic.Name = "dateTimePickerLastDiagnostic";
            this.dateTimePickerLastDiagnostic.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerLastDiagnostic.TabIndex = 0;
            // 
            // dateTimePickerNextDiagnostic
            // 
            this.dateTimePickerNextDiagnostic.Location = new System.Drawing.Point(160, 60);
            this.dateTimePickerNextDiagnostic.Name = "dateTimePickerNextDiagnostic";
            this.dateTimePickerNextDiagnostic.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerNextDiagnostic.TabIndex = 1;
            // 
            // comboBoxProblem
            // 
            this.comboBoxProblem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProblem.FormattingEnabled = true;
            this.comboBoxProblem.Location = new System.Drawing.Point(160, 100);
            this.comboBoxProblem.Name = "comboBoxProblem";
            this.comboBoxProblem.Size = new System.Drawing.Size(200, 24);
            this.comboBoxProblem.TabIndex = 2;
            // 
            // labelLastDiagnostic
            // 
            this.labelLastDiagnostic.AutoSize = true;
            this.labelLastDiagnostic.Location = new System.Drawing.Point(20, 25);
            this.labelLastDiagnostic.Name = "labelLastDiagnostic";
            this.labelLastDiagnostic.Size = new System.Drawing.Size(134, 17);
            this.labelLastDiagnostic.TabIndex = 3;
            this.labelLastDiagnostic.Text = "Дата последней диагностики";
            // 
            // labelNextDiagnostic
            // 
            this.labelNextDiagnostic.AutoSize = true;
            this.labelNextDiagnostic.Location = new System.Drawing.Point(20, 65);
            this.labelNextDiagnostic.Name = "labelNextDiagnostic";
            this.labelNextDiagnostic.Size = new System.Drawing.Size(134, 17);
            this.labelNextDiagnostic.TabIndex = 4;
            this.labelNextDiagnostic.Text = "Дата следующей диагностики";
            // 
            // labelProblem
            // 
            this.labelProblem.AutoSize = true;
            this.labelProblem.Location = new System.Drawing.Point(20, 105);
            this.labelProblem.Name = "labelProblem";
            this.labelProblem.Size = new System.Drawing.Size(134, 17);
            this.labelProblem.TabIndex = 5;
            this.labelProblem.Text = "Обнаруженная проблема";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(160, 150);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 30);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(285, 150);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 30);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EditHistoryDiagnosticForm
            // 
this.ClientSize = new System.Drawing.Size(400, 200);
this.Controls.Add(this.dateTimePickerLastDiagnostic);
this.Controls.Add(this.dateTimePickerNextDiagnostic);
this.Controls.Add(this.comboBoxProblem);
this.Controls.Add(this.labelLastDiagnostic);
this.Controls.Add(this.labelNextDiagnostic);
this.Controls.Add(this.labelProblem);
this.Controls.Add(this.buttonSave);
this.Controls.Add(this.buttonCancel);
this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
this.MaximizeBox = false;
this.MinimizeBox = false;
this.Name = "EditHistoryDiagnosticForm";
this.Text = "Редактирование истории диагностики";
this.ResumeLayout(false);
this.PerformLayout();
        }
    }
}
