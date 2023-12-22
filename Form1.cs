using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // avoid flickering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            // end of avoid flickering
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
            this.AcceptButton = loginButton;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void emailLoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void passwordLoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var filterTeacher = Builders<Teacher>.Filter.And(
                Builders<Teacher>.Filter.Eq("email", emailLoginTextBox.Text),
                Builders<Teacher>.Filter.Eq("password", passwordLoginTextBox.Text)
            );

            var filterStudent = Builders<Student>.Filter.And(
                Builders<Student>.Filter.Eq("email", emailLoginTextBox.Text),
                Builders<Student>.Filter.Eq("password", passwordLoginTextBox.Text)
            );

            var teacher = TeachersCollection.Instance.Collection.Find(filterTeacher).FirstOrDefault();
            var student = StudentsCollection.Instance.Collection.Find(filterStudent).FirstOrDefault();

            if (teacher != null)
            {
                TeacherAppSession.Initialize(teacher);
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else if (student != null)
            {
                StudentAppSession.Initialize(student);
                Form8 form8 = new Form8();
                form8.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal");
            }
        }

        private void passwordLoginTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void registerLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void emailLoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLoginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}