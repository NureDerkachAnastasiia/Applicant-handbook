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
    public partial class UniSpecForm : Form
    {
        Form _previousForm;
        MainForm _mainForm;
        Speciality speciality;

        public UniSpecForm(Form form, MainForm mainForm, Speciality spec)
        {
            InitializeComponent();
            _previousForm = form;
            _mainForm = mainForm;
            speciality = spec;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void FillUniSpecForm(Speciality spec)
        {
            NameSpecLabel.Text = spec.Name;
            NameUniLabel.Text = spec.Uni;
            EduFormLabel.Text = spec.EducationForm;
            BudgetLabel.Text = spec.Budget;
            AmountLabel.Text = spec.Amount.ToString();
            BudgetGradeLabel.Text = spec.BudgetGrade;
            ContractGradeLabel.Text = spec.ContractGrade.ToString();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _previousForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_previousForm is SavedForm || _mainForm.directory.ContainsSpec(speciality))
            {
                SavedLabel.Text = "Спеціальність збережено.";
                return;
            }
            _mainForm.directory.AddToSavedSpecis(speciality);
            SavedLabel.Text = "Спеціальність збережено.";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutForm form = new AboutForm(this);
            form.Show();
        }
    }
}
