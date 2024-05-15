namespace CourseWork.Forms
{
    partial class SavedForm
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
            SavedTabControl = new TabControl();
            tabPage1 = new TabPage();
            RemoveUniButton = new Button();
            RemoveAllUniButton = new Button();
            SavedUnisDataGridView = new DataGridView();
            label1 = new Label();
            tabPage2 = new TabPage();
            RemoveSpecButton = new Button();
            RemoveAllSpecButton = new Button();
            SortButton = new Button();
            ContractAmountRadioButton = new RadioButton();
            ContractGradeRadioButton = new RadioButton();
            BudgetGradeRadioButton = new RadioButton();
            label8 = new Label();
            SavedSpecisDataGridView = new DataGridView();
            label2 = new Label();
            GoBackButton = new Button();
            menuStrip1.SuspendLayout();
            SavedTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SavedUnisDataGridView).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SavedSpecisDataGridView).BeginInit();
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
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "&About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // SavedTabControl
            // 
            SavedTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            SavedTabControl.Controls.Add(tabPage1);
            SavedTabControl.Controls.Add(tabPage2);
            SavedTabControl.Font = new Font("Segoe UI", 11F);
            SavedTabControl.Location = new Point(95, 47);
            SavedTabControl.Name = "SavedTabControl";
            SavedTabControl.SelectedIndex = 0;
            SavedTabControl.Size = new Size(931, 922);
            SavedTabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(RemoveUniButton);
            tabPage1.Controls.Add(RemoveAllUniButton);
            tabPage1.Controls.Add(SavedUnisDataGridView);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI", 11F);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(923, 884);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Збережені ЗВО";
            // 
            // RemoveUniButton
            // 
            RemoveUniButton.Location = new Point(595, 138);
            RemoveUniButton.Name = "RemoveUniButton";
            RemoveUniButton.Size = new Size(122, 35);
            RemoveUniButton.TabIndex = 26;
            RemoveUniButton.Text = "Видалити";
            RemoveUniButton.UseVisualStyleBackColor = true;
            RemoveUniButton.Click += RemoveUniButton_Click;
            // 
            // RemoveAllUniButton
            // 
            RemoveAllUniButton.Location = new Point(723, 138);
            RemoveAllUniButton.Name = "RemoveAllUniButton";
            RemoveAllUniButton.Size = new Size(147, 35);
            RemoveAllUniButton.TabIndex = 2;
            RemoveAllUniButton.Text = "Видалити все";
            RemoveAllUniButton.UseVisualStyleBackColor = true;
            RemoveAllUniButton.Click += RemoveAllUniButton_Click;
            // 
            // SavedUnisDataGridView
            // 
            SavedUnisDataGridView.AllowUserToAddRows = false;
            SavedUnisDataGridView.AllowUserToDeleteRows = false;
            SavedUnisDataGridView.AllowUserToResizeColumns = false;
            SavedUnisDataGridView.AllowUserToResizeRows = false;
            SavedUnisDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SavedUnisDataGridView.BackgroundColor = Color.White;
            SavedUnisDataGridView.BorderStyle = BorderStyle.Fixed3D;
            SavedUnisDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SavedUnisDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(137, 171, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(137, 171, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SavedUnisDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SavedUnisDataGridView.ColumnHeadersHeight = 60;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            SavedUnisDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            SavedUnisDataGridView.GridColor = SystemColors.Desktop;
            SavedUnisDataGridView.Location = new Point(53, 179);
            SavedUnisDataGridView.Name = "SavedUnisDataGridView";
            SavedUnisDataGridView.ReadOnly = true;
            SavedUnisDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            SavedUnisDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            SavedUnisDataGridView.RowHeadersVisible = false;
            SavedUnisDataGridView.RowHeadersWidth = 51;
            SavedUnisDataGridView.RowTemplate.Height = 50;
            SavedUnisDataGridView.RowTemplate.ReadOnly = true;
            SavedUnisDataGridView.Size = new Size(817, 580);
            SavedUnisDataGridView.TabIndex = 1;
            SavedUnisDataGridView.CellClick += SavedUnisDataGridView_CellClick;
            SavedUnisDataGridView.CellDoubleClick += SavedUnisDataGridView_CellDoubleClick;
            SavedUnisDataGridView.CellMouseDown += SavedUnisDataGridView_CellMouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(481, 37);
            label1.TabIndex = 0;
            label1.Text = "Ваші збережені заклади вищої освіти";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(RemoveSpecButton);
            tabPage2.Controls.Add(RemoveAllSpecButton);
            tabPage2.Controls.Add(SortButton);
            tabPage2.Controls.Add(ContractAmountRadioButton);
            tabPage2.Controls.Add(ContractGradeRadioButton);
            tabPage2.Controls.Add(BudgetGradeRadioButton);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(SavedSpecisDataGridView);
            tabPage2.Controls.Add(label2);
            tabPage2.Font = new Font("Segoe UI", 11F);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(923, 884);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Збережені спеціальності";
            // 
            // RemoveSpecButton
            // 
            RemoveSpecButton.Location = new Point(595, 111);
            RemoveSpecButton.Name = "RemoveSpecButton";
            RemoveSpecButton.Size = new Size(122, 35);
            RemoveSpecButton.TabIndex = 25;
            RemoveSpecButton.Text = "Видалити";
            RemoveSpecButton.UseVisualStyleBackColor = true;
            RemoveSpecButton.Click += RemoveSpecButton_Click;
            // 
            // RemoveAllSpecButton
            // 
            RemoveAllSpecButton.Location = new Point(723, 111);
            RemoveAllSpecButton.Name = "RemoveAllSpecButton";
            RemoveAllSpecButton.Size = new Size(147, 35);
            RemoveAllSpecButton.TabIndex = 24;
            RemoveAllSpecButton.Text = "Видалити все";
            RemoveAllSpecButton.UseVisualStyleBackColor = true;
            RemoveAllSpecButton.Click += RemoveAllSpecButton_Click;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(720, 820);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(138, 37);
            SortButton.TabIndex = 23;
            SortButton.Text = "Сортувати";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // ContractAmountRadioButton
            // 
            ContractAmountRadioButton.AutoSize = true;
            ContractAmountRadioButton.Location = new Point(226, 824);
            ContractAmountRadioButton.Name = "ContractAmountRadioButton";
            ContractAmountRadioButton.Size = new Size(201, 29);
            ContractAmountRadioButton.TabIndex = 22;
            ContractAmountRadioButton.TabStop = true;
            ContractAmountRadioButton.Text = "Вартістю контракту";
            ContractAmountRadioButton.UseVisualStyleBackColor = true;
            // 
            // ContractGradeRadioButton
            // 
            ContractGradeRadioButton.AutoSize = true;
            ContractGradeRadioButton.Location = new Point(226, 785);
            ContractGradeRadioButton.Name = "ContractGradeRadioButton";
            ContractGradeRadioButton.Size = new Size(429, 29);
            ContractGradeRadioButton.TabIndex = 21;
            ContractGradeRadioButton.TabStop = true;
            ContractGradeRadioButton.Text = "Прохідним балом минулого року на контракт";
            ContractGradeRadioButton.UseVisualStyleBackColor = true;
            // 
            // BudgetGradeRadioButton
            // 
            BudgetGradeRadioButton.AutoSize = true;
            BudgetGradeRadioButton.Location = new Point(226, 745);
            BudgetGradeRadioButton.Name = "BudgetGradeRadioButton";
            BudgetGradeRadioButton.Size = new Size(420, 29);
            BudgetGradeRadioButton.TabIndex = 20;
            BudgetGradeRadioButton.TabStop = true;
            BudgetGradeRadioButton.Text = "Прохідним балом минулого року на бюджет";
            BudgetGradeRadioButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(71, 747);
            label8.Name = "label8";
            label8.Size = new Size(129, 25);
            label8.TabIndex = 19;
            label8.Text = "Сортувати за:";
            // 
            // SavedSpecisDataGridView
            // 
            SavedSpecisDataGridView.AllowUserToAddRows = false;
            SavedSpecisDataGridView.AllowUserToDeleteRows = false;
            SavedSpecisDataGridView.AllowUserToResizeColumns = false;
            SavedSpecisDataGridView.AllowUserToResizeRows = false;
            SavedSpecisDataGridView.BackgroundColor = Color.White;
            SavedSpecisDataGridView.BorderStyle = BorderStyle.Fixed3D;
            SavedSpecisDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SavedSpecisDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(137, 171, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(137, 171, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            SavedSpecisDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            SavedSpecisDataGridView.ColumnHeadersHeight = 60;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            SavedSpecisDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            SavedSpecisDataGridView.GridColor = SystemColors.Desktop;
            SavedSpecisDataGridView.Location = new Point(53, 152);
            SavedSpecisDataGridView.Name = "SavedSpecisDataGridView";
            SavedSpecisDataGridView.ReadOnly = true;
            SavedSpecisDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            SavedSpecisDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            SavedSpecisDataGridView.RowHeadersVisible = false;
            SavedSpecisDataGridView.RowHeadersWidth = 51;
            SavedSpecisDataGridView.RowTemplate.Height = 50;
            SavedSpecisDataGridView.RowTemplate.ReadOnly = true;
            SavedSpecisDataGridView.Size = new Size(817, 580);
            SavedSpecisDataGridView.TabIndex = 2;
            SavedSpecisDataGridView.CellClick += SavedSpecisDataGridView_CellClick;
            SavedSpecisDataGridView.CellDoubleClick += SavedSpecisDataGridView_CellDoubleClick;
            SavedSpecisDataGridView.CellMouseDown += SavedSpecisDataGridView_CellMouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(24, 25);
            label2.Name = "label2";
            label2.Size = new Size(387, 37);
            label2.TabIndex = 0;
            label2.Text = "Ваші збережені спеціальності";
            // 
            // GoBackButton
            // 
            GoBackButton.Font = new Font("Segoe UI", 11F);
            GoBackButton.Location = new Point(881, 40);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(141, 33);
            GoBackButton.TabIndex = 3;
            GoBackButton.Text = "Назад";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // SavedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1116, 981);
            Controls.Add(GoBackButton);
            Controls.Add(SavedTabControl);
            Controls.Add(menuStrip1);
            Name = "SavedForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Довідник абітурієнта";
            Load += SavedForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            SavedTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SavedUnisDataGridView).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SavedSpecisDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabControl SavedTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label2;
        private Button GoBackButton;
        private DataGridView SavedUnisDataGridView;
        private DataGridView SavedSpecisDataGridView;
        private Button SortButton;
        private RadioButton ContractAmountRadioButton;
        private RadioButton ContractGradeRadioButton;
        private RadioButton BudgetGradeRadioButton;
        private Label label8;
        private Button RemoveAllUniButton;
        private Button RemoveAllSpecButton;
        private Button RemoveSpecButton;
        private Button RemoveUniButton;
    }
}