using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        Directory directory = new Directory();
        List<Speciality> searchedSpecis;

        public MainForm()
        {
            InitializeComponent();
            EduFormComboBox.Items.Add("неважливо");
            EduFormComboBox.Items.Add("денна");
            EduFormComboBox.Items.Add("заочна");
            VinnytskaLabel.Cursor = Cursors.Hand;
            VolynskaLabel.Cursor = Cursors.Hand;
            DniproLabel.Cursor = Cursors.Hand;
            DonetskaLabel.Cursor = Cursors.Hand;
            ZhytomyrLabel.Cursor = Cursors.Hand;
            ZakarpatLabel.Cursor = Cursors.Hand;
            ZaporizkaLabel.Cursor = Cursors.Hand;
            IvanLabel.Cursor = Cursors.Hand;
            KyivskaLabel.Cursor = Cursors.Hand;
            MKyivLabel.Cursor = Cursors.Hand;
            KirovogradLabel.Cursor = Cursors.Hand;
            LuganskaLabel.Cursor = Cursors.Hand;
            LvivskaLabel.Cursor = Cursors.Hand;
            MykolaivLabel.Cursor = Cursors.Hand;
            OdeskaLabel.Cursor = Cursors.Hand;
            PoltavskaLabel.Cursor = Cursors.Hand;
            RivnenskaLabel.Cursor = Cursors.Hand;
            SumskaLabel.Cursor = Cursors.Hand;
            TernopilskaLabel.Cursor = Cursors.Hand;
            KharkivLabel.Cursor = Cursors.Hand;
            KhersonLabel.Cursor = Cursors.Hand;
            KhmelnytskaLabel.Cursor = Cursors.Hand;
            CherkaskaLabel.Cursor = Cursors.Hand;
            ChernivetskaLabel.Cursor = Cursors.Hand;
            ChernigivskaLabel.Cursor = Cursors.Hand;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SpecDataGridView.AutoGenerateColumns = false;
            SpecDataGridView.EnableHeadersVisualStyles = false;
            SpecDataGridView.Columns.Add("NameColumn", "Назва спеціальності");
            SpecDataGridView.Columns.Add("EduColumn", "Форма навчання");
            SpecDataGridView.Columns.Add("UniColumn", "Назва ЗВО");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchUniButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            string city = CityTextBox.Text;
            string uni = NameUniTextBox.Text;
            List<University> unis = directory.SearchUnis(uni, city);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void SearchSpeciButton_Click(object sender, EventArgs e)
        {
            string eduForm = EduFormComboBox.Text;
            string budget = BudgetCheckBox.Checked ? "Так" : "";
            if (EduFormComboBox.Text == "неважливо")
            {
                eduForm = "";
            }
            searchedSpecis = directory.SearchSpecis(NameSpeciTextBox.Text, eduForm, UniNameSpecTextBox.Text, budget);
            FillSpecDataGridView();
        }

        private void FillSpecDataGridView()
        {
            SpecDataGridView.DataSource = searchedSpecis;
            if (searchedSpecis != null)
            {
                SpecDataGridView.ColumnHeadersHeight = 70;
            }
            SpecDataGridView.Columns["NameColumn"].DataPropertyName = "Name";
            SpecDataGridView.Columns["EduColumn"].DataPropertyName = "EducationForm";
            SpecDataGridView.Columns["UniColumn"].DataPropertyName = "Uni";
            foreach (DataGridViewColumn column in SpecDataGridView.Columns)
            {
                if (column.Name != "NameColumn" && column.Name != "EduColumn" && column.Name != "UniColumn")
                {
                    column.Visible = false;
                }
            }
            SpecDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SpecDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SpecDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void SpecDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            this.Hide();
            Speciality spec = (Speciality)SpecDataGridView.Rows[e.RowIndex].DataBoundItem;
            UniSpecForm form = new UniSpecForm(this);
            form.Show();
            form.FillUniSpecForm(spec);
        }
        private void SortButton_Click(object sender, EventArgs e)
        {
            if (BudgetGradeRadioButton.Checked)
            {
                try
                {
                    searchedSpecis = searchedSpecis.OrderBy(s => Convert.ToInt32(s.BudgetGrade)).ToList();
                    FillSpecDataGridView();
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Здається, не всі спеціальності мають можливість вступу на бюджет.\nСпочатку відмітьте поле <Тільки спеціальності з можливістю вступу на бюджет>, натисніть на кнопку <Шукати> та виконайте сортування ще раз.");
                }
                catch(ArgumentNullException ex)
                {
                    MessageBox.Show("Жодної спеціальності не було знайдено. Немає що сортувати.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Невідома помилка.");
                }
            }
            else if (ContractGradeRadioButton.Checked)
            {
                try
                {
                    searchedSpecis = searchedSpecis.OrderBy(s => s.ContractGrade).ToList();
                    FillSpecDataGridView();
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Жодної спеціальності не було знайдено. Немає що сортувати.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невідома помилка.");
                }
            }
            else if (ContractAmountRadioButton.Checked)
            {
                try
                {
                    searchedSpecis = searchedSpecis.OrderBy(s => s.Amount).ToList();
                    FillSpecDataGridView();
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Жодної спеціальності не було знайдено. Немає що сортувати.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невідома помилка.");
                }
            }
        }

        private void VinnytskaLabel_MouseEnter(object sender, EventArgs e)
        {
            VinnytskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void VinnytskaLabel_MouseLeave(object sender, EventArgs e)
        {
            VinnytskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void VinnytskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = VinnytskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void VolynskaLabel_MouseEnter(object sender, EventArgs e)
        {
            VolynskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void VolynskaLabel_MouseLeave(object sender, EventArgs e)
        {
            VolynskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void VolynskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = VolynskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void DniproLabel_MouseEnter(object sender, EventArgs e)
        {
            DniproLabel.ForeColor = SystemColors.HotTrack;
        }

        private void DniproLabel_MouseLeave(object sender, EventArgs e)
        {
            DniproLabel.ForeColor = SystemColors.ControlText;
        }

        private void DniproLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = DniproLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void DonetskaLabel_MouseEnter(object sender, EventArgs e)
        {
            DonetskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void DonetskaLabel_MouseLeave(object sender, EventArgs e)
        {
            DonetskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void DonetskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = DonetskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void ZhytomyrLabel_MouseEnter(object sender, EventArgs e)
        {
            ZhytomyrLabel.ForeColor = SystemColors.HotTrack;
        }

        private void ZhytomyrLabel_MouseLeave(object sender, EventArgs e)
        {
            ZhytomyrLabel.ForeColor = SystemColors.ControlText;
        }

        private void ZhytomyrLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = ZhytomyrLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void ZakarpatLabel_MouseEnter(object sender, EventArgs e)
        {
            ZakarpatLabel.ForeColor = SystemColors.HotTrack;
        }

        private void ZakarpatLabel_MouseLeave(object sender, EventArgs e)
        {
            ZakarpatLabel.ForeColor = SystemColors.ControlText;
        }

        private void ZakarpatLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = ZakarpatLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void ZaporizkaLabel_MouseEnter(object sender, EventArgs e)
        {
            ZaporizkaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void ZaporizkaLabel_MouseLeave(object sender, EventArgs e)
        {
            ZaporizkaLabel.ForeColor = SystemColors.ControlText;
        }

        private void ZaporizkaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = ZaporizkaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void IvanLabel_MouseEnter(object sender, EventArgs e)
        {
            IvanLabel.ForeColor = SystemColors.HotTrack;
        }

        private void IvanLabel_MouseLeave(object sender, EventArgs e)
        {
            IvanLabel.ForeColor = SystemColors.ControlText;
        }

        private void IvanLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = IvanLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void KyivskaLabel_MouseEnter(object sender, EventArgs e)
        {
            KyivskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void KyivskaLabel_MouseLeave(object sender, EventArgs e)
        {
            KyivskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void KyivskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = KyivskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void MKyivLabel_MouseEnter(object sender, EventArgs e)
        {
            MKyivLabel.ForeColor = SystemColors.HotTrack;
        }

        private void MKyivLabel_MouseLeave(object sender, EventArgs e)
        {
            MKyivLabel.ForeColor = SystemColors.ControlText;
        }

        private void MKyivLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = MKyivLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void KirovogradLabel_MouseEnter(object sender, EventArgs e)
        {
            KirovogradLabel.ForeColor = SystemColors.HotTrack;
        }

        private void KirovogradLabel_MouseLeave(object sender, EventArgs e)
        {
            KirovogradLabel.ForeColor = SystemColors.ControlText;
        }

        private void KirovogradLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = KirovogradLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void LuganskaLabel_MouseEnter(object sender, EventArgs e)
        {
            LuganskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void LuganskaLabel_MouseLeave(object sender, EventArgs e)
        {
            LuganskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void LuganskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = LuganskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void LvivskaLabel_MouseEnter(object sender, EventArgs e)
        {
            LvivskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void LvivskaLabel_MouseLeave(object sender, EventArgs e)
        {
            LvivskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void LvivskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = LvivskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void MykolaivLabel_MouseEnter(object sender, EventArgs e)
        {
            MykolaivLabel.ForeColor = SystemColors.HotTrack;
        }

        private void MykolaivLabel_MouseLeave(object sender, EventArgs e)
        {
            MykolaivLabel.ForeColor = SystemColors.ControlText;
        }

        private void MykolaivLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = MykolaivLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void OdeskaLabel_MouseEnter(object sender, EventArgs e)
        {
            OdeskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void OdeskaLabel_MouseLeave(object sender, EventArgs e)
        {
            OdeskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void OdeskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = OdeskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void PoltavskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = PoltavskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void PoltavskaLabel_MouseEnter(object sender, EventArgs e)
        {
            PoltavskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void PoltavskaLabel_MouseLeave(object sender, EventArgs e)
        {
            PoltavskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void RivnenskaLabel_MouseEnter(object sender, EventArgs e)
        {
            RivnenskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void RivnenskaLabel_MouseLeave(object sender, EventArgs e)
        {
            RivnenskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void RivnenskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = RivnenskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void SumskaLabel_MouseEnter(object sender, EventArgs e)
        {
            SumskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void SumskaLabel_MouseLeave(object sender, EventArgs e)
        {
            SumskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void SumskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = SumskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void TernopilskaLabel_MouseEnter(object sender, EventArgs e)
        {
            TernopilskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void TernopilskaLabel_MouseLeave(object sender, EventArgs e)
        {
            TernopilskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void TernopilskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = TernopilskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void KharkivLabel_MouseEnter(object sender, EventArgs e)
        {
            KharkivLabel.ForeColor = SystemColors.HotTrack;
        }

        private void KharkivLabel_MouseLeave(object sender, EventArgs e)
        {
            KharkivLabel.ForeColor = SystemColors.ControlText;
        }

        private void KharkivLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = KharkivLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void KhersonLabel_MouseEnter(object sender, EventArgs e)
        {
            KhersonLabel.ForeColor = SystemColors.HotTrack;
        }

        private void KhersonLabel_MouseLeave(object sender, EventArgs e)
        {
            KhersonLabel.ForeColor = SystemColors.ControlText;
        }

        private void KhersonLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = KhersonLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void KhmelnytskaLabel_MouseEnter(object sender, EventArgs e)
        {
            KhmelnytskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void KhmelnytskaLabel_MouseLeave(object sender, EventArgs e)
        {
            KhmelnytskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void KhmelnytskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = KhmelnytskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void CherkaskaLabel_MouseEnter(object sender, EventArgs e)
        {
            CherkaskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void CherkaskaLabel_MouseLeave(object sender, EventArgs e)
        {
            CherkaskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void CherkaskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = CherkaskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void ChernivetskaLabel_MouseEnter(object sender, EventArgs e)
        {
            ChernivetskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void ChernivetskaLabel_MouseLeave(object sender, EventArgs e)
        {
            ChernivetskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void ChernivetskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = ChernivetskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void ChernigivskaLabel_MouseEnter(object sender, EventArgs e)
        {
            ChernigivskaLabel.ForeColor = SystemColors.HotTrack;
        }

        private void ChernigivskaLabel_MouseLeave(object sender, EventArgs e)
        {
            ChernigivskaLabel.ForeColor = SystemColors.ControlText;
        }

        private void ChernigivskaLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedCity = ChernigivskaLabel.Text;
            List<University> unis = directory.SearchUnis("", selectedCity);
            UniversitiesForm form = new UniversitiesForm(this, unis);
            form.Show();
        }

        private void SpecDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                SpecDataGridView.Cursor = Cursors.Hand;
            }
        }

        private void SpecDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            SpecDataGridView.Cursor = Cursors.Default;
        }

        
    }
}
