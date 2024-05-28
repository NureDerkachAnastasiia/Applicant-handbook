namespace CourseWork
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            EditTabControl = new TabControl();
            tabPage1 = new TabPage();
            AddNewUniButton = new Button();
            RemoveUniButton = new Button();
            CityUniComboBox = new ComboBox();
            RemoveAllUniButton = new Button();
            EditUnisDataGridView = new DataGridView();
            SearchUniButton = new Button();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            NameUniTextBox = new TextBox();
            tabPage2 = new TabPage();
            RemoveAllSpecButton = new Button();
            RemoveSpecButton = new Button();
            BudgetCheckBox = new CheckBox();
            label2 = new Label();
            EditSpecDataGridView = new DataGridView();
            EduFormComboBox = new ComboBox();
            label7 = new Label();
            UniNameSpecTextBox = new TextBox();
            NameSpeciTextBox = new TextBox();
            label6 = new Label();
            SearchSpeciButton = new Button();
            label5 = new Label();
            ExitButton = new Button();
            ChangePasswordButton = new Button();
            menuStrip1.SuspendLayout();
            EditTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditUnisDataGridView).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditSpecDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(137, 171, 255);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1116, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "&Файл";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(129, 26);
            exitToolStripMenuItem.Text = "В&ихід";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(94, 24);
            helpToolStripMenuItem.Text = "&Допомога";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "&Про програму";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // EditTabControl
            // 
            EditTabControl.Controls.Add(tabPage1);
            EditTabControl.Controls.Add(tabPage2);
            EditTabControl.Location = new Point(95, 47);
            EditTabControl.Name = "EditTabControl";
            EditTabControl.SelectedIndex = 0;
            EditTabControl.Size = new Size(931, 922);
            EditTabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(AddNewUniButton);
            tabPage1.Controls.Add(RemoveUniButton);
            tabPage1.Controls.Add(CityUniComboBox);
            tabPage1.Controls.Add(RemoveAllUniButton);
            tabPage1.Controls.Add(EditUnisDataGridView);
            tabPage1.Controls.Add(SearchUniButton);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(NameUniTextBox);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(923, 884);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Редагування ЗВО";
            // 
            // AddNewUniButton
            // 
            AddNewUniButton.Location = new Point(442, 808);
            AddNewUniButton.Name = "AddNewUniButton";
            AddNewUniButton.Size = new Size(153, 35);
            AddNewUniButton.TabIndex = 29;
            AddNewUniButton.Text = "Додати новий";
            AddNewUniButton.UseVisualStyleBackColor = true;
            AddNewUniButton.Click += AddNewUniButton_Click;
            // 
            // RemoveUniButton
            // 
            RemoveUniButton.Location = new Point(601, 808);
            RemoveUniButton.Name = "RemoveUniButton";
            RemoveUniButton.Size = new Size(122, 35);
            RemoveUniButton.TabIndex = 28;
            RemoveUniButton.Text = "Видалити";
            RemoveUniButton.UseVisualStyleBackColor = true;
            RemoveUniButton.Click += RemoveUniButton_Click;
            // 
            // CityUniComboBox
            // 
            CityUniComboBox.FormattingEnabled = true;
            CityUniComboBox.Location = new Point(249, 106);
            CityUniComboBox.Name = "CityUniComboBox";
            CityUniComboBox.Size = new Size(627, 33);
            CityUniComboBox.TabIndex = 11;
            // 
            // RemoveAllUniButton
            // 
            RemoveAllUniButton.Location = new Point(729, 808);
            RemoveAllUniButton.Name = "RemoveAllUniButton";
            RemoveAllUniButton.Size = new Size(147, 35);
            RemoveAllUniButton.TabIndex = 27;
            RemoveAllUniButton.Text = "Видалити все";
            RemoveAllUniButton.UseVisualStyleBackColor = true;
            RemoveAllUniButton.Click += RemoveAllUniButton_Click;
            // 
            // EditUnisDataGridView
            // 
            EditUnisDataGridView.AllowUserToAddRows = false;
            EditUnisDataGridView.AllowUserToDeleteRows = false;
            EditUnisDataGridView.AllowUserToResizeColumns = false;
            EditUnisDataGridView.AllowUserToResizeRows = false;
            EditUnisDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EditUnisDataGridView.BackgroundColor = Color.White;
            EditUnisDataGridView.BorderStyle = BorderStyle.Fixed3D;
            EditUnisDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EditUnisDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(137, 171, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(137, 171, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EditUnisDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EditUnisDataGridView.ColumnHeadersHeight = 60;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EditUnisDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            EditUnisDataGridView.GridColor = SystemColors.Desktop;
            EditUnisDataGridView.Location = new Point(59, 249);
            EditUnisDataGridView.Name = "EditUnisDataGridView";
            EditUnisDataGridView.ReadOnly = true;
            EditUnisDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            EditUnisDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            EditUnisDataGridView.RowHeadersVisible = false;
            EditUnisDataGridView.RowHeadersWidth = 51;
            EditUnisDataGridView.RowTemplate.Height = 50;
            EditUnisDataGridView.RowTemplate.ReadOnly = true;
            EditUnisDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EditUnisDataGridView.Size = new Size(817, 553);
            EditUnisDataGridView.TabIndex = 3;
            EditUnisDataGridView.CellClick += EditUnisDataGridView_CellClick;
            EditUnisDataGridView.CellDoubleClick += EditUnisDataGridView_CellDoubleClick;
            // 
            // SearchUniButton
            // 
            SearchUniButton.Location = new Point(761, 209);
            SearchUniButton.Name = "SearchUniButton";
            SearchUniButton.Size = new Size(115, 34);
            SearchUniButton.TabIndex = 9;
            SearchUniButton.Text = "Шукати";
            SearchUniButton.UseVisualStyleBackColor = true;
            SearchUniButton.Click += SearchUniButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(31, 31);
            label1.Name = "label1";
            label1.Size = new Size(424, 37);
            label1.TabIndex = 0;
            label1.Text = "Редагувати інформацію про ЗВО";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 109);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 10;
            label4.Text = "Область:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 161);
            label3.Name = "label3";
            label3.Size = new Size(183, 25);
            label3.TabIndex = 8;
            label3.Text = "Назва університету:";
            // 
            // NameUniTextBox
            // 
            NameUniTextBox.BackColor = Color.FromArgb(234, 243, 249);
            NameUniTextBox.Location = new Point(249, 158);
            NameUniTextBox.Name = "NameUniTextBox";
            NameUniTextBox.Size = new Size(627, 32);
            NameUniTextBox.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(RemoveAllSpecButton);
            tabPage2.Controls.Add(RemoveSpecButton);
            tabPage2.Controls.Add(BudgetCheckBox);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(EditSpecDataGridView);
            tabPage2.Controls.Add(EduFormComboBox);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(UniNameSpecTextBox);
            tabPage2.Controls.Add(NameSpeciTextBox);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(SearchSpeciButton);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(923, 884);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Редагування спеціальностей";
            // 
            // RemoveAllSpecButton
            // 
            RemoveAllSpecButton.Location = new Point(711, 807);
            RemoveAllSpecButton.Name = "RemoveAllSpecButton";
            RemoveAllSpecButton.Size = new Size(147, 35);
            RemoveAllSpecButton.TabIndex = 28;
            RemoveAllSpecButton.Text = "Видалити все";
            RemoveAllSpecButton.UseVisualStyleBackColor = true;
            RemoveAllSpecButton.Click += RemoveAllSpecButton_Click_1;
            // 
            // RemoveSpecButton
            // 
            RemoveSpecButton.Location = new Point(583, 807);
            RemoveSpecButton.Name = "RemoveSpecButton";
            RemoveSpecButton.Size = new Size(122, 35);
            RemoveSpecButton.TabIndex = 27;
            RemoveSpecButton.Text = "Видалити";
            RemoveSpecButton.UseVisualStyleBackColor = true;
            RemoveSpecButton.Click += RemoveSpecButton_Click;
            // 
            // BudgetCheckBox
            // 
            BudgetCheckBox.AutoSize = true;
            BudgetCheckBox.Location = new Point(71, 236);
            BudgetCheckBox.Name = "BudgetCheckBox";
            BudgetCheckBox.Size = new Size(498, 29);
            BudgetCheckBox.TabIndex = 14;
            BudgetCheckBox.Text = "Тільки спеціальності з можливістю вступу на бюджет";
            BudgetCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(31, 31);
            label2.Name = "label2";
            label2.Size = new Size(543, 37);
            label2.TabIndex = 0;
            label2.Text = "Редагувати інформацію про спеціальності";
            // 
            // EditSpecDataGridView
            // 
            EditSpecDataGridView.AllowUserToAddRows = false;
            EditSpecDataGridView.AllowUserToDeleteRows = false;
            EditSpecDataGridView.AllowUserToResizeColumns = false;
            EditSpecDataGridView.AllowUserToResizeRows = false;
            EditSpecDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EditSpecDataGridView.BackgroundColor = Color.White;
            EditSpecDataGridView.BorderStyle = BorderStyle.Fixed3D;
            EditSpecDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EditSpecDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(137, 171, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(137, 171, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            EditSpecDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            EditSpecDataGridView.ColumnHeadersHeight = 60;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            EditSpecDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            EditSpecDataGridView.GridColor = SystemColors.Desktop;
            EditSpecDataGridView.Location = new Point(57, 319);
            EditSpecDataGridView.Name = "EditSpecDataGridView";
            EditSpecDataGridView.ReadOnly = true;
            EditSpecDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            EditSpecDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            EditSpecDataGridView.RowHeadersVisible = false;
            EditSpecDataGridView.RowHeadersWidth = 51;
            EditSpecDataGridView.RowTemplate.Height = 50;
            EditSpecDataGridView.RowTemplate.ReadOnly = true;
            EditSpecDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EditSpecDataGridView.Size = new Size(801, 482);
            EditSpecDataGridView.TabIndex = 16;
            EditSpecDataGridView.CellClick += EditSpecDataGridView_CellClick;
            EditSpecDataGridView.CellDoubleClick += EditSpecDataGridView_CellDoubleClick;
            // 
            // EduFormComboBox
            // 
            EduFormComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EduFormComboBox.FormattingEnabled = true;
            EduFormComboBox.Location = new Point(684, 123);
            EduFormComboBox.Name = "EduFormComboBox";
            EduFormComboBox.Size = new Size(151, 33);
            EduFormComboBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 126);
            label7.Name = "label7";
            label7.Size = new Size(192, 25);
            label7.TabIndex = 11;
            label7.Text = "Назва спеціальності:";
            // 
            // UniNameSpecTextBox
            // 
            UniNameSpecTextBox.BackColor = Color.FromArgb(234, 243, 249);
            UniNameSpecTextBox.Location = new Point(236, 174);
            UniNameSpecTextBox.Name = "UniNameSpecTextBox";
            UniNameSpecTextBox.Size = new Size(599, 32);
            UniNameSpecTextBox.TabIndex = 12;
            // 
            // NameSpeciTextBox
            // 
            NameSpeciTextBox.BackColor = Color.FromArgb(234, 243, 249);
            NameSpeciTextBox.Location = new Point(236, 123);
            NameSpeciTextBox.Name = "NameSpeciTextBox";
            NameSpeciTextBox.Size = new Size(243, 32);
            NameSpeciTextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 176);
            label6.Name = "label6";
            label6.Size = new Size(183, 25);
            label6.TabIndex = 18;
            label6.Text = "Назва університету:";
            // 
            // SearchSpeciButton
            // 
            SearchSpeciButton.Location = new Point(720, 276);
            SearchSpeciButton.Name = "SearchSpeciButton";
            SearchSpeciButton.Size = new Size(115, 37);
            SearchSpeciButton.TabIndex = 15;
            SearchSpeciButton.Text = "Шукати";
            SearchSpeciButton.UseVisualStyleBackColor = true;
            SearchSpeciButton.Click += SearchSpeciButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(514, 126);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 17;
            label5.Text = "Форма навчання:";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(927, 40);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 32);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Вийти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Location = new Point(762, 40);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(159, 32);
            ChangePasswordButton.TabIndex = 4;
            ChangePasswordButton.Text = "Змінити пароль";
            ChangePasswordButton.UseVisualStyleBackColor = true;
            ChangePasswordButton.Click += ChangePasswordButton_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1116, 981);
            Controls.Add(ChangePasswordButton);
            Controls.Add(ExitButton);
            Controls.Add(EditTabControl);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Режим редагування";
            Load += EditForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            EditTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EditUnisDataGridView).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EditSpecDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabControl EditTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label2;
        private Button SearchUniButton;
        private Label label4;
        private Label label3;
        private TextBox NameUniTextBox;
        private DataGridView EditUnisDataGridView;
        private CheckBox BudgetCheckBox;
        private DataGridView EditSpecDataGridView;
        private ComboBox EduFormComboBox;
        private Label label7;
        private TextBox UniNameSpecTextBox;
        private TextBox NameSpeciTextBox;
        private Label label6;
        private Button SearchSpeciButton;
        private Label label5;
        private Button ExitButton;
        private Button ChangePasswordButton;
        private ComboBox CityUniComboBox;
        private Button RemoveUniButton;
        private Button RemoveAllUniButton;
        private Button AddNewUniButton;
        private Button RemoveSpecButton;
        private Button RemoveAllSpecButton;
    }
}