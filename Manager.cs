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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginPage l = new LoginPage();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNurse ad = new AddNurse();
            ad.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddEmployee ed = new AddEmployee();
            ed.Show();
            Close();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
