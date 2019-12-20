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
    public partial class Appoints : Form
    {
        public Appoints()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppointsInfo ai = new AppointsInfo();
            ai.Show();
            Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            changePass cp = new changePass("D");
            cp.Show();
            Close();
        }
    }
}
