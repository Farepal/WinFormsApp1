using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form7 : Form
    {
        String imageLocation = ""; // D:/User/blablabla
        public Form7()
        {
            InitializeComponent();
            textBox1.Text = StudentAppSession.student.Name;
            textBox2.Text = StudentAppSession.student.PhoneNumber;
            pictureBox1.ImageLocation = (StudentAppSession.student.ImageLink);  
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Nama tidak boleh kosong");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Nomor telepon tidak boleh kosong");
                return;
            }

            StudentAppSession.student.Name = textBox1.Text;
            StudentAppSession.student.PhoneNumber = textBox2.Text;
            if (imageLocation != "")
            {
                GoogleDriveConnector drive = GoogleDriveConnector.Instance;
                string link = drive.UploadFile(imageLocation, Path.GetFileName(imageLocation));
                StudentAppSession.student.ImageLink = "https://drive.google.com/uc?export=view&id=" + link;
            }

            StudentAppSession.UpdateStudent();

            Form6 form6 = new Form6();
            form6.Show();
            form6.MdiParent = this.MdiParent;
            form6.Dock = DockStyle.Fill;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG files (*.png)|*.png|All Files (*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
