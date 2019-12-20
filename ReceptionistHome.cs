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
    public partial class ReceptionistHome : Form
    {
        public ReceptionistHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecepionistBook RB = new RecepionistBook();
            RB.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPatient AP = new AddPatient();
            AP.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rooms R = new Rooms();
            R.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            changePass cp = new changePass("E");
            cp.Show();
            Close(); 
            
        }
    }
}
