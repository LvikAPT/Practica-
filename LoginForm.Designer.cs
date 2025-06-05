namespace office_equipment_repair
{
partial class LoginForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblNickname;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtNickname;
    private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExitApp;
    private System.Windows.Forms.Label lblCompanyName;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(120, 10);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(160, 37);
            this.lblCompanyName.TabIndex = 6;
            this.lblCompanyName.Text = "УралАсбест";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(50, 70);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(60, 15);
            this.lblNickname.TabIndex = 0;
            this.lblNickname.Text = "Никнейм:";
            this.lblNickname.ForeColor = System.Drawing.Color.White;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(50, 120);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Пароль:";
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(150, 67);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(200, 23);
            this.txtNickname.TabIndex = 2;
            this.txtNickname.BackColor = System.Drawing.Color.FromArgb(0, 93, 75); // #005d4b
            this.txtNickname.ForeColor = System.Drawing.Color.White;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(0, 93, 75); // #005d4b
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(150, 170);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(1, 111, 90); // #016f5a
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(260, 170);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(100, 30);
            this.btnExitApp.TabIndex = 5;
            this.btnExitApp.Text = "Выйти из приложения";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.BackColor = System.Drawing.Color.FromArgb(1, 111, 90); // #016f5a
            this.btnExitApp.ForeColor = System.Drawing.Color.White;
            this.btnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApp.FlatAppearance.BorderSize = 2;
            this.btnExitApp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.BackColor = System.Drawing.Color.FromArgb(1, 111, 90); // #016f5a
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExitApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FormLogin";
this.Text = "Вход в систему";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    #endregion
}
}
