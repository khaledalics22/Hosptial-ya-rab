using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_ISA
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Explore ex = new Explore();
            ex.Show();
            Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appoints a = new Appoints();
            a.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prescription pre = new Prescription();
            pre.Show();
            Close(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            Close(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            changePass cp = new changePass("P");
            cp.Show();
            Close();
        }
    }
}
