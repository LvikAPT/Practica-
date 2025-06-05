using System;
using System.Linq;
using System.Windows.Forms;
using office_equipment_repair.Models;

namespace office_equipment_repair
{
    public partial class EditUserForm : Form
    {
        private readonly OfficeEquipmentRepairContext _context;
        private User _user;

        public EditUserForm()
        {
            InitializeComponent();
            _context = new OfficeEquipmentRepairContext();
            LoadRoles();
        }

        public EditUserForm(User user) : this()
        {
            _user = user;
            LoadUserData();
        }

        private void LoadRoles()
        {
            var roles = _context.TypesUsers.ToList();
            comboBoxRole.DataSource = roles;
            comboBoxRole.DisplayMember = "TypeName";
            comboBoxRole.ValueMember = "Id";
        }

        private void LoadUserData()
        {
            if (_user != null)
            {
                textBoxUsername.Text = _user.Username;
                textBoxPassword.Text = _user.Password;
                if (_user.TypeId.HasValue)
                {
                    comboBoxRole.SelectedValue = _user.TypeId.Value;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя.");
                return;
            }

            if (_user == null)
            {
                _user = new User();
                _context.Users.Add(_user);
            }

            _user.Username = textBoxUsername.Text;
            _user.Password = textBoxPassword.Text;
            _user.TypeId = (int?)comboBoxRole.SelectedValue;

            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
