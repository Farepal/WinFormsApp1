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
    public partial class Form6 : Form
    {
        public Form6()
        {
           InitializeComponent();
           
           label3.Text = StudentAppSession.student.Name;
           label4.Text = StudentAppSession.student.PhoneNumber;
           pictureBox1.ImageLocation = (StudentAppSession.student.ImageLink);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            form7.MdiParent = this.MdiParent;
            form7.Dock = DockStyle.Fill;
            this.Dispose();
        }
    }
}
