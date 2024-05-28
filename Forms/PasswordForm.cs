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
    public partial class PasswordForm : Form
    {
        MainForm _previousForm;
        public PasswordForm(MainForm preForm)
        {
            InitializeComponent();
            _previousForm = preForm;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (_previousForm.directory.CheckPassword(PasswordTextBox.Text))
            {
                EditForm form = new EditForm(_previousForm);
                form.Show();
                this.Close();
                _previousForm.Hide();
            }
            else
            {
                MessageBox.Show("Невірний пароль. Спробуйте ще раз.", "Невірний пароль");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _previousForm.Show();
        }
    }
}
