using System;
using System.Windows.Forms;
using office_equipment_repair.Models;
using System.Linq;

namespace office_equipment_repair
{
    public partial class EditHistoryDiagnosticForm : Form
    {
        private int? _diagnosticId;
        private int _technicId;
        private OfficeEquipmentRepairContext _context;

        public EditHistoryDiagnosticForm(int? diagnosticId, int technicId)
        {
            InitializeComponent();
            _diagnosticId = diagnosticId;
            _technicId = technicId;
            _context = new OfficeEquipmentRepairContext();

            LoadProblemTypes();

            if (_diagnosticId.HasValue)
            {
                LoadDiagnosticData();
            }
        }

        private void LoadProblemTypes()
        {
            var problems = _context.TypesProblems.ToList();
            comboBoxProblem.DataSource = problems;
            comboBoxProblem.DisplayMember = "ProblemType";
            comboBoxProblem.ValueMember = "Id";
        }

        private void LoadDiagnosticData()
        {
            var diagnostic = _context.Diagnostics.FirstOrDefault(d => d.Id == _diagnosticId.Value);
            if (diagnostic != null)
            {
                // Convert DateOnly to DateTime for DateTimePicker
                dateTimePickerLastDiagnostic.Value = diagnostic.LastDiagnosticDate.ToDateTime(TimeOnly.MinValue);
                dateTimePickerNextDiagnostic.Value = diagnostic.NextDiagnosticDate.ToDateTime(TimeOnly.MinValue);
                comboBoxProblem.SelectedValue = diagnostic.ProblemId;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_diagnosticId.HasValue)
            {
                var diagnostic = _context.Diagnostics.FirstOrDefault(d => d.Id == _diagnosticId.Value);
                if (diagnostic != null)
                {
                    // Convert DateTime to DateOnly for entity
                    diagnostic.LastDiagnosticDate = DateOnly.FromDateTime(dateTimePickerLastDiagnostic.Value);
                    diagnostic.NextDiagnosticDate = DateOnly.FromDateTime(dateTimePickerNextDiagnostic.Value);
                    diagnostic.ProblemId = (int)comboBoxProblem.SelectedValue;
                }
            }
            else
            {
                // Manually generate a new unique Id to avoid duplicate key error
                int newId = 1;
                if (_context.Diagnostics.Any())
                {
                    newId = _context.Diagnostics.Max(d => d.Id) + 1;
                }

                var newDiagnostic = new Diagnostic
                {
                    Id = newId,
                    TechnicId = _technicId,
                    LastDiagnosticDate = DateOnly.FromDateTime(dateTimePickerLastDiagnostic.Value),
                    NextDiagnosticDate = DateOnly.FromDateTime(dateTimePickerNextDiagnostic.Value),
                    ProblemId = (int)comboBoxProblem.SelectedValue
                };
                _context.Diagnostics.Add(newDiagnostic);
            }

            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
