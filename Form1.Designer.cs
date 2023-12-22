namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emailLoginTextBox = new TextBox();
            loginButton = new Button();
            emailLoginLabel = new Label();
            passwordLoginTextBox = new TextBox();
            passwordLoginLabel = new Label();
            registerLabel = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // emailLoginTextBox
            // 
            emailLoginTextBox.BackColor = SystemColors.Window;
            emailLoginTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            emailLoginTextBox.Location = new Point(28, 96);
            emailLoginTextBox.Name = "emailLoginTextBox";
            emailLoginTextBox.Size = new Size(396, 41);
            emailLoginTextBox.TabIndex = 0;
            emailLoginTextBox.TextChanged += emailLoginTextBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(100, 154, 255);
            loginButton.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.Control;
            loginButton.Location = new Point(76, 259);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(280, 60);
            loginButton.TabIndex = 2;
            loginButton.Text = "Sign In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // emailLoginLabel
            // 
            emailLoginLabel.AutoSize = true;
            emailLoginLabel.BackColor = Color.FromArgb(26, 26, 26);
            emailLoginLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLoginLabel.ForeColor = Color.FromArgb(100, 154, 255);
            emailLoginLabel.Location = new Point(28, 69);
            emailLoginLabel.Name = "emailLoginLabel";
            emailLoginLabel.Size = new Size(211, 23);
            emailLoginLabel.TabIndex = 3;
            emailLoginLabel.Text = "SIGN IN WITH EMAIL";
            emailLoginLabel.Click += emailLoginLabel_Click;
            // 
            // passwordLoginTextBox
            // 
            passwordLoginTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLoginTextBox.Location = new Point(28, 185);
            passwordLoginTextBox.Name = "passwordLoginTextBox";
            passwordLoginTextBox.Size = new Size(396, 41);
            passwordLoginTextBox.TabIndex = 1;
            passwordLoginTextBox.UseSystemPasswordChar = true;
            passwordLoginTextBox.TextChanged += passwordLoginTextBox_TextChanged;
            // 
            // passwordLoginLabel
            // 
            passwordLoginLabel.AutoSize = true;
            passwordLoginLabel.BackColor = Color.FromArgb(26, 26, 26);
            passwordLoginLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLoginLabel.ForeColor = Color.FromArgb(100, 154, 255);
            passwordLoginLabel.Location = new Point(28, 158);
            passwordLoginLabel.Name = "passwordLoginLabel";
            passwordLoginLabel.Size = new Size(127, 23);
            passwordLoginLabel.TabIndex = 5;
            passwordLoginLabel.Text = "PASSWORD";
            passwordLoginLabel.Click += passwordLoginLabel_Click;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.BackColor = Color.FromArgb(26, 26, 26);
            registerLabel.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            registerLabel.ForeColor = SystemColors.InactiveCaption;
            registerLabel.Location = new Point(24, 360);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(203, 20);
            registerLabel.TabIndex = 7;
            registerLabel.Text = "Don't have an account? ";
            registerLabel.Click += registerLabel_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = SystemColors.HighlightText;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(26, 26, 26);
            linkLabel1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = SystemColors.InactiveCaption;
            linkLabel1.Location = new Point(220, 360);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(191, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create a free account.";
            linkLabel1.Click += linkLabel1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            BackgroundImage = Properties.Resources.TeachAtYourHome;
            ClientSize = new Size(782, 453);
            Controls.Add(linkLabel1);
            Controls.Add(registerLabel);
            Controls.Add(passwordLoginLabel);
            Controls.Add(passwordLoginTextBox);
            Controls.Add(emailLoginLabel);
            Controls.Add(loginButton);
            Controls.Add(emailLoginTextBox);
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimizeBox = false;
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            Text = "Online Private";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox emailLoginTextBox;
        private Button loginButton;
        private Label emailLoginLabel;
        private TextBox passwordLoginTextBox;
        private Label passwordLoginLabel;
        private Label registerLabel;
        private LinkLabel linkLabel1;
    }
}