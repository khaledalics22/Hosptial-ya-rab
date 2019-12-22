using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_ISA
{
    public partial class General_Stats : Form
    {
        public General_Stats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedDepStats md = new MedDepStats();
            md.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NonMedDepStats nd = new NonMedDepStats();
            nd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManagerMain m = new ManagerMain();
            m.Show();
            Close();
        }
    }
}
