namespace CourseWork.Forms
{
    partial class ChangePasswordForm
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
            panel1 = new Panel();
            NewPasswordTextBox2 = new TextBox();
            label3 = new Label();
            NewPasswordTextBox1 = new TextBox();
            label2 = new Label();
            OldPasswordTextBox = new TextBox();
            label1 = new Label();
            OkButton = new Button();
            CancelButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(NewPasswordTextBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(NewPasswordTextBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(OldPasswordTextBox);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 11F);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 313);
            panel1.TabIndex = 0;
            // 
            // NewPasswordTextBox2
            // 
            NewPasswordTextBox2.BackColor = Color.FromArgb(234, 243, 249);
            NewPasswordTextBox2.Location = new Point(22, 248);
            NewPasswordTextBox2.Name = "NewPasswordTextBox2";
            NewPasswordTextBox2.Size = new Size(256, 32);
            NewPasswordTextBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 207);
            label3.Name = "label3";
            label3.Size = new Size(272, 25);
            label3.TabIndex = 4;
            label3.Text = "Введіть новий пароль ще раз:";
            // 
            // NewPasswordTextBox1
            // 
            NewPasswordTextBox1.BackColor = Color.FromArgb(234, 243, 249);
            NewPasswordTextBox1.Location = new Point(22, 155);
            NewPasswordTextBox1.Name = "NewPasswordTextBox1";
            NewPasswordTextBox1.Size = new Size(256, 32);
            NewPasswordTextBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 110);
            label2.Name = "label2";
            label2.Size = new Size(207, 25);
            label2.TabIndex = 2;
            label2.Text = "Введіть новий пароль:";
            // 
            // OldPasswordTextBox
            // 
            OldPasswordTextBox.BackColor = Color.FromArgb(234, 243, 249);
            OldPasswordTextBox.Location = new Point(22, 58);
            OldPasswordTextBox.Name = "OldPasswordTextBox";
            OldPasswordTextBox.Size = new Size(256, 32);
            OldPasswordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 0;
            label1.Text = "Введіть старий пароль:";
            // 
            // OkButton
            // 
            OkButton.Font = new Font("Segoe UI", 11F);
            OkButton.Location = new Point(322, 331);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 32);
            OkButton.TabIndex = 1;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Segoe UI", 11F);
            CancelButton.Location = new Point(222, 331);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 32);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(428, 375);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(panel1);
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Змінити пароль";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox NewPasswordTextBox1;
        private Label label2;
        private TextBox OldPasswordTextBox;
        private Label label1;
        private TextBox NewPasswordTextBox2;
        private Button OkButton;
        private Button CancelButton;
    }
}