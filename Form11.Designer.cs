namespace WinFormsApp1
{
    partial class Form11
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
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            loginButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // skyLabel1
            // 
            skyLabel1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            skyLabel1.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel1.Location = new Point(304, 9);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(309, 25);
            skyLabel1.TabIndex = 2;
            skyLabel1.Text = "MATA PELAJARAN";
            skyLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(100, 154, 255);
            loginButton.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.Control;
            loginButton.Location = new Point(79, 95);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(280, 60);
            loginButton.TabIndex = 3;
            loginButton.Text = "FISIKA";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(79, 253);
            button1.Name = "button1";
            button1.Size = new Size(280, 60);
            button1.TabIndex = 4;
            button1.Text = "KIMIA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Fuchsia;
            button2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(79, 408);
            button2.Name = "button2";
            button2.Size = new Size(280, 60);
            button2.TabIndex = 5;
            button2.Text = "BAHASA INDONESIA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(100, 154, 255);
            button3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(533, 95);
            button3.Name = "button3";
            button3.Size = new Size(280, 60);
            button3.TabIndex = 6;
            button3.Text = "MATEMATIKA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(533, 253);
            button4.Name = "button4";
            button4.Size = new Size(280, 60);
            button4.TabIndex = 7;
            button4.Text = "BIOLOGI";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Fuchsia;
            button5.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(533, 408);
            button5.Name = "button5";
            button5.Size = new Size(280, 60);
            button5.TabIndex = 8;
            button5.Text = "BAHASA INGGRIS";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(961, 643);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(loginButton);
            Controls.Add(skyLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private Button loginButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}