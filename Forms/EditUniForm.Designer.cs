namespace CourseWork
{
    partial class EditUniForm
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
            panel1 = new Panel();
            CityComboBox = new ComboBox();
            label8 = new Label();
            AddNewSpecButton = new Button();
            EmailTextBox = new TextBox();
            RemoveSpecButton = new Button();
            PhoneNumTextBox = new TextBox();
            AdressTextBox = new TextBox();
            HeadTextBox = new TextBox();
            IdTextBox = new TextBox();
            NameTextBox = new TextBox();
            SpeciDataGridView = new DataGridView();
            FormLabel = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            CancelButton = new Button();
            OkButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpeciDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(CityComboBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(AddNewSpecButton);
            panel1.Controls.Add(EmailTextBox);
            panel1.Controls.Add(RemoveSpecButton);
            panel1.Controls.Add(PhoneNumTextBox);
            panel1.Controls.Add(AdressTextBox);
            panel1.Controls.Add(HeadTextBox);
            panel1.Controls.Add(IdTextBox);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(SpeciDataGridView);
            panel1.Controls.Add(FormLabel);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(95, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 891);
            panel1.TabIndex = 0;
            // 
            // CityComboBox
            // 
            CityComboBox.FormattingEnabled = true;
            CityComboBox.Location = new Point(273, 167);
            CityComboBox.Name = "CityComboBox";
            CityComboBox.Size = new Size(466, 33);
            CityComboBox.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 170);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 32;
            label8.Text = "Область:";
            // 
            // AddNewSpecButton
            // 
            AddNewSpecButton.Location = new Point(598, 848);
            AddNewSpecButton.Name = "AddNewSpecButton";
            AddNewSpecButton.Size = new Size(140, 35);
            AddNewSpecButton.TabIndex = 31;
            AddNewSpecButton.Text = "Додати нову";
            AddNewSpecButton.UseVisualStyleBackColor = true;
            AddNewSpecButton.Click += AddNewSpecButton_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.FromArgb(234, 243, 249);
            EmailTextBox.Location = new Point(273, 322);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(466, 32);
            EmailTextBox.TabIndex = 27;
            // 
            // RemoveSpecButton
            // 
            RemoveSpecButton.Location = new Point(744, 848);
            RemoveSpecButton.Name = "RemoveSpecButton";
            RemoveSpecButton.Size = new Size(122, 35);
            RemoveSpecButton.TabIndex = 30;
            RemoveSpecButton.Text = "Видалити";
            RemoveSpecButton.UseVisualStyleBackColor = true;
            RemoveSpecButton.Click += RemoveSpecButton_Click;
            // 
            // PhoneNumTextBox
            // 
            PhoneNumTextBox.BackColor = Color.FromArgb(234, 243, 249);
            PhoneNumTextBox.Location = new Point(273, 283);
            PhoneNumTextBox.Name = "PhoneNumTextBox";
            PhoneNumTextBox.Size = new Size(466, 32);
            PhoneNumTextBox.TabIndex = 26;
            // 
            // AdressTextBox
            // 
            AdressTextBox.BackColor = Color.FromArgb(234, 243, 249);
            AdressTextBox.Location = new Point(273, 244);
            AdressTextBox.Name = "AdressTextBox";
            AdressTextBox.Size = new Size(466, 32);
            AdressTextBox.TabIndex = 25;
            // 
            // HeadTextBox
            // 
            HeadTextBox.BackColor = Color.FromArgb(234, 243, 249);
            HeadTextBox.Location = new Point(273, 205);
            HeadTextBox.Name = "HeadTextBox";
            HeadTextBox.Size = new Size(466, 32);
            HeadTextBox.TabIndex = 24;
            // 
            // IdTextBox
            // 
            IdTextBox.BackColor = Color.FromArgb(234, 243, 249);
            IdTextBox.Location = new Point(273, 128);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(466, 32);
            IdTextBox.TabIndex = 23;
            IdTextBox.KeyPress += IdTextBox_KeyPress;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(234, 243, 249);
            NameTextBox.Location = new Point(273, 88);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(466, 32);
            NameTextBox.TabIndex = 22;
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
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(137, 171, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SpeciDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SpeciDataGridView.ColumnHeadersHeight = 60;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            SpeciDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            SpeciDataGridView.GridColor = SystemColors.Desktop;
            SpeciDataGridView.Location = new Point(50, 383);
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
            SpeciDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SpeciDataGridView.Size = new Size(816, 459);
            SpeciDataGridView.TabIndex = 21;
            SpeciDataGridView.CellClick += SpeciDataGridView_CellClick;
            SpeciDataGridView.CellDoubleClick += SpeciDataGridView_CellDoubleClick;
            // 
            // FormLabel
            // 
            FormLabel.AutoSize = true;
            FormLabel.Font = new Font("Segoe UI", 16F);
            FormLabel.Location = new Point(34, 33);
            FormLabel.Name = "FormLabel";
            FormLabel.Size = new Size(336, 37);
            FormLabel.TabIndex = 0;
            FormLabel.Text = "Редагування університету";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(50, 325);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 20;
            label7.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(50, 247);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 18;
            label5.Text = "Адреса:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(50, 286);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 19;
            label6.Text = "Телефон:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(50, 91);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 15;
            label2.Text = "Назва:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(50, 131);
            label3.Name = "label3";
            label3.Size = new Size(189, 25);
            label3.TabIndex = 16;
            label3.Text = "Код закладу в ЄДБО:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(50, 208);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 17;
            label4.Text = "Керівник закладу:";
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
            // CancelButton
            // 
            CancelButton.Location = new Point(806, 938);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(107, 32);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(919, 938);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(107, 32);
            OkButton.TabIndex = 4;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // EditUniForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1116, 981);
            Controls.Add(OkButton);
            Controls.Add(CancelButton);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "EditUniForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditUniForm";
            Load += EditUniForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpeciDataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label FormLabel;
        private Button CancelButton;
        private Button OkButton;
        private TextBox EmailTextBox;
        private TextBox PhoneNumTextBox;
        private TextBox AdressTextBox;
        private TextBox HeadTextBox;
        private TextBox IdTextBox;
        private TextBox NameTextBox;
        private DataGridView SpeciDataGridView;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button AddNewSpecButton;
        private Button RemoveSpecButton;
        private Label label8;
        private ComboBox CityComboBox;
    }
}