using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace office_equipment_repair
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private string userType;

        public Menu(string userType) : this()
        {
            this.userType = userType;
            ConfigureButtons();
        }

        private void ConfigureButtons()
        {
            if (!string.IsNullOrEmpty(userType) && userType.Trim().ToLower() == "admin")
            {
                btnCreateUser.Visible = true;
                btnCreateUser.Click += BtnCreateUser_Click;
            }
            else
            {
                btnCreateUser.Visible = false;
                btnViewUsers.Visible = false;
            }

            btnOfficeEquipment.Click += BtnOfficeEquipment_Click;
        }

        private void BtnOfficeEquipment_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechnicForm technicForm = new TechnicForm();
            technicForm.ShowDialog();
            this.Show();
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
