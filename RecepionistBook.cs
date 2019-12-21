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
        Controller contobj = new Controller();
        string Fname = "-1";
        string Lname = "-1";
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
                Fname = selRow.Cells[0].Value.ToString();    //get cel[0] >> which is location of Fname
                Lname = selRow.Cells[1].Value.ToString();    //get cel[1] >> which is location of Lname
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Fname != "-1" && Lname != "-1")
            {
                ReceptionistDoctorInfo RDI = new ReceptionistDoctorInfo(Fname, Lname);
                RDI.Show();
                Close();
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
