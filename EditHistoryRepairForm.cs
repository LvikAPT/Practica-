using System;
using System.Linq;
using System.Windows.Forms;
using office_equipment_repair.Models;

namespace office_equipment_repair
{
    public partial class EditHistoryRepairForm : Form
    {
        private readonly OfficeEquipmentRepairContext _context;
        private HistoryRepair _historyRepair;

        private int _technicId;

        public EditHistoryRepairForm(int? historyRepairId = null, int? preselectedTechnicId = null)
        {
            InitializeComponent();
            _context = new OfficeEquipmentRepairContext();

            if (preselectedTechnicId.HasValue)
            {
                _technicId = preselectedTechnicId.Value;
                System.Diagnostics.Debug.WriteLine($"EditHistoryRepairForm: preselectedTechnicId = {_technicId}");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("EditHistoryRepairForm: preselectedTechnicId is null");
            }

            if (historyRepairId.HasValue)
            {
                LoadHistoryRepair(historyRepairId.Value);
            }
            else
            {
                _historyRepair = new HistoryRepair();
                dateTimePickerRepairDate.Value = DateTime.Today;
            }
        }

        private void LoadTechnics()
        {
            // Removed as Technic selection UI is removed
        }

        private void LoadHistoryRepair(int id)
        {
            _historyRepair = _context.HistoryRepairs.FirstOrDefault(hr => hr.Id == id);
            if (_historyRepair != null)
            {
                // Removed as Technic selection UI is removed
                _technicId = _historyRepair.TechnicId;
                dateTimePickerRepairDate.Value = _historyRepair.RepairDate.ToDateTime(TimeOnly.MinValue);
                textBoxWorkDone.Text = _historyRepair.WorkDone;
            }
            else
            {
                MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"ButtonSave_Click: _technicId = {_technicId}");
            // Validate TechnicId exists in Technics table
            var technicExists = _context.Technics.Any(t => t.Id == _technicId);
            System.Diagnostics.Debug.WriteLine($"ButtonSave_Click: technicExists = {technicExists}");
            if (!technicExists)
            {
                MessageBox.Show("The associated Technic does not exist. Cannot save the repair record.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _historyRepair.TechnicId = _technicId;
            _historyRepair.RepairDate = DateOnly.FromDateTime(dateTimePickerRepairDate.Value);
            _historyRepair.WorkDone = textBoxWorkDone.Text;

            if (_historyRepair.Id == 0)
            {
                // Ensure Id is 0 for new records to avoid primary key conflicts
                _historyRepair.Id = 0;
                _context.HistoryRepairs.Add(_historyRepair);
            }
            else
            {
                _context.HistoryRepairs.Update(_historyRepair);
            }

            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
