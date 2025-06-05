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
            this.btnOfficeEquipment = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
this.pictureBoxLogo.Image = System.Drawing.Image.FromFile("..\\..\\..\\Res\\logo.jpg");
            this.pictureBoxLogo.Location = new System.Drawing.Point(100, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnOfficeEquipment
            // 
            this.btnOfficeEquipment.Location = new System.Drawing.Point(50, 70);
            this.btnOfficeEquipment.Name = "btnOfficeEquipment";
            this.btnOfficeEquipment.Size = new System.Drawing.Size(200, 40);
            this.btnOfficeEquipment.TabIndex = 0;
            this.btnOfficeEquipment.Text = "Оргтехника";
            this.btnOfficeEquipment.UseVisualStyleBackColor = false;
            this.btnOfficeEquipment.BackColor = System.Drawing.Color.FromArgb(1, 111, 90); // #016f5a
            this.btnOfficeEquipment.ForeColor = System.Drawing.Color.White;
            this.btnOfficeEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfficeEquipment.FlatAppearance.BorderSize = 2;
            this.btnOfficeEquipment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOfficeEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(50, 130);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(200, 40);
            this.btnCreateUser.TabIndex = 1;
            this.btnCreateUser.Text = "Создать нового пользователя";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(1, 111, 90); // #016f5a
            this.btnCreateUser.ForeColor = System.Drawing.Color.White;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.FlatAppearance.BorderSize = 2;
            this.btnCreateUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Location = new System.Drawing.Point(50, 250);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(200, 40);
            this.btnViewUsers.TabIndex = 3;
            this.btnViewUsers.Text = "Просмотр пользователей";
            this.btnViewUsers.UseVisualStyleBackColor = false;
            this.btnViewUsers.BackColor = System.Drawing.Color.FromArgb(1, 111, 90); // #016f5a
            this.btnViewUsers.ForeColor = System.Drawing.Color.White;
            this.btnViewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUsers.FlatAppearance.BorderSize = 2;
            this.btnViewUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewUsers.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(50, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выйти из аккаунта";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(1, 111, 90); // #016f5a
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.MinimumSize = new System.Drawing.Size(320, 360);
            this.BackColor = System.Drawing.Color.FromArgb(1, 111, 90); // #016f5a
            this.Controls.Add(this.btnOfficeEquipment);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.btnViewUsers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnOfficeEquipment;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
