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
    public partial class Form5 : Form
    {
        String imageLocation = ""; // D:/User/blablabla
        public Form5()
        {
            InitializeComponent();
            richTextBox1.Text = TeacherAppSession.teacher.Description;
            textBox1.Text = TeacherAppSession.teacher.Name;
            textBox2.Text = TeacherAppSession.teacher.PhoneNumber;
            pictureBox1.ImageLocation = (TeacherAppSession.teacher.ImageLink);

            foreach (Subject subject in TeacherAppSession.teacher.Subjects)
            {
                if (subject.Name == "MATEMATIKA")
                {
                    checkBox1.Checked = true;
                    textBox3.Text = subject.PricePerHour;
                }
                if (subject.Name == "FISIKA")
                {
                    checkBox2.Checked = true;
                    textBox4.Text = subject.PricePerHour;
                }
                if (subject.Name == "KIMIA")
                {
                    checkBox3.Checked = true;
                    textBox5.Text = subject.PricePerHour;
                }
                if (subject.Name == "BIOLOGI")
                {
                    checkBox4.Checked = true;
                    textBox6.Text = subject.PricePerHour;
                }
                if (subject.Name == "BAHASA INDONESIA")
                {
                    checkBox5.Checked = true;
                    textBox7.Text = subject.PricePerHour;
                }
                if (subject.Name == "BAHASA INGGRIS")
                {
                    checkBox6.Checked = true;
                    textBox8.Text = subject.PricePerHour;
                }
            }   

            // enabled the textBox
            textBox3.Enabled = checkBox1.Checked;
            textBox4.Enabled = checkBox2.Checked;
            textBox5.Enabled = checkBox3.Checked;
            textBox6.Enabled = checkBox4.Checked;
            textBox7.Enabled = checkBox5.Checked;
            textBox8.Enabled = checkBox6.Checked;

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = checkBox1.Checked;
            textBox3.Text = "";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = checkBox2.Checked;
            textBox4.Text = "";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = checkBox3.Checked;
            textBox5.Text = "";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = checkBox4.Checked;
            textBox6.Text = "";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Enabled = checkBox5.Checked;
            textBox7.Text = "";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Enabled = checkBox6.Checked;
            textBox8.Text = "";
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
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Deskripsi tidak boleh kosong");
                return;
            }

            TeacherAppSession.teacher.Name = textBox1.Text;
            TeacherAppSession.teacher.PhoneNumber = textBox2.Text;
            TeacherAppSession.teacher.Description = richTextBox1.Text;

            var SubjectList = new List<Subject>();

            if (checkBox1.Checked)
            {
                Subject subject = new Subject();
                subject.Name = "MATEMATIKA";
                subject.PricePerHour = textBox3.Text;
                SubjectList.Add(subject);
            }
            if (checkBox2.Checked)
            {
                Subject subject = new Subject();
                subject.Name = "FISIKA";
                subject.PricePerHour = textBox4.Text;
                SubjectList.Add(subject);
            }
            if (checkBox3.Checked)
            {
                Subject subject = new Subject();
                subject.Name = "KIMIA";
                subject.PricePerHour = textBox5.Text;
                SubjectList.Add(subject);
            }
            if (checkBox4.Checked)
            {
                Subject subject = new Subject();
                subject.Name = "BIOLOGI";
                subject.PricePerHour = textBox6.Text;
                SubjectList.Add(subject);
            }
            if (checkBox5.Checked)
            {
                Subject subject = new Subject();
                subject.Name = "BAHASA INDONESIA";
                subject.PricePerHour = textBox7.Text;
                SubjectList.Add(subject);
            }
            if (checkBox6.Checked)
            {
                Subject subject = new Subject();
                subject.Name = "BAHASA INGGRIS";
                subject.PricePerHour = textBox8.Text;
                SubjectList.Add(subject);
            }

            TeacherAppSession.teacher.Subjects = SubjectList;
            if (imageLocation != "")
            {
                GoogleDriveConnector drive = GoogleDriveConnector.Instance;
                string link = drive.UploadFile(imageLocation, Path.GetFileName(imageLocation));
                TeacherAppSession.teacher.ImageLink = "https://drive.google.com/uc?export=view&id=" + link;
            }

            TeacherAppSession.UpdateTeacher();

            Form4 form4 = new Form4();
            form4.Show();
            form4.MdiParent = this.MdiParent;
            form4.Dock = DockStyle.Fill;
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
