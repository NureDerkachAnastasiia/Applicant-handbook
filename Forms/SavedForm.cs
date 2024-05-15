using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class SavedForm : Form
    {
        MainForm _mainForm;
        DataGridViewRow selectedRow;
        public SavedForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
        }

        private void FillSavedUnisDataGridView()
        {
            SavedUnisDataGridView.DataSource = _mainForm.directory.SavedUnis;
            SavedUnisDataGridView.Columns["NameColumn"].DataPropertyName = "Name";
            SavedUnisDataGridView.Columns["CityColumn"].DataPropertyName = "City";
            foreach (DataGridViewColumn column in SavedUnisDataGridView.Columns)
            {
                if (column.Name != "NameColumn" && column.Name != "CityColumn")
                {
                    column.Visible = false;
                }
            }

            SavedUnisDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            SavedUnisDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SavedUnisDataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            SavedUnisDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FillSavedSpecisDataGridView()
        {
            SavedSpecisDataGridView.DataSource = _mainForm.directory.SavedSpecis;
            if (_mainForm.directory.SavedSpecis != null)
            {
                SavedSpecisDataGridView.ColumnHeadersHeight = 70;

            }
            SavedSpecisDataGridView.Columns["NameColumn"].DataPropertyName = "Name";
            SavedSpecisDataGridView.Columns["EduColumn"].DataPropertyName = "EducationForm";
            SavedSpecisDataGridView.Columns["UniColumn"].DataPropertyName = "Uni";
            foreach (DataGridViewColumn column in SavedSpecisDataGridView.Columns)
            {
                if (column.Name != "NameColumn" && column.Name != "EduColumn" && column.Name != "UniColumn")
                {
                    column.Visible = false;
                }
            }
            SavedSpecisDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SavedSpecisDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SavedSpecisDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.Show();
        }

        private void RemoveAllUniButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете видалити усі ЗВО зі Збереженого?", "Підтверження видалення", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var dataSource = SavedUnisDataGridView.DataSource;
                SavedUnisDataGridView.DataSource = new List<University>();
                _mainForm.directory.RemoveAllSavedUnis();
                FillSavedUnisDataGridView();
                SavedUnisDataGridView.DataSource = dataSource;
            }
        }

        private void RemoveAllSpecButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете видалити усі спеціальності зі Збереженого?", "Підтверження видалення", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var dataSource = SavedSpecisDataGridView.DataSource;
                SavedSpecisDataGridView.DataSource = new List<Speciality>();
                _mainForm.directory.RemoveAllSavedSpecis();
                FillSavedSpecisDataGridView();
                SavedSpecisDataGridView.DataSource = dataSource;
            }
        }

        private void SavedForm_Load(object sender, EventArgs e)
        {
            SavedSpecisDataGridView.AutoGenerateColumns = false;
            SavedSpecisDataGridView.EnableHeadersVisualStyles = false;
            SavedSpecisDataGridView.Columns.Add("NameColumn", "Назва спеціальності");
            SavedSpecisDataGridView.Columns.Add("EduColumn", "Форма навчання");
            SavedSpecisDataGridView.Columns.Add("UniColumn", "Назва ЗВО");

            SavedUnisDataGridView.AutoGenerateColumns = false;
            SavedUnisDataGridView.EnableHeadersVisualStyles = false;
            SavedUnisDataGridView.Columns.Add("NameColumn", "Назва університету");
            SavedUnisDataGridView.Columns.Add("CityColumn", "Область");

            FillSavedUnisDataGridView();
            FillSavedSpecisDataGridView();

            SavedUnisDataGridView.CurrentCell = null;
            SavedSpecisDataGridView.DataBindingComplete += (o, args) =>
            {
                SavedSpecisDataGridView.ClearSelection();
            };
        }

        private void SavedSpecisDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = SavedSpecisDataGridView.Rows[e.RowIndex];
            }
        }

        private void RemoveSpecButton_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                Speciality selSpec = (Speciality)selectedRow.DataBoundItem;
                _mainForm.directory.RemoveSpeciality(selSpec);
                SavedSpecisDataGridView.DataSource = new List<Speciality>();
                FillSavedSpecisDataGridView();
                selectedRow = null;
            }
        }

        private void RemoveUniButton_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                University selUni = (University)selectedRow.DataBoundItem;
                _mainForm.directory.RemoveUniversity(selUni);
                SavedUnisDataGridView.DataSource = new List<University>();
                FillSavedUnisDataGridView();
                selectedRow = null;
            }
        }

        private void SavedUnisDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = SavedUnisDataGridView.Rows[e.RowIndex];
            }
        }

        private void SavedUnisDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                SavedUnisDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                if (SavedUnisDataGridView.Rows[e.RowIndex].Selected)
                {
                    SavedUnisDataGridView.ClearSelection();
                }
                else
                {
                    SavedUnisDataGridView.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void SavedSpecisDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                SavedSpecisDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                if (SavedSpecisDataGridView.Rows[e.RowIndex].Selected)
                {
                    SavedSpecisDataGridView.ClearSelection();
                }
                else
                {
                    SavedSpecisDataGridView.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void SavedUnisDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            this.Hide();
            University uni = (University)SavedUnisDataGridView.Rows[e.RowIndex].DataBoundItem;
            InfoUniForm form = new InfoUniForm(this, uni, _mainForm);
            form.Show();
            form.FillInfoUniForm(uni);
        }

        private void SavedSpecisDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            this.Hide();
            Speciality spec = (Speciality)SavedSpecisDataGridView.Rows[e.RowIndex].DataBoundItem;
            UniSpecForm form = new UniSpecForm(this, _mainForm, spec);
            form.Show();
            form.FillUniSpecForm(spec);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            List<Speciality> savedSpecis = _mainForm.directory.SavedSpecis;
            if (BudgetGradeRadioButton.Checked)
            {
                try
                {
                    List<Speciality> bs = new List<Speciality>();
                    List<Speciality> cs = new List<Speciality>();
                    foreach (var spec in savedSpecis)
                    {
                        if (spec.Budget == "Так")
                        {
                            bs.Add(spec);
                        }
                        else if (spec.Budget == "Ні")
                        {
                            cs.Add(spec);
                        }
                    }
                    bs = bs.OrderBy(s => Convert.ToInt32(s.BudgetGrade)).ToList();
                    savedSpecis = bs.Concat(cs).ToList();
                    _mainForm.directory.SavedSpecis = savedSpecis;
                    FillSavedSpecisDataGridView();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Здається, не всі спеціальності мають можливість вступу на бюджет.\nСпочатку відмітьте поле <Тільки спеціальності з можливістю вступу на бюджет>, натисніть на кнопку <Шукати> та виконайте сортування ще раз.");
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Жодної спеціальності не було знайдено. Немає що сортувати.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невідома помилка.");
                }
            }
            else if (ContractGradeRadioButton.Checked)
            {
                try
                {
                    savedSpecis = savedSpecis.OrderBy(s => s.ContractGrade).ToList();
                    _mainForm.directory.SavedSpecis = savedSpecis;
                    FillSavedSpecisDataGridView();
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Жодної спеціальності не було знайдено. Немає що сортувати.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невідома помилка.");
                }
            }
            else if (ContractAmountRadioButton.Checked)
            {
                try
                {
                    savedSpecis = savedSpecis.OrderBy(s => s.Amount).ToList();
                    _mainForm.directory.SavedSpecis = savedSpecis;
                    FillSavedSpecisDataGridView();
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Жодної спеціальності не було знайдено. Немає що сортувати.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невідома помилка.");
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutForm form = new AboutForm(this);
            form.Show();
        }
    }
}
