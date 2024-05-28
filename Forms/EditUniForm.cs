using CourseWork.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class EditUniForm : Form
    {
        Form _previousForm;
        University university;
        MainForm _mainForm;
        string mode;
        DataGridViewRow selectedRow;
        public EditUniForm(Form prevForm, University uni, MainForm mainForm, string i)
        {
            InitializeComponent();
            _previousForm = prevForm;
            university = uni;
            _mainForm = mainForm;
            mode = i;
            if (mode == "new")
            {
                FormLabel.Text = "Додавання нового університету";
            }
            CityComboBox.Items.Add("Вінницька");
            CityComboBox.Items.Add("Волинська");
            CityComboBox.Items.Add("Дніпропетровська");
            CityComboBox.Items.Add("Донецька");
            CityComboBox.Items.Add("Житомирська");
            CityComboBox.Items.Add("Закарпатська");
            CityComboBox.Items.Add("Запорізька");
            CityComboBox.Items.Add("Івано-Франківська");
            CityComboBox.Items.Add("Київська");
            CityComboBox.Items.Add("м. Київ");
            CityComboBox.Items.Add("Кіровоградська");
            CityComboBox.Items.Add("Луганська");
            CityComboBox.Items.Add("Львівська");
            CityComboBox.Items.Add("Миколаївська");
            CityComboBox.Items.Add("Одеська");
            CityComboBox.Items.Add("Полтавська");
            CityComboBox.Items.Add("Рівненська");
            CityComboBox.Items.Add("Сумська");
            CityComboBox.Items.Add("Тернопільська");
            CityComboBox.Items.Add("Харківська");
            CityComboBox.Items.Add("Херсонська");
            CityComboBox.Items.Add("Хмельницька");
            CityComboBox.Items.Add("Черкаська");
            CityComboBox.Items.Add("Чернівецька");
            CityComboBox.Items.Add("Чернігівська");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditUniForm_Load(object sender, EventArgs e)
        {
            SpeciDataGridView.AutoGenerateColumns = false;
            SpeciDataGridView.EnableHeadersVisualStyles = false;
            SpeciDataGridView.Columns.Add("NameColumn", "Назва спеціальності");
            SpeciDataGridView.Columns.Add("EduColumn", "Форма навчання");
            if (mode == "edit")
            {
                NameTextBox.Text = university.Name;
                IdTextBox.Text = university.Id;
                CityComboBox.Text = university.City;
                HeadTextBox.Text = university.Head;
                AdressTextBox.Text = university.Adress;
                PhoneNumTextBox.Text = university.PhoneNum;
                EmailTextBox.Text = university.Email;
                IdTextBox.ReadOnly = true;

                SpeciDataGridView.DataSource = university.Specialities;
                FillSpecDataGridView();
            }

        }

        private void FillSpecDataGridView()
        {
            SpeciDataGridView.Columns["NameColumn"].DataPropertyName = "Name";
            SpeciDataGridView.Columns["EduColumn"].DataPropertyName = "EducationForm";
            foreach (DataGridViewColumn column in SpeciDataGridView.Columns)
            {
                if (column.Name != "NameColumn" && column.Name != "EduColumn")
                {
                    column.Visible = false;
                }
            }

            SpeciDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            SpeciDataGridView.DataBindingComplete += (o, args) =>
            {
                SpeciDataGridView.ClearSelection();
            };
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                if (NameTextBox.Text == "" || CityComboBox.Text == "" || IdTextBox.Text == "")
                {
                    MessageBox.Show("Невистачає даних для університету. Введіть назву, область та код ЄДБО.", "Невистачає даних");
                    return;
                }
                if (university.Specialities == null)
                {
                    MessageBox.Show("До університету не додано жодної спеціальності. Неможливо зберегти університет без спеціальностей.", "Немає спеціальностей");
                    return;
                }
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете зберегти зміни?", "Збереження змін", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    university.Name = NameTextBox.Text;
                    university.City = CityComboBox.Text;
                    university.Head = HeadTextBox.Text;
                    university.Adress = AdressTextBox.Text;
                    university.PhoneNum = PhoneNumTextBox.Text;
                    university.Email = EmailTextBox.Text;
                    _mainForm.directory.EditUni(university);

                    EditForm form = new EditForm(_mainForm);
                    form.Show();
                    this.Close();
                }
            }
            else if (mode == "new")
            {
                if (NameTextBox.Text == "" || CityComboBox.Text == "" || IdTextBox.Text == "")
                {
                    MessageBox.Show("Невистачає даних для створення університету. Введіть назву, область та код ЄДБО.", "Невистачає даних");
                    return;
                }
                if (_mainForm.directory.CheckIdUni(IdTextBox.Text))
                {
                    MessageBox.Show("Університет з таким кодом ЄДБО вже існує, будь-ласка, виберіть інший код ЄДБО.", "Невалідний код ЄДБО");
                    return;
                }
                if (university.Specialities == null)
                {
                    MessageBox.Show("До університету не додано жодної спеціальності. Неможливо зберегти університет без спеціальностей.", "Немає спеціальностей");
                    return;
                }
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете зберегти зміни?", "Збереження змін", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    university.Name = NameTextBox.Text;
                    university.City = CityComboBox.Text;
                    university.Id = IdTextBox.Text;
                    university.Head = HeadTextBox.Text;
                    university.Adress = AdressTextBox.Text;
                    university.PhoneNum = PhoneNumTextBox.Text;
                    university.Email = EmailTextBox.Text;
                    university.Specialities = new List<Speciality>();
                    _mainForm.directory.Unis.Add(university);

                    EditForm form = new EditForm(_mainForm);
                    form.Show();
                    this.Close();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm(_mainForm);
            form.Show();
            this.Close();
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddNewSpecButton_Click(object sender, EventArgs e)
        {
            Speciality spec = new Speciality();
            University uni = university;
            EditSpecForm form = new EditSpecForm(this, _mainForm, spec, uni, "new");
            form.Show();
            this.Hide();
        }

        private void SpeciDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            Speciality spec = (Speciality)SpeciDataGridView.Rows[e.RowIndex].DataBoundItem;
            University uni = university;
            EditSpecForm form = new EditSpecForm(this, _mainForm, spec, uni, "edit");
            form.Show();
            this.Hide();
        }

        private void RemoveSpecButton_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                if (university.Specialities.Count <= 1)
                {
                    MessageBox.Show("Неможна видалити усі спеціальності.", "Неможлива дія");
                    return;
                }
                DialogResult result = MessageBox.Show("Ви точно хочете видалити вибрану спеціальність?", "Підтверження видалення", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Speciality selSpec = (Speciality)selectedRow.DataBoundItem;
                    _mainForm.directory.RemoveSearchedSpec(selSpec);
                    SpeciDataGridView.DataSource = new List<Speciality>();
                    FillSpecDataGridView();
                    SpeciDataGridView.DataSource = university.Specialities;
                    FillSpecDataGridView();
                }
            }
        }

        private void SpeciDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = SpeciDataGridView.Rows[e.RowIndex];
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
