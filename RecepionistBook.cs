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
    public partial class RecepionistBook : Form
    {
        string fname = "-1";
        string lname = "-1";
        Controller contobj = new Controller();
        int dssn = -1;
        public RecepionistBook()
        {
            InitializeComponent();
            DataTable dt = contobj.SelectDep();
            //string s = dt.Rows[1]["Dname"].ToString();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Dname";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexi = e.RowIndex;     //get clicked row index
            if (indexi >= 0)               //check if this row in table
            {
                DataGridViewRow selRow = dataGridView1.Rows[indexi];    //store row
                dssn = Convert.ToInt32(selRow.Cells[0].Value.ToString());    //get cel[0] >> which is location of Dssn
                fname = selRow.Cells[1].Value.ToString();
                lname = selRow.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dssn!=-1)
            {
                ReceptionistDoctorInfo RDI = new ReceptionistDoctorInfo(fname, lname,dssn);
                RDI.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = contobj.SelectDoctoorsbyDepname(comboBox1.Text);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }

        private void RecepionistBook_Load(object sender, EventArgs e)
        {

        }
    }
}
