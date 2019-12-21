//using DBapplication;
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
    public partial class AddPatient : Form
    {
        /*int age = -1;*/
        Controller contobj = new Controller();
        public AddPatient()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "" || textBox1.Text == "" || textBox10.Text == ""
                || textBox5.Text == "")
                MessageBox.Show("please,enter valid values");
            else
            {
                contobj.AddPateint(Convert.ToInt32(textBox9.Text), textBox1.Text, textBox10.Text
                    , textBox4.Text, Convert.ToInt32(textBox2.Text), textBox5.Text, textBox6.Text, textBox11.Text);
                Close();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
