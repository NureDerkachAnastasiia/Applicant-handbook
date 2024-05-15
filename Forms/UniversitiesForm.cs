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
    public partial class UniversitiesForm : Form
    {
        private List<University> universities;
        private MainForm _previousForm;
        public UniversitiesForm(MainForm previousForm, List<University> unis)
        {
            InitializeComponent();
            _previousForm = previousForm;
            universities = unis;

            UniDataGridView.DataSource = universities;
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

        private void UniversitiesForm_Load(object sender, EventArgs e)
        {
            UniDataGridView.AutoGenerateColumns = false;
            UniDataGridView.EnableHeadersVisualStyles = false;
            UniDataGridView.Columns.Add("NameColumn", "Назва університету");
            UniDataGridView.Columns.Add("CityColumn", "Область");

            UniDataGridView.Columns["NameColumn"].DataPropertyName = "Name";
            UniDataGridView.Columns["CityColumn"].DataPropertyName = "City";
            foreach (DataGridViewColumn column in UniDataGridView.Columns)
            {
                if (column.Name != "NameColumn" && column.Name != "CityColumn")
                {
                    column.Visible = false;
                }
            }

            UniDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void UniDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            this.Hide();
            University uni = (University)UniDataGridView.Rows[e.RowIndex].DataBoundItem;
            InfoUniForm form = new InfoUniForm(this, uni, _previousForm);
            form.Show();
            form.FillInfoUniForm(uni);
        }

        private void UniDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                UniDataGridView.Cursor = Cursors.Hand;
            }
        }

        private void UniDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            UniDataGridView.Cursor = Cursors.Default;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutForm form = new AboutForm(this);
            form.Show();
        }
    }
}
