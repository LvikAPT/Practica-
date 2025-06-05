using System;
using System.Linq;
using System.Windows.Forms;
using office_equipment_repair.Models;

namespace office_equipment_repair
{
    public partial class UsersForm : Form
    {
        private readonly OfficeEquipmentRepairContext _context;

        public UsersForm()
        {
            InitializeComponent();
            _context = new OfficeEquipmentRepairContext();
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = _context.Users
                .Select(u => new
                {
                    u.Id,
                    Имя_пользователя = u.Username,
                    Пароль = u.Password,
                    Роль = u.Type != null ? u.Type.TypeName : "Без роли"
                })
                .ToList();

            dataGridViewUsers.DataSource = users;
            dataGridViewUsers.Columns["Id"].Visible = false;
            dataGridViewUsers.AutoResizeColumns();
        }

        private void menuItemAddUser_Click(object sender, EventArgs e)
        {
            EditUserForm createUserForm = new EditUserForm();
            if (createUserForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void menuItemDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для удаления.");
                return;
            }

            int userId = (int)dataGridViewUsers.CurrentRow.Cells["Id"].Value;
            var user = _context.Users.Find(userId);
            if (user != null)
            {
                var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить пользователя {user.Username}?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                    LoadUsers();
                }
            }
        }

        private void menuItemEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для изменения.");
                return;
            }

            int userId = (int)dataGridViewUsers.CurrentRow.Cells["Id"].Value;
            var user = _context.Users.Find(userId);
            if (user != null)
            {
                EditUserForm editUserForm = new EditUserForm(user);
                if (editUserForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }
    }
}
