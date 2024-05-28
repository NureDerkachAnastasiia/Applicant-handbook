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
    public partial class ChangePasswordForm : Form
    {
        MainForm mainForm;
        public ChangePasswordForm(MainForm mForm)
        {
            InitializeComponent();
            mainForm = mForm;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!mainForm.directory.CheckPassword(OldPasswordTextBox.Text))
            {
                MessageBox.Show("Введено невірний старий пароль.", "Невірний пароль");
                return;
            }
            if(NewPasswordTextBox1.Text == "")
            {
                MessageBox.Show("Новий пароль не може бути пустим рядком.", "Некоректний новий пароль");
                return;
            }
            if(NewPasswordTextBox1.Text != NewPasswordTextBox2.Text)
            {
                MessageBox.Show("Нові паролі не співпадають. Спробуйте ще.", "Паролі не співпадають");
                return;
            }
            if(NewPasswordTextBox1.Text.Length < 4)
            {
                MessageBox.Show("Пароль має містити хоча б чотири символи.", "Короткий пароль");
                return;
            }
            mainForm.directory.ChangePassword(NewPasswordTextBox1.Text);
            MessageBox.Show("Пароль успішно змінено.", "Пароль змінено");
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
