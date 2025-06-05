﻿namespace office_equipment_repair
{
    partial class UsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripUsers;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditUser;

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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStripUsers = new System.Windows.Forms.ContextMenuStrip();
            this.menuItemAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditUser = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.contextMenuStripUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.ContextMenuStrip = this.contextMenuStripUsers;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 29;
            this.dataGridViewUsers.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.ReadOnly = true;
            // 
            // contextMenuStripUsers
            // 
            this.contextMenuStripUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddUser,
            this.menuItemDeleteUser,
            this.menuItemEditUser});
            this.contextMenuStripUsers.Name = "contextMenuStripUsers";
            this.contextMenuStripUsers.Size = new System.Drawing.Size(181, 88);
            // 
            // menuItemAddUser
            // 
            this.menuItemAddUser.Name = "menuItemAddUser";
            this.menuItemAddUser.Size = new System.Drawing.Size(180, 28);
            this.menuItemAddUser.Text = "Добавить пользователя";
            this.menuItemAddUser.Click += new System.EventHandler(this.menuItemAddUser_Click);
            // 
            // menuItemDeleteUser
            // 
            this.menuItemDeleteUser.Name = "menuItemDeleteUser";
            this.menuItemDeleteUser.Size = new System.Drawing.Size(180, 28);
            this.menuItemDeleteUser.Text = "Удалить";
            this.menuItemDeleteUser.Click += new System.EventHandler(this.menuItemDeleteUser_Click);
            // 
            // menuItemEditUser
            // 
            this.menuItemEditUser.Name = "menuItemEditUser";
            this.menuItemEditUser.Size = new System.Drawing.Size(180, 28);
            this.menuItemEditUser.Text = "Изменить пользователя";
            this.menuItemEditUser.Click += new System.EventHandler(this.menuItemEditUser_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersForm";
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.contextMenuStripUsers.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
