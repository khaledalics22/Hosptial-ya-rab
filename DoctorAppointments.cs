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
    
    public partial class DoctorAppointments : Form
    {
        int pssn = -1;
        string fname = "-1";
        string lname = "-1";
        string age = "-1";
        string date = "-1";
        string from = "-1";
        string to = "-1";
        int patientnum = 0;
        Controller contobj = new Controller();
        public DoctorAppointments()
        {
            InitializeComponent();
            DataTable dt = contobj.getweekdates();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "date";
            comboBox1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorPatientInfo DA = new DoctorPatientInfo(pssn,fname,lname,age,date,from,to);
            DA.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = contobj.selectappointmensbydate(comboBox1.Text.ToString());
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
            if (dt2!=null)
            {
                foreach (DataRow row in dt2.Rows)
                {
                    patientnum++;
                }
            }
            textBox1.Text = patientnum.ToString();
            patientnum = 0;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexi = e.RowIndex;     //get clicked row index
            if (indexi >= 0)               //check if this row in table
            {
                DataGridViewRow selRow = dataGridView1.Rows[indexi];    //store row
                fname = selRow.Cells[1].Value.ToString();    //get cel[0] >> which is location of Fname
                lname = selRow.Cells[2].Value.ToString();    //get cel[1] >> which is location of Lname
                age = selRow.Cells[3].Value.ToString();
                date = selRow.Cells[4].Value.ToString();
                from = selRow.Cells[5].Value.ToString();
                to = selRow.Cells[6].Value.ToString();
                pssn = Convert.ToInt32(selRow.Cells[0].Value.ToString());
            }
        }

        private void DoctorAppointments_Load(object sender, EventArgs e)
        {

        }
    }
}
