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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();

            skyLabel1.Text = "ORDER";

            ListOfTeacherOrdered.Initialize();

            int panelHeight = 44;

            foreach (Teacher teacher in ListOfTeacherOrdered.teachers)
            {
                Panel teacherPanel = CreateTeacherPanel(teacher, panelHeight);
                panelHeight += 200;
                Controls.Add(teacherPanel);
            }

            ListOfTeacherOrdered.Reset();
        }

        private Panel CreateTeacherPanel(Teacher teacher, int height)
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
                ImageLocation = teacher.ImageLink,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new System.Drawing.Size(150, 150),
                Location = new System.Drawing.Point(20, 18)
            };

            // Create labels for Name and Description
            Label nameLabel = new Label
            {
                Text = $"Name: {teacher.Name}",
                Location = new System.Drawing.Point(198, 18),
                Size = new System.Drawing.Size(531, 25),
                AutoSize = false
            };

            Label descriptionLabel = new Label
            {
                Text = $"Description: {teacher.Description}",
                Location = new System.Drawing.Point(198, 43),
                Size = new System.Drawing.Size(531, 71),
                AutoSize = false
            };

            Label phoneNumberLabel = new Label
            {
                Text = $"Phone Number: {teacher.PhoneNumber}",
                Location = new System.Drawing.Point(198, 114),
                Size = new System.Drawing.Size(531, 25),
                AutoSize = false
            };

            string orderStatus = StudentAppSession.getStatusById(teacher.Id);

            Label statusLabel = new Label
            {
                Text = $"Status: {orderStatus}",
                Location = new System.Drawing.Point(198, 139),
                Size = new System.Drawing.Size(300, 25),
                AutoSize = false
            };

            Label subjectNameLabel = new Label
            {
                Text = $"Mata Pelajaran: {teacher.Subjects[0].Name}",
                Location = new System.Drawing.Point(198, 164),
                Size = new System.Drawing.Size(300, 25),
                AutoSize = false
            };

            string buttonText = "";
            if (orderStatus == "Belum Dikonfirmasi")
                buttonText = "Cancel";
            else if (orderStatus == "Selesai")
                buttonText = "Done";

            Button cancelOrderButton = new Button
            {
                Text = buttonText,
                Location = new System.Drawing.Point(500, 160),
                Size = new System.Drawing.Size(94, 29),
            };

            cancelOrderButton.Click += (sender, e) => cancelOrderButtonClick(teacher);

            // Add controls to the panel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(descriptionLabel);
            panel.Controls.Add(phoneNumberLabel);
            panel.Controls.Add(statusLabel);
            panel.Controls.Add(subjectNameLabel);
            if (orderStatus == "Belum Dikonfirmasi" || orderStatus == "Selesai")
                panel.Controls.Add(cancelOrderButton);

            return panel;
        }

        private void cancelOrderButtonClick(Teacher teacher)
        {
            // Student update
            StudentAppSession.student.Teachers.RemoveAll(t => t.Id == teacher.Id);
            StudentAppSession.UpdateStudent();

            // Teacher Update
            TeacherAppSession.teacher = teacher;
            TeacherAppSession.teacher.Subjects[0].Students.RemoveAll(s => s.StudentId == StudentAppSession.student.Id);
            TeacherAppSession.UpdateTeacher();
            TeacherAppSession.Reset();

            // Refresh
            Form10 form10 = new Form10();
            form10.MdiParent = this.MdiParent;
            form10.Dock = DockStyle.Fill;
            form10.Show();
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
