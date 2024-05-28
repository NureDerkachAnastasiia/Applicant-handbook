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
    public partial class EditSpecForm : Form
    {
        Form _previousForm;
        MainForm _mainForm;
        University university;
        Speciality speciality;
        string mode;

        public EditSpecForm(Form preForm, MainForm mainForm, Speciality spec, University uni, string i)
        {
            InitializeComponent();
            _previousForm = preForm;
            _mainForm = mainForm;
            university = uni;
            speciality = spec;
            mode = i;

            EduFormComboBox.Items.Add("денна");
            EduFormComboBox.Items.Add("заочна");
            BudgetComboBox.Items.Add("Так");
            BudgetComboBox.Items.Add("Ні");
            foreach (var u in _mainForm.directory.Unis)
            {
                NameUniComboBox.Items.Add(u.Name);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditSpecForm_Load(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                NameSpecTextBox.Text = speciality.Name;
                NameUniComboBox.Text = speciality.Uni;
                EduFormComboBox.Text = speciality.EducationForm;
                BudgetComboBox.Text = speciality.Budget;
                AmountTextBox.Text = speciality.Amount.ToString();
                BudgetGradeTextBox.Text = speciality.BudgetGrade;
                ContractGradeTextBox.Text = speciality.ContractGrade.ToString();
                NameUniComboBox.Enabled = false;

            }
            else if (mode == "new")
            {
                FormLabel.Text = "Додавання спеціальності";
                NameUniComboBox.Text = university.Name;
                NameUniComboBox.Enabled = false;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                if (NameSpecTextBox.Text == "" || NameUniComboBox.Text == "" || EduFormComboBox.Text == "" || BudgetComboBox.Text == "" || AmountTextBox.Text == "" || BudgetGradeTextBox.Text == "" || ContractGradeTextBox.Text == "")
                {
                    MessageBox.Show("Невистачає даних щоб зберегти спеціальність. Будь ласка, заповніть усі поля.", "Невистачає даних");
                    return;
                }
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете зберегти зміни?", "Збереження змін", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    /*speciality.Name = NameSpecTextBox.Text;
                    speciality.Uni = NameUniComboBox.Text;
                    speciality.EducationForm = EduFormComboBox.Text;
                    speciality.Budget = BudgetComboBox.Text;
                    speciality.Amount = int.Parse(AmountTextBox.Text);
                    speciality.BudgetGrade = BudgetGradeTextBox.Text;
                    speciality.ContractGrade = int.Parse(ContractGradeTextBox.Text);
                    _mainForm.directory.EditSpec(speciality);*/

                    foreach(var u in _mainForm.directory.Unis)
                    {
                        foreach(var s in u.Specialities)
                        {
                            if (s.Equals(speciality))
                            {
                                s.Name = NameSpecTextBox.Text;
                                s.EducationForm = EduFormComboBox.Text;
                                s.Budget = BudgetComboBox.Text;
                                s.Amount = int.Parse(AmountTextBox.Text);
                                s.BudgetGrade = BudgetGradeTextBox.Text;
                                s.ContractGrade = int.Parse(ContractGradeTextBox.Text);
                                break;
                            }
                        }
                    }
                    foreach (var u in _mainForm.directory.SavedUnis)
                    {
                        foreach (var s in u.Specialities)
                        {
                            if (s.Equals(speciality))
                            {
                                s.Name = NameSpecTextBox.Text;
                                s.EducationForm = EduFormComboBox.Text;
                                s.Budget = BudgetComboBox.Text;
                                s.Amount = int.Parse(AmountTextBox.Text);
                                s.BudgetGrade = BudgetGradeTextBox.Text;
                                s.ContractGrade = int.Parse(ContractGradeTextBox.Text);
                                break;
                            }
                        }
                    }
                    foreach(var s in _mainForm.directory.SavedSpecis)
                    {
                        if (s.Equals(speciality))
                        {
                            s.Name = NameSpecTextBox.Text;
                            s.EducationForm = EduFormComboBox.Text;
                            s.Budget = BudgetComboBox.Text;
                            s.Amount = int.Parse(AmountTextBox.Text);
                            s.BudgetGrade = BudgetGradeTextBox.Text;
                            s.ContractGrade = int.Parse(ContractGradeTextBox.Text);
                            break;
                        }
                    }

                    if (_previousForm is EditForm)
                    {
                        EditForm form = new EditForm(_mainForm);
                        form.Show();
                        this.Close();
                        return;
                    }
                    _previousForm.Show();
                    this.Close();
                }

            }
            else if (mode == "new")
            {
                if (NameSpecTextBox.Text == "" || NameUniComboBox.Text == "" || EduFormComboBox.Text == "" || BudgetComboBox.Text == "" || AmountTextBox.Text == "" || BudgetGradeTextBox.Text == "" || ContractGradeTextBox.Text == "")
                {
                    MessageBox.Show("Невистачає даних щоб зберегти спеціальність. Будь ласка, заповніть усі поля.", "Невистачає даних");
                    return;
                }
                if (_mainForm.directory.CheckSpec(NameSpecTextBox.Text, NameUniComboBox.Text, EduFormComboBox.Text))
                {
                    MessageBox.Show("Така спеціальність вже існує. Змініть назву, ЗВО або форму навчання.", "Невалідна спеціальність");
                }
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете зберегти зміни?", "Збереження змін", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    speciality.Name = NameSpecTextBox.Text;
                    speciality.Uni = NameUniComboBox.Text;
                    speciality.EducationForm = EduFormComboBox.Text;
                    speciality.Budget = BudgetComboBox.Text;
                    speciality.Amount = int.Parse(AmountTextBox.Text);
                    speciality.BudgetGrade = BudgetGradeTextBox.Text;
                    speciality.ContractGrade = int.Parse(ContractGradeTextBox.Text);
                    _mainForm.directory.AddSpecToUni(university, speciality);

                    if (_previousForm is EditForm)
                    {
                        EditForm form = new EditForm(_mainForm);
                        form.Show();
                        this.Close();
                        return;
                    }
                    _previousForm.Show();
                    this.Close();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (_previousForm is EditForm)
            {
                EditForm form = new EditForm(_mainForm);
                form.Show();
                this.Close();
                return;
            }
            _previousForm.Show();
            this.Close();
        }

        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BudgetGradeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ContractGradeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
