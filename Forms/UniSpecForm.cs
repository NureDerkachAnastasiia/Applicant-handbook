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
        InfoUniForm _preInfoUniForm;
        MainForm _preMainForm;
        public UniSpecForm(InfoUniForm preInfoUniForm)
        {
            InitializeComponent();
            _preInfoUniForm = preInfoUniForm;
        }

        public UniSpecForm(MainForm preMainForm)
        {
            InitializeComponent();
            _preMainForm = preMainForm;
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
            if(_preMainForm != null)
            {
                _preMainForm.Show();
                return;
            }
            _preInfoUniForm.Show();
        }
    }
}
