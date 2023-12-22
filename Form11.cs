using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9("FISIKA");
            form9.MdiParent = this.MdiParent;
            form9.Dock = DockStyle.Fill;
            form9.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9("KIMIA");
            form9.MdiParent = this.MdiParent;
            form9.Dock = DockStyle.Fill;
            form9.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9("BAHASA INDONESIA");
            form9.MdiParent = this.MdiParent;
            form9.Dock = DockStyle.Fill;
            form9.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9("MATEMATIKA");
            form9.MdiParent = this.MdiParent;
            form9.Dock = DockStyle.Fill;
            form9.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9("BIOLOGI");
            form9.MdiParent = this.MdiParent;
            form9.Dock = DockStyle.Fill;
            form9.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9("BAHASA INGGRIS");
            form9.MdiParent = this.MdiParent;
            form9.Dock = DockStyle.Fill;
            form9.Show();
            this.Dispose();
        }
    }
}
