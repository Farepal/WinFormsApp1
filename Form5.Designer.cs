namespace WinFormsApp1
{
    partial class Form5
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
            pictureBox1 = new PictureBox();
            button1 = new ReaLTaiizor.Controls.Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            checkBox5 = new CheckBox();
            textBox8 = new TextBox();
            checkBox6 = new CheckBox();
            emailLoginLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(33, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(32, 34, 37);
            button1.Location = new Point(88, 362);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(175, 50);
            button1.TabIndex = 1;
            button1.Text = "Upload Image";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(387, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(387, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 27);
            textBox2.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(33, 488);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(300, 114);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ButtonFace;
            checkBox1.Location = new Point(673, 60);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(168, 27);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "MATEMATIKA";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.ForeColor = SystemColors.ButtonFace;
            checkBox2.Location = new Point(673, 149);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(98, 27);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "FISIKA";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.ForeColor = SystemColors.ButtonFace;
            checkBox3.Location = new Point(673, 231);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(90, 27);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "KIMIA";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.ForeColor = SystemColors.ButtonFace;
            checkBox4.Location = new Point(673, 316);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(118, 27);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "BIOLOGI";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(673, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            textBox3.Text = "Harga per jam";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(673, 182);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 10;
            textBox4.Text = "Harga per jam";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(673, 264);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 11;
            textBox5.Text = "Harga per jam";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(673, 349);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 12;
            textBox6.Text = "Harga per jam";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(673, 436);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 14;
            textBox7.Text = "Harga per jam";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.ForeColor = SystemColors.ButtonFace;
            checkBox5.Location = new Point(673, 403);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(234, 27);
            checkBox5.TabIndex = 13;
            checkBox5.Text = "BAHASA INDONESIA";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(673, 521);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 16;
            textBox8.Text = "Harga per jam";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.ForeColor = SystemColors.ButtonFace;
            checkBox6.Location = new Point(673, 488);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(207, 27);
            checkBox6.TabIndex = 15;
            checkBox6.Text = "BAHASA INGGRIS";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // emailLoginLabel
            // 
            emailLoginLabel.AutoSize = true;
            emailLoginLabel.BackColor = Color.FromArgb(26, 26, 26);
            emailLoginLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLoginLabel.ForeColor = Color.FromArgb(100, 154, 255);
            emailLoginLabel.Location = new Point(633, 9);
            emailLoginLabel.Name = "emailLoginLabel";
            emailLoginLabel.Size = new Size(316, 23);
            emailLoginLabel.TabIndex = 17;
            emailLoginLabel.Text = "PELAJARAN YANG DIAJARKAN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(26, 26, 26);
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(100, 154, 255);
            label1.Location = new Point(387, 32);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 18;
            label1.Text = "NAMA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(26, 26, 26);
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(100, 154, 255);
            label2.Location = new Point(387, 136);
            label2.Name = "label2";
            label2.Size = new Size(188, 23);
            label2.TabIndex = 19;
            label2.Text = "NOMOR TELEPON";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(26, 26, 26);
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(100, 154, 255);
            label3.Location = new Point(33, 452);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 20;
            label3.Text = "DESKRIPSI";
            // 
            // button2
            // 
            button2.Location = new Point(387, 549);
            button2.Name = "button2";
            button2.Size = new Size(145, 53);
            button2.TabIndex = 21;
            button2.Text = "SUBMIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(961, 643);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailLoginLabel);
            Controls.Add(textBox8);
            Controls.Add(checkBox6);
            Controls.Add(textBox7);
            Controls.Add(checkBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private CheckBox checkBox5;
        private TextBox textBox8;
        private CheckBox checkBox6;
        private Label emailLoginLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}