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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            login_with_pass lwp = new login_with_pass(comboBox1.SelectedItem.ToString().ToLower());
            lwp.Show();

        }
    }
}
