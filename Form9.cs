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
    public partial class Form9 : Form
    {
        public Form9(string nameOfSubject)
        {
            InitializeComponent();

            skyLabel1.Text = nameOfSubject;

            ListOfTeacherPerSubject.Initialize(nameOfSubject);

            int panelHeight = 44;

            foreach (Teacher teacher in ListOfTeacherPerSubject.teachers)
            {
                Panel teacherPanel = CreateTeacherPanel(teacher, panelHeight);
                panelHeight += 200;
                Controls.Add(teacherPanel);
            }
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

            Label PricePerHour = new Label
            {
                Text = $"Price Per Hour: {teacher.Subjects[0].PricePerHour}",
                Location = new System.Drawing.Point(198, 114),
                Size = new System.Drawing.Size(531, 25),
                AutoSize = false
            };

            // Create a submit button
            Button submitButton = new Button
            {
                Text = "Order",
                Location = new System.Drawing.Point(198, 139),
                Size = new System.Drawing.Size(94, 29),
            };

            // Attach an event handler to the button click event
            submitButton.Click += (sender, e) => SubmitButtonClick(teacher);

            // Add controls to the panel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(descriptionLabel);
            panel.Controls.Add(PricePerHour);
            panel.Controls.Add(submitButton);

            return panel;
        }

        private void SubmitButtonClick(Teacher teacher)
        {
            bool duplicate = false;

            foreach (GuruYangMengajar guru in StudentAppSession.student.Teachers)
            {
                if (guru.Id == teacher.Id)
                {
                    duplicate = true;
                    break;
                }
            }

            if (!duplicate)
            {
                // Add to StudentAppSession
                StudentAppSession.student.Teachers.Add(
                new GuruYangMengajar
                {
                   Id = teacher.Id,
                });
                StudentAppSession.UpdateStudent();

                // Add to TeacherAppSession
                TeacherAppSession.teacher = teacher;
                TeacherAppSession.teacher.Subjects[0].Students.Add(
                    new SiswaYangDiajar
                    {
                        StudentId = StudentAppSession.student.Id,
                    });
                TeacherAppSession.UpdateTeacher();
                TeacherAppSession.Reset();
            }
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
