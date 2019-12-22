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
    public partial class ManagerMain : Form
    {
        public ManagerMain()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StatisticsParent sp = new StatisticsParent();
            sp.Show();
            Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginPage l = new LoginPage();
            l.Show();
            Close(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changePass cp = new changePass("E");
            cp.Show();
            Close();
        }
    }
}
