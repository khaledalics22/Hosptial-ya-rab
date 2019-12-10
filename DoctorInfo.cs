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
    public partial class DoctorInfo : Form
    {
        public DoctorInfo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Explore ex = new Explore();
            ex.Show();
            Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.Show();
            Close(); 
        }
    }
}
