using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using office_equipment_repair.Models;

namespace office_equipment_repair
{
    public partial class HistoryDiagnosticForm : Form
    {
        private int _technicId;
        private OfficeEquipmentRepairContext _context;

        public HistoryDiagnosticForm(int technicId)
        {
            InitializeComponent();
            _technicId = technicId;
            _context = new OfficeEquipmentRepairContext();

            создатьЗаписьToolStripMenuItem.Click += СоздатьЗаписьToolStripMenuItem_Click;
            изменитьЗаписьToolStripMenuItem.Click += ИзменитьЗаписьToolStripMenuItem_Click;
            удалитьЗаписьToolStripMenuItem.Click += УдалитьЗаписьToolStripMenuItem_Click;

            LoadModelName();
            LoadDiagnosticData();
        }

        private void LoadModelName()
        {
            var technic = _context.Technics.FirstOrDefault(t => t.Id == _technicId);
            if (technic != null)
            {
                this.Text = "История диагностики - " + technic.Model;
            }
            else
            {
                this.Text = "История диагностики - Модель не найдена";
            }
        }

        private void LoadDiagnosticData()
        {
            var diagnostics = _context.Diagnostics
                .Where(d => d.TechnicId == _technicId)
                .Select(d => new
                {
                    d.Id,
                    d.LastDiagnosticDate,
                    d.NextDiagnosticDate,
                    Problem = d.Problem != null ? d.Problem.ProblemType : ""
                })
                .ToList();

            dataGridViewDiagnostics.DataSource = diagnostics;

            if (dataGridViewDiagnostics.Columns.Contains("Id"))
            {
                dataGridViewDiagnostics.Columns["Id"].Visible = false;
            }

            if (dataGridViewDiagnostics.Columns.Contains("LastDiagnosticDate"))
            {
                dataGridViewDiagnostics.Columns["LastDiagnosticDate"].HeaderText = "Дата последней диагностики";
            }

            if (dataGridViewDiagnostics.Columns.Contains("NextDiagnosticDate"))
            {
                dataGridViewDiagnostics.Columns["NextDiagnosticDate"].HeaderText = "Дата следующей диагностики";
            }

            if (dataGridViewDiagnostics.Columns.Contains("Problem"))
            {
                dataGridViewDiagnostics.Columns["Problem"].HeaderText = "Обнаруженная проблема";
                dataGridViewDiagnostics.Columns["Problem"].DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                dataGridViewDiagnostics.Columns["Problem"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridViewDiagnostics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void СоздатьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new EditHistoryDiagnosticForm(null, _technicId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadDiagnosticData();
                    RefreshTechnicForm();
                }
            }
        }

        private void ИзменитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewDiagnostics.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Редактировать запись", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = (int)dataGridViewDiagnostics.CurrentRow.Cells["Id"].Value;

            using (var form = new EditHistoryDiagnosticForm(selectedId, _technicId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadDiagnosticData();
                    RefreshTechnicForm();
                }
            }
        }

        private void УдалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewDiagnostics.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Удалить запись", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = (int)dataGridViewDiagnostics.CurrentRow.Cells["Id"].Value;

            var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить запись с Id = {selectedId}?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                var recordToDelete = _context.Diagnostics.FirstOrDefault(d => d.Id == selectedId);
                if (recordToDelete != null)
                {
                    _context.Diagnostics.Remove(recordToDelete);
                    _context.SaveChanges();
                    LoadDiagnosticData();
                    RefreshTechnicForm();
                    MessageBox.Show("Запись успешно удалена.", "Удалить запись", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Запись не найдена.", "Удалить запись", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshTechnicForm()
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is TechnicForm technicForm)
                {
                    technicForm.LoadTechnicData();
                    break;
                }
            }
        }
    }
}
