using MongoDB.Bson;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            // avoid flickering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            // end of avoid flickering
            InitializeComponent();
            this.FormClosed += Form2_FormClosed;
            this.AcceptButton = signUpButton;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void emailRegisterLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordRegisterLabel_Click(object sender, EventArgs e)
        {

        }

        private void rolesRegisterLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void emailRegisterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordRegisterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string emailRegister = emailRegisterTextBox.Text;
            string passwordRegister = passwordRegisterTextBox.Text;

            if (emailRegister != "" && passwordRegister != "")
            {

                IMongoCollection<Student> studentCollection = StudentsCollection.Instance.Collection;
                IMongoCollection<Teacher> teacherCollection = TeachersCollection.Instance.Collection;

                var filterTeacher = Builders<Teacher>.Filter.Eq("email", emailRegister);
                var filterStudent = Builders<Student>.Filter.Eq("email", emailRegister);

                var foundTeacher = teacherCollection.Find(filterTeacher).FirstOrDefault();
                var foundStudent = studentCollection.Find(filterStudent).FirstOrDefault();

                if (foundTeacher != null)
                {
                    MessageBox.Show("Email sudah terdaftar sebagai guru, silahkan gunakan email lain");
                    return;
                }
                else if (foundStudent != null)
                {
                    MessageBox.Show("Email sudah terdaftar sebagai siswa, silahkan gunakan email lain");
                    return;
                }
                else
                {
                    if (rolesRegister.Text == "teacher")
                    {
                        teacherCollection = TeachersCollection.Instance.Collection;
                        Teacher newTeacher = new Teacher
                        {
                            Email = emailRegister,
                            Password = passwordRegister,
                            Roles = rolesRegister.Text,
                        };
                        teacherCollection.InsertOne(newTeacher);
                    }
                    else if (rolesRegister.Text == "student")
                    {
                        studentCollection = StudentsCollection.Instance.Collection;
                        Student newStudent = new Student
                        {
                            Email = emailRegister,
                            Password = passwordRegister,
                            Roles = rolesRegister.Text,
                        };
                        studentCollection.InsertOne(newStudent);
                    }
                    else
                    {
                        MessageBox.Show("Isi dengan benar");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Isi dengan benar");
                return;
            }

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
