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
        Controller c;
        private int DSSN;
        public Explore()
        {
            InitializeComponent();
            c = new Controller();
            comboBox1.DataSource =c.getMedicineDeps();
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Dnum";
            comboBox1.Refresh();

            dataGridView1.DataSource = c.getDocsAtDep(Convert.ToInt32(comboBox1.SelectedValue.ToString()));
            dataGridView1.Refresh();

            button2.Enabled = false;
            
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
            DoctorInfo dI = new DoctorInfo(DSSN);
            dI.Show();
            Close(); 
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexi = e.RowIndex;     //get clicked row index
            if (indexi >= 0)               //check if this row in table
            {
                DataGridViewRow selRow = dataGridView1.Rows[indexi];    //store row
                DSSN = Convert.ToInt32(selRow.Cells[0].Value.ToString());
                button2.Enabled = true;
              
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return; 
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Dnum";
            comboBox1.Refresh();
            DataTable docs = c.getDocsAtDep(Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                dataGridView1.DataSource = docs;
                dataGridView1.Refresh();
            if (docs == null)
            {
                MessageBox.Show("sorry there are no available doctors in this department");
                comboBox1.SelectedIndex = 0; 
            }
            button2.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorInfo di = new DoctorInfo(DSSN);
            di.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                MessageBox.Show("you can't leave the search box empty.please, enter the last name of the doctor you want");

                return;
            }
            DataTable dt = c.selectDocByName(textBox1.Text.ToString());
            dataGridView1.DataSource= dt;
            dataGridView1.Refresh();
            if (dt == null)
            {
                MessageBox.Show("sorry, there are no available doctors whith last name \""+textBox1.Text.ToString()+"\"");
                comboBox1.SelectedIndex = 0;
            }
            else
            comboBox1.SelectedIndex = -1;
        }
    }
}
