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
    public partial class Rooms : Form
    {
        int rid = -1;
        Controller contobj = new Controller();
        public Rooms()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(textBox1.Text) >= DateTime.Parse(textBox2.Text))
                MessageBox.Show("Please,enter valid values");
            else
            {
                DataTable dt = contobj.getavailablerooms(textBox1.Text, textBox2.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rid == -1) MessageBox.Show("Please,choose room");
            else {
                contobj.AddReservation(Convert.ToInt32(textBox3.Text), rid, textBox1.Text, textBox2.Text);
                Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexi = e.RowIndex;     //get clicked row index
            if (indexi >= 0)               //check if this row in table
            {
                DataGridViewRow selRow = dataGridView1.Rows[indexi];    //store row
                rid = Convert.ToInt32(selRow.Cells[0].Value.ToString());    
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rooms_Load(object sender, EventArgs e)
        {

        }
    }
}
