using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
           InitializeComponent();
           
           label3.Text = TeacherAppSession.teacher.Name;
           label4.Text = TeacherAppSession.teacher.PhoneNumber;
           label5.Text = TeacherAppSession.teacher.Description;
           pictureBox1.ImageLocation = (TeacherAppSession.teacher.ImageLink);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            form5.MdiParent = this.MdiParent;
            form5.Dock = DockStyle.Fill;
            this.Dispose();
        }
    }
}
