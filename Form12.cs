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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();

            ListOfStudentsTaught.Initialize();
            if (TeacherAppSession.teacher.Subjects.Count != 0)
                skyLabel1.Text = TeacherAppSession.teacher.Subjects[0].Name;

            int panelHeight = 44;

            foreach(Student student in ListOfStudentsTaught.students)
            {
                Panel studentPanel = CreateStudentPanel(student, panelHeight);
                panelHeight += 200;
                Controls.Add(studentPanel);
            }

            ListOfStudentsTaught.Reset();
        }

        private Panel CreateStudentPanel(Student student, int height)
        {
            RoundPanel panel = new RoundPanel()
            {
                BackColor = Color.FromArgb(224, 224, 224),
                Size = new System.Drawing.Size(765, 191),
                Location = new System.Drawing.Point(83, height),
            };

            // Create PictureBox for the teacher's image
            PictureBox pictureBox = new PictureBox
            {
                ImageLocation = student.ImageLink,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new System.Drawing.Size(150, 150),
                Location = new System.Drawing.Point(20, 18)
            };

            // Create labels for Name and Description
            Label nameLabel = new Label
            {
                Text = $"Name: {student.Name}",
                Location = new System.Drawing.Point(198, 18),
                Size = new System.Drawing.Size(531, 25),
                AutoSize = false
            };

            string orderStatus = TeacherAppSession.getStatusById(student.Id);

            CheckBox BelumDikonfirmasiCheckBox = new CheckBox
            {
                Text = "Belum Dikonfirmasi",
                Location = new System.Drawing.Point(198, 43),
                Size = new System.Drawing.Size(300, 25),
                AutoSize = false
            };

            CheckBox SedangProses = new CheckBox
            {
                Text = "Sedang Proses",
                Location = new System.Drawing.Point(198, 68),
                Size = new System.Drawing.Size(300, 25),
                AutoSize = false
            };

            CheckBox SelesaiCheckBox = new CheckBox
            {
                Text = "Selesai",
                Location = new System.Drawing.Point(198, 93),
                Size = new System.Drawing.Size(300, 25),
                AutoSize = false
            };

            Label phoneNumberLabel = new Label
            {
                Text = $"Phone Number: {student.PhoneNumber}",
                Location = new System.Drawing.Point(198, 114),
                Size = new System.Drawing.Size(531, 25),
                AutoSize = false
            };


            Label statusLabel = new Label
            {
                Text = $"Status: {orderStatus}",
                Location = new System.Drawing.Point(198, 139),
                Size = new System.Drawing.Size(300, 25),
                AutoSize = false
            };

            string buttonText = "";
            if (orderStatus == "Belum Dikonfirmasi")
            {
                buttonText = "Cancel";
                BelumDikonfirmasiCheckBox.Checked = true;
            }
            else if (orderStatus == "Sedang Proses")
            {
                SedangProses.Checked = true;
            }
            else if (orderStatus == "Selesai")
            {
                buttonText = "Done";
                SelesaiCheckBox.Checked = true;
            }

            Button cancelOrderButton = new Button
            {
                Text = buttonText,
                Location = new System.Drawing.Point(500, 160),
                Size = new System.Drawing.Size(94, 29),
            };

            cancelOrderButton.Click += (sender, e) => cancelOrderButtonClick(student);
            BelumDikonfirmasiCheckBox.CheckedChanged += (sender, e) => CheckBox_OnChanged(student, "Belum Dikonfirmasi");
            SedangProses.CheckedChanged += (sender, e) => CheckBox_OnChanged(student, "Sedang Proses");
            SelesaiCheckBox.CheckedChanged += (sender, e) => CheckBox_OnChanged(student, "Selesai");

            // Add controls to the panel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(BelumDikonfirmasiCheckBox);
            panel.Controls.Add(SedangProses);
            panel.Controls.Add(SelesaiCheckBox);
            panel.Controls.Add(phoneNumberLabel);
            panel.Controls.Add(statusLabel);
            if (orderStatus == "Belum Dikonfirmasi" || orderStatus == "Selesai")
                panel.Controls.Add(cancelOrderButton);

            return panel;
        }

        private void CheckBox_OnChanged(Student student, string textStatus)
        {
            // Teacher Update
            TeacherAppSession.teacher.Subjects[0].Students.Find(s => s.StudentId == student.Id).Status = textStatus;
            TeacherAppSession.UpdateTeacher();

            // Student update
            StudentAppSession.student = student;
            StudentAppSession.student.Teachers.Find(t => t.Id == TeacherAppSession.teacher.Id).Status = textStatus;
            StudentAppSession.UpdateStudent();
            StudentAppSession.Reset();

            // Refresh
            Form12 Form12 = new Form12();
            Form12.MdiParent = this.MdiParent;
            Form12.Dock = DockStyle.Fill;
            Form12.Show();
            this.Dispose();
        }

        private void cancelOrderButtonClick(Student student)
        {
            // Teacher Update
            TeacherAppSession.teacher.Subjects[0].Students.RemoveAll(s => s.StudentId == student.Id);
            TeacherAppSession.UpdateTeacher();

            // Student update
            StudentAppSession.student = student;
            StudentAppSession.student.Teachers.RemoveAll(t => t.Id == TeacherAppSession.teacher.Id);
            StudentAppSession.UpdateStudent();
            StudentAppSession.Reset();

            // Refresh
            Form12 Form12 = new Form12();
            Form12.MdiParent = this.MdiParent;
            Form12.Dock = DockStyle.Fill;
            Form12.Show();
            this.Dispose();
        }

        private void SubmitButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void parrotGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
