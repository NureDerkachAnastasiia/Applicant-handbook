namespace CourseWork
{
    partial class EditSpecForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            BudgetComboBox = new ComboBox();
            NameUniComboBox = new ComboBox();
            EduFormComboBox = new ComboBox();
            label8 = new Label();
            ContractGradeTextBox = new TextBox();
            BudgetGradeTextBox = new TextBox();
            AmountTextBox = new TextBox();
            NameSpecTextBox = new TextBox();
            FormLabel = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            OkButton = new Button();
            CancelButton = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(137, 171, 255);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1116, 28);
            menuStrip1.TabIndex = 3;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BudgetComboBox);
            panel1.Controls.Add(NameUniComboBox);
            panel1.Controls.Add(EduFormComboBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(ContractGradeTextBox);
            panel1.Controls.Add(BudgetGradeTextBox);
            panel1.Controls.Add(AmountTextBox);
            panel1.Controls.Add(NameSpecTextBox);
            panel1.Controls.Add(FormLabel);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(94, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 891);
            panel1.TabIndex = 4;
            // 
            // BudgetComboBox
            // 
            BudgetComboBox.FormattingEnabled = true;
            BudgetComboBox.Location = new Point(431, 228);
            BudgetComboBox.Name = "BudgetComboBox";
            BudgetComboBox.Size = new Size(394, 33);
            BudgetComboBox.TabIndex = 35;
            // 
            // NameUniComboBox
            // 
            NameUniComboBox.FormattingEnabled = true;
            NameUniComboBox.Location = new Point(431, 151);
            NameUniComboBox.Name = "NameUniComboBox";
            NameUniComboBox.Size = new Size(394, 33);
            NameUniComboBox.TabIndex = 34;
            // 
            // EduFormComboBox
            // 
            EduFormComboBox.FormattingEnabled = true;
            EduFormComboBox.Location = new Point(431, 190);
            EduFormComboBox.Name = "EduFormComboBox";
            EduFormComboBox.Size = new Size(394, 33);
            EduFormComboBox.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 193);
            label8.Name = "label8";
            label8.Size = new Size(164, 25);
            label8.TabIndex = 32;
            label8.Text = "Форма навчання:";
            // 
            // ContractGradeTextBox
            // 
            ContractGradeTextBox.BackColor = Color.FromArgb(234, 243, 249);
            ContractGradeTextBox.Location = new Point(431, 345);
            ContractGradeTextBox.Name = "ContractGradeTextBox";
            ContractGradeTextBox.Size = new Size(394, 32);
            ContractGradeTextBox.TabIndex = 27;
            ContractGradeTextBox.KeyPress += ContractGradeTextBox_KeyPress;
            // 
            // BudgetGradeTextBox
            // 
            BudgetGradeTextBox.BackColor = Color.FromArgb(234, 243, 249);
            BudgetGradeTextBox.Location = new Point(431, 306);
            BudgetGradeTextBox.Name = "BudgetGradeTextBox";
            BudgetGradeTextBox.Size = new Size(394, 32);
            BudgetGradeTextBox.TabIndex = 26;
            BudgetGradeTextBox.KeyPress += BudgetGradeTextBox_KeyPress;
            // 
            // AmountTextBox
            // 
            AmountTextBox.BackColor = Color.FromArgb(234, 243, 249);
            AmountTextBox.Location = new Point(431, 267);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(394, 32);
            AmountTextBox.TabIndex = 25;
            AmountTextBox.KeyPress += AmountTextBox_KeyPress;
            // 
            // NameSpecTextBox
            // 
            NameSpecTextBox.BackColor = Color.FromArgb(234, 243, 249);
            NameSpecTextBox.Location = new Point(431, 111);
            NameSpecTextBox.Name = "NameSpecTextBox";
            NameSpecTextBox.Size = new Size(394, 32);
            NameSpecTextBox.TabIndex = 22;
            // 
            // FormLabel
            // 
            FormLabel.AutoSize = true;
            FormLabel.Font = new Font("Segoe UI", 16F);
            FormLabel.Location = new Point(34, 33);
            FormLabel.Name = "FormLabel";
            FormLabel.Size = new Size(348, 37);
            FormLabel.TabIndex = 0;
            FormLabel.Text = "Редагування спеціальності";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(54, 348);
            label7.Name = "label7";
            label7.Size = new Size(343, 25);
            label7.TabIndex = 20;
            label7.Text = "Прохідний бал 2023 року на контракт:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(54, 270);
            label5.Name = "label5";
            label5.Size = new Size(273, 25);
            label5.TabIndex = 18;
            label5.Text = "Вартість на рік за контрактом:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(54, 309);
            label6.Name = "label6";
            label6.Size = new Size(334, 25);
            label6.TabIndex = 19;
            label6.Text = "Прохідний бал 2023 року на бюджет:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(54, 114);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 15;
            label2.Text = "Назва спеціальності:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(54, 154);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 16;
            label3.Text = "Назва ЗВО:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(54, 231);
            label4.Name = "label4";
            label4.Size = new Size(281, 25);
            label4.TabIndex = 17;
            label4.Text = "Можливість вступу на бюджет:";
            // 
            // OkButton
            // 
            OkButton.Location = new Point(918, 937);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(107, 32);
            OkButton.TabIndex = 6;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(805, 937);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(107, 32);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditSpecForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1116, 981);
            Controls.Add(OkButton);
            Controls.Add(CancelButton);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "EditSpecForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редагування спеціальності";
            Load += EditSpecForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panel1;
        private ComboBox EduFormComboBox;
        private Label label8;
        private Button AddNewSpecButton;
        private TextBox ContractGradeTextBox;
        private Button RemoveSpecButton;
        private TextBox BudgetGradeTextBox;
        private Button RemoveAllSpecButton;
        private TextBox AmountTextBox;
        private TextBox HeadTextBox;
        private TextBox IdTextBox;
        private TextBox NameSpecTextBox;
        private DataGridView SpeciDataGridView;
        private Label FormLabel;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox BudgetComboBox;
        private ComboBox NameUniComboBox;
        private Button OkButton;
        private Button CancelButton;
    }
}