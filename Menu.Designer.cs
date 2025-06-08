namespace office_equipment_repair
{
    partial class Menu
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
            btnOfficeEquipment = new Button();
            btnCreateUser = new Button();
            btnExit = new Button();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // btnOfficeEquipment
            // 
            btnOfficeEquipment.BackColor = Color.FromArgb(1, 111, 90);
            btnOfficeEquipment.FlatAppearance.BorderColor = Color.White;
            btnOfficeEquipment.FlatAppearance.BorderSize = 2;
            btnOfficeEquipment.FlatStyle = FlatStyle.Flat;
            btnOfficeEquipment.ForeColor = Color.White;
            btnOfficeEquipment.Location = new Point(50, 103);
            btnOfficeEquipment.Name = "btnOfficeEquipment";
            btnOfficeEquipment.Size = new Size(200, 40);
            btnOfficeEquipment.TabIndex = 0;
            btnOfficeEquipment.Text = "Оргтехника";
            btnOfficeEquipment.UseVisualStyleBackColor = false;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.FromArgb(1, 111, 90);
            btnCreateUser.FlatAppearance.BorderColor = Color.White;
            btnCreateUser.FlatAppearance.BorderSize = 2;
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.ForeColor = Color.White;
            btnCreateUser.Location = new Point(50, 168);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(200, 40);
            btnCreateUser.TabIndex = 1;
            btnCreateUser.Text = "Просмотр всех пользователей";
            btnCreateUser.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(1, 111, 90);
            btnExit.FlatAppearance.BorderColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(50, 235);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "Выйти из аккаунта";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(96, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 50);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 111, 90);
            ClientSize = new Size(304, 321);
            Controls.Add(btnOfficeEquipment);
            Controls.Add(btnCreateUser);
            Controls.Add(btnExit);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(320, 360);
            Name = "Menu";
            Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnOfficeEquipment;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
