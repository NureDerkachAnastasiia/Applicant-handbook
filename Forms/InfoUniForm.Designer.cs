namespace CourseWork.Forms
{
    partial class InfoUniForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            SavedLabel = new Label();
            SaveButton = new Button();
            SpeciDataGridView = new DataGridView();
            EmailLabel = new Label();
            TelLabel = new Label();
            AdressLabel = new Label();
            HeadLabel = new Label();
            IdLabel = new Label();
            NameLabel = new Label();
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
            ((System.ComponentModel.ISupportInitialize)SpeciDataGridView).BeginInit();
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
            menuStrip1.TabIndex = 2;
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
            panel1.Controls.Add(SpeciDataGridView);
            panel1.Controls.Add(EmailLabel);
            panel1.Controls.Add(TelLabel);
            panel1.Controls.Add(AdressLabel);
            panel1.Controls.Add(HeadLabel);
            panel1.Controls.Add(IdLabel);
            panel1.Controls.Add(NameLabel);
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
            panel1.TabIndex = 3;
            // 
            // SavedLabel
            // 
            SavedLabel.AutoSize = true;
            SavedLabel.Location = new Point(55, 374);
            SavedLabel.Name = "SavedLabel";
            SavedLabel.Size = new Size(0, 20);
            SavedLabel.TabIndex = 16;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 11F);
            SaveButton.Location = new Point(55, 336);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(131, 35);
            SaveButton.TabIndex = 15;
            SaveButton.Text = "Зберегти";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SpeciDataGridView
            // 
            SpeciDataGridView.AllowUserToAddRows = false;
            SpeciDataGridView.AllowUserToDeleteRows = false;
            SpeciDataGridView.AllowUserToResizeColumns = false;
            SpeciDataGridView.AllowUserToResizeRows = false;
            SpeciDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SpeciDataGridView.BackgroundColor = Color.White;
            SpeciDataGridView.BorderStyle = BorderStyle.Fixed3D;
            SpeciDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SpeciDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(137, 171, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SpeciDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SpeciDataGridView.ColumnHeadersHeight = 60;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            SpeciDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            SpeciDataGridView.GridColor = SystemColors.Desktop;
            SpeciDataGridView.Location = new Point(56, 401);
            SpeciDataGridView.Name = "SpeciDataGridView";
            SpeciDataGridView.ReadOnly = true;
            SpeciDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            SpeciDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            SpeciDataGridView.RowHeadersVisible = false;
            SpeciDataGridView.RowHeadersWidth = 51;
            SpeciDataGridView.RowTemplate.Height = 50;
            SpeciDataGridView.RowTemplate.ReadOnly = true;
            SpeciDataGridView.Size = new Size(816, 459);
            SpeciDataGridView.TabIndex = 14;
            SpeciDataGridView.CellContentClick += SpeciDataGridView_CellContentClick;
            SpeciDataGridView.CellMouseEnter += SpeciDataGridView_CellMouseEnter;
            SpeciDataGridView.CellMouseLeave += SpeciDataGridView_CellMouseLeave;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 11F);
            EmailLabel.Location = new Point(266, 298);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(23, 25);
            EmailLabel.TabIndex = 13;
            EmailLabel.Text = "n";
            // 
            // TelLabel
            // 
            TelLabel.AutoSize = true;
            TelLabel.Font = new Font("Segoe UI", 11F);
            TelLabel.Location = new Point(266, 259);
            TelLabel.Name = "TelLabel";
            TelLabel.Size = new Size(23, 25);
            TelLabel.TabIndex = 12;
            TelLabel.Text = "n";
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Font = new Font("Segoe UI", 11F);
            AdressLabel.Location = new Point(266, 220);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(23, 25);
            AdressLabel.TabIndex = 11;
            AdressLabel.Text = "n";
            // 
            // HeadLabel
            // 
            HeadLabel.AutoSize = true;
            HeadLabel.Font = new Font("Segoe UI", 11F);
            HeadLabel.Location = new Point(266, 181);
            HeadLabel.Name = "HeadLabel";
            HeadLabel.Size = new Size(23, 25);
            HeadLabel.TabIndex = 10;
            HeadLabel.Text = "n";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 11F);
            IdLabel.Location = new Point(266, 141);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(23, 25);
            IdLabel.TabIndex = 9;
            IdLabel.Text = "n";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 11F);
            NameLabel.Location = new Point(266, 101);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(23, 25);
            NameLabel.TabIndex = 8;
            NameLabel.Text = "n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(55, 298);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 7;
            label7.Text = "E-mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(55, 259);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 6;
            label6.Text = "Телефон:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(55, 220);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 5;
            label5.Text = "Адреса:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(55, 181);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 4;
            label4.Text = "Керівник закладу:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(55, 141);
            label3.Name = "label3";
            label3.Size = new Size(189, 25);
            label3.TabIndex = 3;
            label3.Text = "Код закладу в ЄДБО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(55, 101);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 2;
            label2.Text = "Назва:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(42, 37);
            label1.Name = "label1";
            label1.Size = new Size(273, 37);
            label1.TabIndex = 1;
            label1.Text = "Інформація про ЗВО";
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
            // InfoUniForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1116, 981);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(GoBackButton);
            Font = new Font("Segoe UI", 9F);
            Name = "InfoUniForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Довідник абітурієнта";
            Load += InfoUniForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpeciDataGridView).EndInit();
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
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label IdLabel;
        private Label NameLabel;
        private Label label7;
        private Label label6;
        private DataGridView SpeciDataGridView;
        private Label EmailLabel;
        private Label TelLabel;
        private Label AdressLabel;
        private Label HeadLabel;
        private Button SaveButton;
        private Label SavedLabel;
    }
}