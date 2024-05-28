namespace CourseWork
{
    partial class PasswordForm
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
            label1 = new Label();
            PasswordTextBox = new TextBox();
            OkButton = new Button();
            CancelButton = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(461, 25);
            label1.TabIndex = 0;
            label1.Text = "Щоб увімкнути режим редагування введіть пароль:\r\n";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(234, 243, 249);
            PasswordTextBox.Location = new Point(109, 76);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(285, 32);
            PasswordTextBox.TabIndex = 1;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(446, 182);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 37);
            OkButton.TabIndex = 2;
            OkButton.Text = "ОК";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(346, 182);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 37);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 152);
            panel1.TabIndex = 4;
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(552, 231);
            Controls.Add(panel1);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "PasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Введіть пароль";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox PasswordTextBox;
        private Button OkButton;
        private Button CancelButton;
        private Panel panel1;
    }
}