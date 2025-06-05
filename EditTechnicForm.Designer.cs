namespace office_equipment_repair
{
    partial class EditTechnicForm
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
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.lblOrganizationId = new System.Windows.Forms.Label();
            this.txtOrganizationId = new System.Windows.Forms.TextBox();
            this.lblReceptionDate = new System.Windows.Forms.Label();
            this.dtpReceptionDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 15);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(56, 20);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Модель";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(130, 12);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(250, 27);
            this.txtModel.TabIndex = 1;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(12, 55);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(112, 20);
            this.lblSerialNumber.TabIndex = 2;
            this.lblSerialNumber.Text = "Серийный номер";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(130, 52);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(250, 27);
            this.txtSerialNumber.TabIndex = 3;
            // 
            // lblOrganizationId
            // 
            this.lblOrganizationId.AutoSize = true;
            this.lblOrganizationId.Location = new System.Drawing.Point(12, 95);
            this.lblOrganizationId.Name = "lblOrganizationId";
            this.lblOrganizationId.Size = new System.Drawing.Size(102, 20);
            this.lblOrganizationId.TabIndex = 4;
            this.lblOrganizationId.Text = "ID организации";
            // 
            // txtOrganizationId
            // 
            this.txtOrganizationId.Location = new System.Drawing.Point(130, 92);
            this.txtOrganizationId.Name = "txtOrganizationId";
            this.txtOrganizationId.Size = new System.Drawing.Size(250, 27);
            this.txtOrganizationId.TabIndex = 5;
            // 
            // lblReceptionDate
            // 
            this.lblReceptionDate.AutoSize = true;
            this.lblReceptionDate.Location = new System.Drawing.Point(12, 135);
            this.lblReceptionDate.Name = "lblReceptionDate";
            this.lblReceptionDate.Size = new System.Drawing.Size(102, 20);
            this.lblReceptionDate.TabIndex = 6;
            this.lblReceptionDate.Text = "Дата приёма";
            // 
            // dtpReceptionDate
            // 
            this.dtpReceptionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceptionDate.Location = new System.Drawing.Point(130, 132);
            this.dtpReceptionDate.Name = "dtpReceptionDate";
            this.dtpReceptionDate.Size = new System.Drawing.Size(250, 27);
            this.dtpReceptionDate.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditTechnicForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpReceptionDate);
            this.Controls.Add(this.lblReceptionDate);
            this.Controls.Add(this.txtOrganizationId);
            this.Controls.Add(this.lblOrganizationId);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "EditTechnicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label lblOrganizationId;
        private System.Windows.Forms.TextBox txtOrganizationId;
        private System.Windows.Forms.Label lblReceptionDate;
        private System.Windows.Forms.DateTimePicker dtpReceptionDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
