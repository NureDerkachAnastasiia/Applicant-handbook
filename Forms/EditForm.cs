using CourseWork.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class EditForm : Form
    {
        MainForm _previousForm;
        List<University> searchedUnis;
        List<Speciality> searchedSpecis;
        DataGridViewRow selectedUniRow;
        DataGridViewRow selectedSpecRow;
        public EditForm(MainForm preForm)
        {
            InitializeComponent();
            EduFormComboBox.Items.Add("неважливо");
            EduFormComboBox.Items.Add("денна");
            EduFormComboBox.Items.Add("заочна");
            CityUniComboBox.Items.Add("...");
            CityUniComboBox.Items.Add("Вінницька");
            CityUniComboBox.Items.Add("Волинська");
            CityUniComboBox.Items.Add("Дніпропетровська");
            CityUniComboBox.Items.Add("Донецька");
            CityUniComboBox.Items.Add("Житомирська");
            CityUniComboBox.Items.Add("Закарпатська");
            CityUniComboBox.Items.Add("Запорізька");
            CityUniComboBox.Items.Add("Івано-Франківська");
            CityUniComboBox.Items.Add("Київська");
            CityUniComboBox.Items.Add("м. Київ");
            CityUniComboBox.Items.Add("Кіровоградська");
            CityUniComboBox.Items.Add("Луганська");
            CityUniComboBox.Items.Add("Львівська");
            CityUniComboBox.Items.Add("Миколаївська");
            CityUniComboBox.Items.Add("Одеська");
            CityUniComboBox.Items.Add("Полтавська");
            CityUniComboBox.Items.Add("Рівненська");
            CityUniComboBox.Items.Add("Сумська");
            CityUniComboBox.Items.Add("Тернопільська");
            CityUniComboBox.Items.Add("Харківська");
            CityUniComboBox.Items.Add("Херсонська");
            CityUniComboBox.Items.Add("Хмельницька");
            CityUniComboBox.Items.Add("Черкаська");
            CityUniComboBox.Items.Add("Чернівецька");
            CityUniComboBox.Items.Add("Чернігівська");
            _previousForm = preForm;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _previousForm.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(_previousForm);
            form.Show();
        }

        private void SearchUniButton_Click(object sender, EventArgs e)
        {
            string city = CityUniComboBox.Text;
            if (city == "...")
            {
                city = "";
            }
            string uni = NameUniTextBox.Text;
            List<University> unis = _previousForm.directory.SearchUnis(uni, city);
            searchedUnis = _previousForm.directory.SearchUnis(uni, city);
            EditUnisDataGridView.DataSource = searchedUnis;
            FillEditUnisDataGridView();
        }

        private void SearchSpeciButton_Click(object sender, EventArgs e)
        {
            if (NameSpeciTextBox.Text == "" && (EduFormComboBox.Text == "" || EduFormComboBox.Text == "неважливо") && UniNameSpecTextBox.Text == "" && !BudgetCheckBox.Checked)
            {
                MessageBox.Show("Здійсніть пошук хоча б за одним з критеріїв.", "Неможливий пошук");
                return;
            }
            string eduForm = EduFormComboBox.Text;
            string budget = BudgetCheckBox.Checked ? "Так" : "";
            if (EduFormComboBox.Text == "неважливо")
            {
                eduForm = "";
            }
            searchedSpecis = _previousForm.directory.SearchSpecis(NameSpeciTextBox.Text, eduForm, UniNameSpecTextBox.Text, budget);
            FillSpecDataGridView();
            EditSpecDataGridView.DataBindingComplete += (o, args) =>
            {
                EditSpecDataGridView.ClearSelection();
            };
        }

        private void FillEditUnisDataGridView()
        {

            if (searchedUnis != null)
            {
                EditUnisDataGridView.Columns["NameColumn"].DataPropertyName = "Name";
                EditUnisDataGridView.Columns["CityColumn"].DataPropertyName = "City";
                foreach (DataGridViewColumn column in EditUnisDataGridView.Columns)
                {
                    if (column.Name != "NameColumn" && column.Name != "CityColumn")
                    {
                        column.Visible = false;
                    }
                }

                EditUnisDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                EditUnisDataGridView.CurrentCell = null;
            }
        }

        private void FillSpecDataGridView()
        {
            EditSpecDataGridView.DataSource = searchedSpecis;
            if (searchedSpecis != null)
            {
                EditSpecDataGridView.ColumnHeadersHeight = 70;
                EditSpecDataGridView.Columns["NameColumn"].DataPropertyName = "Name";
                EditSpecDataGridView.Columns["EduColumn"].DataPropertyName = "EducationForm";
                EditSpecDataGridView.Columns["UniColumn"].DataPropertyName = "Uni";
                foreach (DataGridViewColumn column in EditSpecDataGridView.Columns)
                {
                    if (column.Name != "NameColumn" && column.Name != "EduColumn" && column.Name != "UniColumn")
                    {
                        column.Visible = false;
                    }
                }
                EditSpecDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                EditSpecDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                EditSpecDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            EditUnisDataGridView.AutoGenerateColumns = false;
            EditUnisDataGridView.EnableHeadersVisualStyles = false;
            EditUnisDataGridView.Columns.Add("NameColumn", "Назва університету");
            EditUnisDataGridView.Columns.Add("CityColumn", "Область");

            EditSpecDataGridView.AutoGenerateColumns = false;
            EditSpecDataGridView.EnableHeadersVisualStyles = false;
            EditSpecDataGridView.Columns.Add("NameColumn", "Назва спеціальності");
            EditSpecDataGridView.Columns.Add("EduColumn", "Форма навчання");
            EditSpecDataGridView.Columns.Add("UniColumn", "Назва ЗВО");
        }

        private void RemoveAllUniButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете видалити усі знайдені ЗВО?", "Підтверження видалення", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var dataSource = EditUnisDataGridView.DataSource;
                EditUnisDataGridView.DataSource = new List<University>();
                _previousForm.directory.RemoveAllSearchedUnis(searchedUnis);
                searchedUnis.Clear();
                FillEditUnisDataGridView();
                EditUnisDataGridView.DataSource = dataSource;
            }
        }

        private void RemoveUniButton_Click(object sender, EventArgs e)
        {
            if (selectedUniRow != null)
            {
                DialogResult result = MessageBox.Show("Ви точно хочете видалити вибраний ЗВО?", "Підтверження видалення", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    University selUni = (University)selectedUniRow.DataBoundItem;
                    var dataSource = EditUnisDataGridView.DataSource;
                    _previousForm.directory.RemoveSearchedUni(selUni);
                    EditUnisDataGridView.DataSource = new List<University>();
                    FillEditUnisDataGridView();
                    string city = CityUniComboBox.Text;
                    if (city == "...")
                    {
                        city = "";
                    }
                    string uni = NameUniTextBox.Text;
                    List<University> unis = _previousForm.directory.SearchUnis(uni, city);
                    searchedUnis = _previousForm.directory.SearchUnis(uni, city);
                    EditUnisDataGridView.DataSource = searchedUnis;
                    FillEditUnisDataGridView();
                    selectedUniRow = null;

                }
            }
        }

        private void AddNewUniButton_Click(object sender, EventArgs e)
        {
            EditUniForm form = new EditUniForm(this, new University(), _previousForm, "new");
            form.Show();
            this.Close();
        }

        private void RemoveSpecButton_Click(object sender, EventArgs e)
        {
            if (selectedSpecRow != null)
            {
                DialogResult result = MessageBox.Show("Ви точно хочете видалити вибрану спеціальність?", "Підтверження видалення", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Speciality selSpec = (Speciality)selectedSpecRow.DataBoundItem;
                    _previousForm.directory.RemoveSearchedSpec(selSpec);
                    EditSpecDataGridView.DataSource = new List<Speciality>();
                    FillSpecDataGridView();
                    string eduForm = EduFormComboBox.Text;
                    string budget = BudgetCheckBox.Checked ? "Так" : "";
                    if (EduFormComboBox.Text == "неважливо")
                    {
                        eduForm = "";
                    }
                    searchedSpecis = _previousForm.directory.SearchSpecis(NameSpeciTextBox.Text, eduForm, UniNameSpecTextBox.Text, budget);
                    FillSpecDataGridView();
                    EditSpecDataGridView.DataBindingComplete += (o, args) =>
                    {
                        EditSpecDataGridView.ClearSelection();
                    };
                    selectedSpecRow = null;
                }
            }
        }

        private void EditUnisDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUniRow = EditUnisDataGridView.Rows[e.RowIndex];
            }
        }

        private void EditSpecDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedSpecRow = EditSpecDataGridView.Rows[e.RowIndex];
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditUnisDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            University uni = (University)EditUnisDataGridView.Rows[e.RowIndex].DataBoundItem;
            EditUniForm form = new EditUniForm(this, uni, _previousForm, "edit");
            form.Show();
            this.Close();
        }

        private void EditSpecDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            Speciality spec = (Speciality)EditSpecDataGridView.Rows[e.RowIndex].DataBoundItem;
            University uni = _previousForm.directory.FindUni(spec);
            EditSpecForm form = new EditSpecForm(this, _previousForm, spec, uni, "edit");
            form.Show();
            this.Close();
        }

        private void RemoveAllSpecButton_Click_1(object sender, EventArgs e)
        {
            if (searchedSpecis == null)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Ви точно хочете видалити усі знайдені спеціальності?", "Підтверження видалення", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var dataSource = EditSpecDataGridView.DataSource;
                EditSpecDataGridView.DataSource = new List<Speciality>();
                _previousForm.directory.RemoveAllSearchedSpecis(searchedSpecis);
                searchedSpecis.Clear();
                FillSpecDataGridView();
                EditSpecDataGridView.DataSource = dataSource;
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
