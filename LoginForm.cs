using Microsoft.EntityFrameworkCore;

namespace office_equipment_repair
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate mandatory fields
            if (string.IsNullOrWhiteSpace(txtNickname.Text))
            {
                MessageBox.Show("Пожалуйста, введите никнейм.", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNickname.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Пожалуйста, введите пароль.", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Authenticate user
            using (var context = new Models.OfficeEquipmentRepairContext())
            {
                var user = context.Users
                    .Include(u => u.Type)
                    .FirstOrDefault(u => u.Username == txtNickname.Text && u.Password == txtPassword.Text);

                if (user != null)
                {
                    // Removed success message box
                    // Proceed to Menu form with user type
                    Menu menuForm = new Menu(user.Type != null ? user.Type.TypeName : "user"); // Use TypeName from TypesUser or default to "user"
                    menuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный никнейм или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
