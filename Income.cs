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
    public partial class Income : Form
    {
        Controller ctr;
        public Income()
        {
            InitializeComponent();
            ctr = new Controller();
            comboBox3.SelectedItem = "Departments";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox3.SelectedItem.ToString()=="Departments")
            {
                dataGridView1.DataSource = ctr.StatDeps(dateTimePicker1.Value.ToString()
                    , dateTimePicker2.Value.ToString());
                dataGridView1.Refresh();
            }
            else if (comboBox3.SelectedItem.ToString() == "Pharmacy")
            {
                dataGridView1.DataSource = ctr.StatPhar(dateTimePicker1.Value.ToString()
                    , dateTimePicker2.Value.ToString());
                dataGridView1.Refresh();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManagerMain m = new ManagerMain();
            m.Show();
            Close();
        }
    }
}
