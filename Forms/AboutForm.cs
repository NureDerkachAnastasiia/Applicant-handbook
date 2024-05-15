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
    public partial class AboutForm : Form
    {
        Form _previousForm;
        public AboutForm(Form pForm)
        {
            InitializeComponent();
            _previousForm = pForm;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _previousForm.Show();
        }
    }
}
