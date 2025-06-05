using System;
using System.Windows.Forms;
using office_equipment_repair.Models;

namespace office_equipment_repair
{
    public partial class EditTechnicForm : Form
    {
        private int technicId;
        private OfficeEquipmentRepairContext context;
        private Technic technic;

        public EditTechnicForm(int technicId)
        {
            InitializeComponent();
            this.technicId = technicId;
            context = new OfficeEquipmentRepairContext();
            LoadTechnicData();
            this.FormClosing += EditTechnicForm_FormClosing;
        }

        public EditTechnicForm() : this(0)
        {
        }

        private void LoadTechnicData()
        {
            if (technicId == 0)
            {
                technic = new Technic();
                return;
            }

            technic = context.Technics.Find(technicId);
            if (technic != null)
            {
                txtModel.Text = technic.Model;
                txtSerialNumber.Text = technic.SerialNumber;
                txtOrganizationId.Text = technic.OrganizationId.ToString();
                dtpReceptionDate.Value = technic.ReceptionDate.ToDateTime(TimeOnly.MinValue);
            }
            else
            {
                MessageBox.Show("Запись не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false; // Disable save button immediately to prevent multiple clicks

            if (technic != null)
            {
                // Input validation
                if (string.IsNullOrWhiteSpace(txtModel.Text))
                {
                    MessageBox.Show("Пожалуйста, введите модель.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModel.Focus();
                    btnSave.Enabled = true; // Re-enable save button on validation failure
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSerialNumber.Text))
                {
                    MessageBox.Show("Пожалуйста, введите серийный номер.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSerialNumber.Focus();
                    btnSave.Enabled = true; // Re-enable save button on validation failure
                    return;
                }
                if (!int.TryParse(txtOrganizationId.Text, out int orgId))
                {
                    MessageBox.Show("Пожалуйста, введите корректный ID организации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOrganizationId.Focus();
                    btnSave.Enabled = true; // Re-enable save button on validation failure
                    return;
                }

                technic.Model = txtModel.Text;
                technic.SerialNumber = txtSerialNumber.Text;
                technic.OrganizationId = orgId;
                technic.ReceptionDate = DateOnly.FromDateTime(dtpReceptionDate.Value);

                if (technicId == 0)
                {
                    // Check for duplicate serial number if needed
                    bool exists = context.Technics.Any(t => t.SerialNumber == technic.SerialNumber);
                    if (exists)
                    {
                        MessageBox.Show("Запись с таким серийным номером уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSerialNumber.Focus();
                        btnSave.Enabled = true; // Re-enable save button on validation failure
                        return;
                    }
                    context.Technics.Add(technic);
                }

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Запись успешно сохранена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    // Removed Application.ExitThread() to prevent closing the entire application
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении записи: " + ex.InnerException?.Message ?? ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true; // Re-enable save button on exception
                }
            }
            else
            {
                btnSave.Enabled = true; // Re-enable save button if technic is null
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditTechnicForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
