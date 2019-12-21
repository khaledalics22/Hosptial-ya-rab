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
    public partial class AppointsInfo : Form
    {
        Controller c;
        int pssn;
        public AppointsInfo(int pssn)
        {
            InitializeComponent();
            c = new Controller();
            this.pssn = pssn; 
            dataGridView1.DataSource = c.patientAppoints(pssn);
            comboBox1.DataSource = c.patientAppoints(pssn);
            comboBox1.DisplayMember = "AID";

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Appoints a = new Appoints();
            a.Show();
            Close();
        }

        private void AppointsInfo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c.cancelAppoint(Convert.ToInt32(comboBox1.Text.ToString())) == 0)
            {
                MessageBox.Show("fialed to cancel");
            }
            {
                dataGridView1.DataSource = c.patientAppoints(pssn);
                comboBox1.DataSource = c.patientAppoints(pssn);
                comboBox1.DisplayMember = "AID";
                MessageBox.Show("Appoint "+ comboBox1.Text.ToString() + " has been canceled");             
            }
        }
    }
}
