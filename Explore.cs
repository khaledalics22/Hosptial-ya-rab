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
    public partial class Explore : Form
    {
        public Explore()
        {
            InitializeComponent();
        }

        private void Explore_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            Close(); 
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoctorInfo dI = new DoctorInfo();
            dI.Show();
            Close(); 
        }
    }
}
