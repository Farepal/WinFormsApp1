namespace WinFormsApp1
{
    partial class Form12
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
            SuspendLayout();
            // 
            // skyLabel1
            // 
            skyLabel1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            skyLabel1.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel1.Location = new Point(284, 9);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(309, 25);
            skyLabel1.TabIndex = 1;
            skyLabel1.Text = "skyLabel1";
            skyLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(961, 643);
            Controls.Add(skyLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
    }
}