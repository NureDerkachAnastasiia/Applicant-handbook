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
    public partial class InfoForm : Form
    {
        private MainForm _previousForm;
        private UniversitiesForm _form;
        public InfoForm(MainForm previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
        }

        public InfoForm(UniversitiesForm previousForm)
        {
            InitializeComponent();
            _form = previousForm;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _previousForm.Show();
        }
    }
}
