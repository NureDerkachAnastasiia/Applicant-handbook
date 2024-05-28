namespace CourseWork
{
    partial class UniSpecForm
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
            SavedLabel = new Label();
            SaveButton = new Button();
            NameUniLabel = new Label();
            ContractGradeLabel = new Label();
            BudgetGradeLabel = new Label();
            AmountLabel = new Label();
            EduFormLabel = new Label();
            BudgetLabel = new Label();
            NameSpecLabel = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            GoBackButton = new Button();
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
            exitToolStripMenuItem.Size = new Size(224, 26);
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
            panel1.Controls.Add(SavedLabel);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(NameUniLabel);
            panel1.Controls.Add(ContractGradeLabel);
            panel1.Controls.Add(BudgetGradeLabel);
            panel1.Controls.Add(AmountLabel);
            panel1.Controls.Add(EduFormLabel);
            panel1.Controls.Add(BudgetLabel);
            panel1.Controls.Add(NameSpecLabel);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(95, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 891);
            panel1.TabIndex = 4;
            // 
            // SavedLabel
            // 
            SavedLabel.AutoSize = true;
            SavedLabel.Location = new Point(51, 536);
            SavedLabel.Name = "SavedLabel";
            SavedLabel.Size = new Size(0, 20);
            SavedLabel.TabIndex = 17;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 11F);
            SaveButton.Location = new Point(51, 495);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(112, 38);
            SaveButton.TabIndex = 16;
            SaveButton.Text = "Зберегти";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // NameUniLabel
            // 
            NameUniLabel.AutoSize = true;
            NameUniLabel.Font = new Font("Segoe UI", 11F);
            NameUniLabel.Location = new Point(418, 192);
            NameUniLabel.Name = "NameUniLabel";
            NameUniLabel.Size = new Size(23, 25);
            NameUniLabel.TabIndex = 15;
            NameUniLabel.Text = "n";
            // 
            // ContractGradeLabel
            // 
            ContractGradeLabel.AutoSize = true;
            ContractGradeLabel.Font = new Font("Segoe UI", 11F);
            ContractGradeLabel.Location = new Point(418, 442);
            ContractGradeLabel.Name = "ContractGradeLabel";
            ContractGradeLabel.Size = new Size(23, 25);
            ContractGradeLabel.TabIndex = 14;
            ContractGradeLabel.Text = "n";
            // 
            // BudgetGradeLabel
            // 
            BudgetGradeLabel.AutoSize = true;
            BudgetGradeLabel.Font = new Font("Segoe UI", 11F);
            BudgetGradeLabel.Location = new Point(418, 393);
            BudgetGradeLabel.Name = "BudgetGradeLabel";
            BudgetGradeLabel.Size = new Size(23, 25);
            BudgetGradeLabel.TabIndex = 13;
            BudgetGradeLabel.Text = "n";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 11F);
            AmountLabel.Location = new Point(418, 344);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(23, 25);
            AmountLabel.TabIndex = 12;
            AmountLabel.Text = "n";
            // 
            // EduFormLabel
            // 
            EduFormLabel.AutoSize = true;
            EduFormLabel.Font = new Font("Segoe UI", 11F);
            EduFormLabel.Location = new Point(418, 242);
            EduFormLabel.Name = "EduFormLabel";
            EduFormLabel.Size = new Size(23, 25);
            EduFormLabel.TabIndex = 11;
            EduFormLabel.Text = "n";
            // 
            // BudgetLabel
            // 
            BudgetLabel.AutoSize = true;
            BudgetLabel.Font = new Font("Segoe UI", 11F);
            BudgetLabel.Location = new Point(418, 293);
            BudgetLabel.Name = "BudgetLabel";
            BudgetLabel.Size = new Size(23, 25);
            BudgetLabel.TabIndex = 10;
            BudgetLabel.Text = "n";
            // 
            // NameSpecLabel
            // 
            NameSpecLabel.AutoSize = true;
            NameSpecLabel.Font = new Font("Segoe UI", 11F);
            NameSpecLabel.Location = new Point(418, 143);
            NameSpecLabel.Name = "NameSpecLabel";
            NameSpecLabel.Size = new Size(23, 25);
            NameSpecLabel.TabIndex = 9;
            NameSpecLabel.Text = "n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(51, 442);
            label8.Name = "label8";
            label8.Size = new Size(355, 25);
            label8.TabIndex = 8;
            label8.Text = "Прохідний бал на контракт у 2023 році:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(51, 393);
            label7.Name = "label7";
            label7.Size = new Size(346, 25);
            label7.TabIndex = 7;
            label7.Text = "Прохідний бал на бюджет у 2023 році:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(51, 293);
            label6.Name = "label6";
            label6.Size = new Size(281, 25);
            label6.TabIndex = 6;
            label6.Text = "Можливість вступу на бюджет:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(51, 344);
            label5.Name = "label5";
            label5.Size = new Size(273, 25);
            label5.TabIndex = 5;
            label5.Text = "Вартість на рік за контрактом:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(51, 242);
            label4.Name = "label4";
            label4.Size = new Size(164, 25);
            label4.TabIndex = 4;
            label4.Text = "Форма навчання:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(51, 192);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 3;
            label3.Text = "Назва ЗВО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(51, 143);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 2;
            label2.Text = "Назва спеціальності:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(51, 44);
            label1.Name = "label1";
            label1.Size = new Size(390, 37);
            label1.TabIndex = 1;
            label1.Text = "Інформація про спеціальність";
            // 
            // GoBackButton
            // 
            GoBackButton.Font = new Font("Segoe UI", 11F);
            GoBackButton.Location = new Point(881, 40);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(141, 33);
            GoBackButton.TabIndex = 0;
            GoBackButton.Text = "Назад";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // UniSpecForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1116, 981);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(GoBackButton);
            Name = "UniSpecForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Довідник абітурієнта";
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
        private Button GoBackButton;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label NameUniLabel;
        private Label ContractGradeLabel;
        private Label BudgetGradeLabel;
        private Label AmountLabel;
        private Label EduFormLabel;
        private Label BudgetLabel;
        private Label NameSpecLabel;
        private Label label8;
        private Button SaveButton;
        private Label SavedLabel;
    }
}