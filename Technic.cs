﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using office_equipment_repair.Models;

using Models = office_equipment_repair.Models;

namespace office_equipment_repair
{
    public partial class TechnicForm : Form
    {
        int _sortState = 0;

        public TechnicForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadTechnicData();
            dataGridViewTechnic.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTechnic.MouseDown += DataGridViewTechnic_MouseDown;
            dataGridViewTechnic.CellFormatting += dataGridViewTechnic_CellFormatting;

            удалитьЗаписьToolStripMenuItem.Click += УдалитьЗаписьToolStripMenuItem_Click;
            редактироватьЗаписьToolStripMenuItem.Click += РедактироватьЗаписьToolStripMenuItem_Click;
            открытьИсториюРемонтаToolStripMenuItem.Click += ОткрытьИсториюРемонтаToolStripMenuItem_Click;
            открытьИсториюДиагностикиToolStripMenuItem.Click += ОткрытьИсториюДиагностикиToolStripMenuItem_Click;
            создатьНовуюЗаписьToolStripMenuItem.Click += создатьНовуюЗаписьToolStripMenuItem_Click;
        }

        private void создатьНовуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var createForm = new EditTechnicForm(0))
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTechnicData();
                }
            }
        }
        private void DataGridViewTechnic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridViewTechnic.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dataGridViewTechnic.ClearSelection();
                    dataGridViewTechnic.Rows[hitTestInfo.RowIndex].Selected = true;
                }
                else
                {
                    dataGridViewTechnic.ClearSelection();
                }
                contextMenuStripTechnic.Show(dataGridViewTechnic, e.Location);
            }
        }

        private void УдалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewTechnic.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var selectedRow = dataGridViewTechnic.SelectedRows[0];
                int technicId = (int)selectedRow.Cells["Id"].Value;

                using (var context = new OfficeEquipmentRepairContext())
                {
                    var technicToDelete = context.Technics.Find(technicId);
                    if (technicToDelete != null)
                    {
                        context.Technics.Remove(technicToDelete);
                        context.SaveChanges();
                    }
                }

                LoadTechnicData();
            }
        }

        private void РедактироватьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewTechnic.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Редактирование записи", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewTechnic.SelectedRows[0];
            int technicId = (int)selectedRow.Cells["Id"].Value;

            using (var editForm = new EditTechnicForm(technicId))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTechnicData();
                }
            }
        }

        private void ОткрытьИсториюРемонтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewTechnic.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для просмотра истории ремонта.", "История ремонта", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewTechnic.SelectedRows[0];
            int technicId = (int)selectedRow.Cells["Id"].Value;

            var historyForm = new HistoryRepairForm(technicId);
            historyForm.Show();
        }

        private void ОткрытьИсториюДиагностикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewTechnic.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для просмотра истории диагностики.", "История диагностики", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewTechnic.SelectedRows[0];
            int technicId = (int)selectedRow.Cells["Id"].Value;

            var historyDiagnosticForm = new HistoryDiagnosticForm(technicId);
            historyDiagnosticForm.Show();
        }

        public void LoadTechnicData()
        {
            using (var context = new OfficeEquipmentRepairContext())
            {
                var technicList = context.Technics
                    .Select(t => new
                    {
                        t.Id,
                        t.Model,
                        t.SerialNumber,
                        t.OrganizationId,
                        t.ReceptionDate,
                        LastDiagnosticDate = t.Diagnostics.OrderByDescending(d => d.LastDiagnosticDate).Select(d => d.LastDiagnosticDate).FirstOrDefault(),
                        NextDiagnosticDate = t.Diagnostics.OrderByDescending(d => d.NextDiagnosticDate).Select(d => d.NextDiagnosticDate).FirstOrDefault()
                    })
                    .AsEnumerable()
                    .Select(t => new
                    {
                        t.Id,
                        t.Model,
                        t.SerialNumber,
                        t.OrganizationId,
                        t.ReceptionDate,
                        t.LastDiagnosticDate,
                        t.NextDiagnosticDate,
                        SortOrder = GetSortOrder(t.NextDiagnosticDate)
                    })
                    .ToList();

                switch (_sortState)
                {
                    case 0: // green top
                        technicList = technicList.OrderBy(t => t.SortOrder == 3 ? 0 : (t.SortOrder == 2 ? 1 : (t.SortOrder == 1 ? 2 : 3))).ThenBy(t => t.NextDiagnosticDate).ToList();
                        break;
                    case 1: // red top
                        technicList = technicList.OrderBy(t => t.SortOrder == 1 ? 0 : (t.SortOrder == 2 ? 1 : (t.SortOrder == 3 ? 2 : 3))).ThenBy(t => t.NextDiagnosticDate).ToList();
                        break;
                    case 2: // white top
                        technicList = technicList.OrderBy(t => t.SortOrder == 4 ? 0 : (t.SortOrder == 2 ? 1 : (t.SortOrder == 3 ? 2 : 3))).ThenBy(t => t.NextDiagnosticDate).ToList();
                        break;
                }

                dataGridViewTechnic.DataSource = technicList;

                // Customize columns
                dataGridViewTechnic.Columns["Id"].Visible = false;

                dataGridViewTechnic.Columns["Model"].HeaderText = "Модель";
                dataGridViewTechnic.Columns["SerialNumber"].HeaderText = "Серийный номер";
                dataGridViewTechnic.Columns["OrganizationId"].HeaderText = "ID организации";
                dataGridViewTechnic.Columns["ReceptionDate"].HeaderText = "Дата приёма";
                dataGridViewTechnic.Columns["LastDiagnosticDate"].HeaderText = "Дата последней диагностики";
                dataGridViewTechnic.Columns["NextDiagnosticDate"].HeaderText = "Дата следующей диагностики";

                // Hide the last column
                if (dataGridViewTechnic.Columns.Count > 0)
                {
                    dataGridViewTechnic.Columns[dataGridViewTechnic.Columns.Count - 1].Visible = false;
                }
            }
        }

        private int GetSortOrder(DateOnly nextDiagnosticDate)
        {
            if (nextDiagnosticDate == default)
                return 4; // white last

            DateTime nextDate = nextDiagnosticDate.ToDateTime(TimeOnly.MinValue);
            DateTime today = DateTime.Today;
            TimeSpan diff = nextDate.Date - today;

            if (diff.TotalDays < 0)
                return 1; // red top
            else if (diff.TotalDays <= 31)
                return 2; // orange
            else
                return 3; // green
        }

        private void dataGridViewTechnic_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewTechnic.Columns[e.ColumnIndex].Name == "NextDiagnosticDate")
            {
                if (e.Value == null || e.Value == DBNull.Value || string.IsNullOrEmpty(e.Value.ToString()))
                {
                    return;
                }

                DateTime nextDate;
                if (e.Value is DateOnly dateOnly)
                {
                    nextDate = dateOnly.ToDateTime(TimeOnly.MinValue);
                }
                else
                {
                    nextDate = Convert.ToDateTime(e.Value);
                }

                if (nextDate == DateTime.MinValue)
                {
                    return;
                }

                DateTime today = DateTime.Today;
                TimeSpan diff = nextDate.Date - today;

                if (diff.TotalDays < 0)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (diff.TotalDays <= 31 && diff.TotalDays >= 0)
                {
                    e.CellStyle.BackColor = Color.Orange;
                }
                else
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void buttonSortByImportance_Click(object sender, EventArgs e)
        {
            _sortState = (_sortState + 1) % 3;
            LoadTechnicData();
        }
    }
}