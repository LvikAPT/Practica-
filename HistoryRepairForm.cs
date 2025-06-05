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
using Microsoft.EntityFrameworkCore;

namespace office_equipment_repair
{
    public partial class HistoryRepairForm : Form
    {
        private OfficeEquipmentRepairContext _context;

        private int _technicId;

        public HistoryRepairForm(int technicId)
        {
            InitializeComponent();
            _context = new OfficeEquipmentRepairContext();
            _technicId = technicId;

            создатьЗаписьToolStripMenuItem.Click += СоздатьЗаписьToolStripMenuItem_Click;
            изменитьЗаписьToolStripMenuItem.Click += ИзменитьЗаписьToolStripMenuItem_Click;
            удалитьЗаписьToolStripMenuItem.Click += УдалитьЗаписьToolStripMenuItem_Click;

            LoadModelName();
            LoadHistoryRepairs();
        }

        private void LoadHistoryRepairs()
        {
            System.Diagnostics.Debug.WriteLine("LoadHistoryRepairs called");
            _context.Dispose();
            _context = new OfficeEquipmentRepairContext();

            var historyRepairs = _context.HistoryRepairs
                .Where(hr => hr.TechnicId == _technicId)
                .Include(hr => hr.Technic)
                .ToList();

            var data = historyRepairs.Select(hr => new
            {
                hr.Id,
                RepairDate = hr.RepairDate,
                WorkDone = hr.WorkDone
            }).ToList();

            dataGridViewHistoryRepairs.DataSource = data;
            if (dataGridViewHistoryRepairs.Columns.Contains("Id"))
            {
                dataGridViewHistoryRepairs.Columns["Id"].Visible = false;
            }

            if (dataGridViewHistoryRepairs.Columns.Contains("RepairDate"))
            {
                dataGridViewHistoryRepairs.Columns["RepairDate"].HeaderText = "Дата ремонта";
            }
            if (dataGridViewHistoryRepairs.Columns.Contains("WorkDone"))
            {
                dataGridViewHistoryRepairs.Columns["WorkDone"].HeaderText = "Выполненные работы";
                dataGridViewHistoryRepairs.Columns["WorkDone"].DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                dataGridViewHistoryRepairs.Columns["WorkDone"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridViewHistoryRepairs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewHistoryRepairs.Refresh();
        }

        private void LoadModelName()
        {
            var technic = _context.Technics.FirstOrDefault(t => t.Id == _technicId);
            if (technic != null)
            {
                this.Text = "История ремонта - " + technic.Model;
            }
            else
            {
                this.Text = "История ремонта - Модель не найдена";

            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void СоздатьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new EditHistoryRepairForm(null, _technicId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadHistoryRepairs();
                }
            }
        }

        private void ИзменитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistoryRepairs.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Редактировать запись", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = (int)dataGridViewHistoryRepairs.CurrentRow.Cells["Id"].Value;

            using (var form = new EditHistoryRepairForm(selectedId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadHistoryRepairs();
                }
            }
        }

        private void УдалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistoryRepairs.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Удалить запись", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = (int)dataGridViewHistoryRepairs.CurrentRow.Cells["Id"].Value;

            var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить запись с Id = {selectedId}?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                var recordToDelete = _context.HistoryRepairs.FirstOrDefault(hr => hr.Id == selectedId);
                if (recordToDelete != null)
                {
                    _context.HistoryRepairs.Remove(recordToDelete);
                    _context.SaveChanges();
                    LoadHistoryRepairs();
                    MessageBox.Show("Запись успешно удалена.", "Удалить запись", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Запись не найдена.", "Удалить запись", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
