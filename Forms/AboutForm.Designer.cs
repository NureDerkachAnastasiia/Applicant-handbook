namespace CourseWork.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
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
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "E&xit";
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
            aboutToolStripMenuItem.Size = new Size(142, 26);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 11F);
            panel1.Location = new Point(95, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 891);
            panel1.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(437, 1863);
            label15.Name = "label15";
            label15.Size = new Size(0, 25);
            label15.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(691, 1755);
            label14.Name = "label14";
            label14.Size = new Size(175, 75);
            label14.TabIndex = 14;
            label14.Text = "Керівник:\r\nст. викл. каф. ПІ\r\nЧерепанова Ю. Ю.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(58, 1755);
            label13.Name = "label13";
            label13.Size = new Size(251, 75);
            label13.TabIndex = 13;
            label13.Text = "Виконала:\r\nст. гр. ПЗПІ-23-5\r\nДеркач Анастасія Сергіївна";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(58, 1189);
            label12.Name = "label12";
            label12.Size = new Size(808, 500);
            label12.TabIndex = 12;
            label12.Text = resources.GetString("label12.Text");
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Underline);
            label11.Location = new Point(58, 1134);
            label11.Name = "label11";
            label11.Size = new Size(350, 25);
            label11.TabIndex = 11;
            label11.Text = "4. Використання сторінки \"Збережене\"";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 1040);
            label10.Name = "label10";
            label10.Size = new Size(752, 75);
            label10.TabIndex = 10;
            label10.Text = resources.GetString("label10.Text");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Underline);
            label9.Location = new Point(58, 984);
            label9.Name = "label9";
            label9.Size = new Size(425, 25);
            label9.TabIndex = 9;
            label9.Text = "3. Збереження університетів та спеціальностей";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 616);
            label8.Name = "label8";
            label8.Size = new Size(823, 350);
            label8.TabIndex = 8;
            label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Underline);
            label7.Location = new Point(58, 571);
            label7.Name = "label7";
            label7.Size = new Size(377, 25);
            label7.TabIndex = 7;
            label7.Text = "2. Пошук спеціальностей та їх сортування";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 422);
            label6.Name = "label6";
            label6.Size = new Size(747, 125);
            label6.TabIndex = 6;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(58, 335);
            label5.Name = "label5";
            label5.Size = new Size(793, 75);
            label5.TabIndex = 5;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Underline);
            label4.Location = new Point(58, 285);
            label4.Name = "label4";
            label4.Size = new Size(277, 25);
            label4.TabIndex = 4;
            label4.Text = "1. Пошук по базі університетів\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label3.Location = new Point(58, 237);
            label3.Name = "label3";
            label3.Size = new Size(239, 25);
            label3.TabIndex = 3;
            label3.Text = "Основні функції програми";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(58, 110);
            label2.Name = "label2";
            label2.Size = new Size(829, 100);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(195, 37);
            label1.TabIndex = 1;
            label1.Text = "Про програму";
            // 
            // GoBackButton
            // 
            GoBackButton.Font = new Font("Segoe UI", 11F);
            GoBackButton.Location = new Point(881, 40);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(141, 33);
            GoBackButton.TabIndex = 5;
            GoBackButton.Text = "Назад";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1116, 981);
            Controls.Add(GoBackButton);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "AboutForm";
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
        private Label label1;
        private Button GoBackButton;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label12;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label label15;
    }
}