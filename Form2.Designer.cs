namespace WinFormsApp1
{
    partial class Form2
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
            emailRegisterLabel = new Label();
            passwordRegisterLabel = new Label();
            rolesRegister = new ComboBox();
            rolesRegisterLabel = new Label();
            emailRegisterTextBox = new TextBox();
            passwordRegisterTextBox = new TextBox();
            signUpButton = new Button();
            SuspendLayout();
            // 
            // emailRegisterLabel
            // 
            emailRegisterLabel.AutoSize = true;
            emailRegisterLabel.BackColor = Color.FromArgb(26, 26, 26);
            emailRegisterLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailRegisterLabel.ForeColor = Color.FromArgb(100, 154, 255);
            emailRegisterLabel.Location = new Point(369, 61);
            emailRegisterLabel.Name = "emailRegisterLabel";
            emailRegisterLabel.Size = new Size(72, 23);
            emailRegisterLabel.TabIndex = 0;
            emailRegisterLabel.Text = "EMAIL";
            emailRegisterLabel.Click += emailRegisterLabel_Click;
            // 
            // passwordRegisterLabel
            // 
            passwordRegisterLabel.AutoSize = true;
            passwordRegisterLabel.BackColor = Color.FromArgb(26, 26, 26);
            passwordRegisterLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordRegisterLabel.ForeColor = Color.FromArgb(100, 154, 255);
            passwordRegisterLabel.Location = new Point(369, 144);
            passwordRegisterLabel.Name = "passwordRegisterLabel";
            passwordRegisterLabel.Size = new Size(127, 23);
            passwordRegisterLabel.TabIndex = 1;
            passwordRegisterLabel.Text = "PASSWORD";
            passwordRegisterLabel.Click += passwordRegisterLabel_Click;
            // 
            // rolesRegister
            // 
            rolesRegister.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rolesRegister.FormattingEnabled = true;
            rolesRegister.Items.AddRange(new object[] { "teacher", "student" });
            rolesRegister.Location = new Point(369, 254);
            rolesRegister.Name = "rolesRegister";
            rolesRegister.Size = new Size(316, 43);
            rolesRegister.TabIndex = 3;
            // 
            // rolesRegisterLabel
            // 
            rolesRegisterLabel.AutoSize = true;
            rolesRegisterLabel.BackColor = Color.FromArgb(26, 26, 26);
            rolesRegisterLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rolesRegisterLabel.ForeColor = Color.FromArgb(100, 154, 255);
            rolesRegisterLabel.Location = new Point(369, 228);
            rolesRegisterLabel.Name = "rolesRegisterLabel";
            rolesRegisterLabel.Size = new Size(65, 23);
            rolesRegisterLabel.TabIndex = 3;
            rolesRegisterLabel.Text = "ROLE";
            rolesRegisterLabel.Click += rolesRegisterLabel_Click;
            // 
            // emailRegisterTextBox
            // 
            emailRegisterTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            emailRegisterTextBox.Location = new Point(369, 87);
            emailRegisterTextBox.Name = "emailRegisterTextBox";
            emailRegisterTextBox.Size = new Size(316, 41);
            emailRegisterTextBox.TabIndex = 1;
            emailRegisterTextBox.TextChanged += emailRegisterTextBox_TextChanged;
            // 
            // passwordRegisterTextBox
            // 
            passwordRegisterTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordRegisterTextBox.Location = new Point(369, 170);
            passwordRegisterTextBox.Name = "passwordRegisterTextBox";
            passwordRegisterTextBox.Size = new Size(316, 41);
            passwordRegisterTextBox.TabIndex = 2;
            passwordRegisterTextBox.UseSystemPasswordChar = true;
            passwordRegisterTextBox.TextChanged += passwordRegisterTextBox_TextChanged;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.FromArgb(100, 154, 255);
            signUpButton.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            signUpButton.ForeColor = SystemColors.Control;
            signUpButton.Location = new Point(424, 333);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(200, 60);
            signUpButton.TabIndex = 4;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = Properties.Resources.CreateYourAccount;
            ClientSize = new Size(782, 453);
            Controls.Add(signUpButton);
            Controls.Add(passwordRegisterTextBox);
            Controls.Add(emailRegisterTextBox);
            Controls.Add(rolesRegisterLabel);
            Controls.Add(rolesRegister);
            Controls.Add(passwordRegisterLabel);
            Controls.Add(emailRegisterLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Register";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailRegisterLabel;
        private Label passwordRegisterLabel;
        private ComboBox rolesRegister;
        private Label rolesRegisterLabel;
        private TextBox emailRegisterTextBox;
        private TextBox passwordRegisterTextBox;
        private Button signUpButton;
    }
}