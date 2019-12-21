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
    public partial class DoctorPatientInfo : Form
    {
        int p;
        string d;
        Controller contobj = new Controller();
        public DoctorPatientInfo(int pssn,string fname, string lname, string age, string date, string from, string to)
        {
            p = pssn;
            d = date;
            InitializeComponent();
            textBox1.Text = fname+" "+lname;
            textBox2.Text = age;
            textBox4.Text = date.Substring(0,10);
            textBox5.Text = from;
            textBox6.Text = to;
            DataTable dt = contobj.GetPateintDependents(pssn);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoctorPatientInfo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            contobj.Insertdiagnos(p, textBox7.Text);
            contobj.InsertPateintMedicine(p, d, textBox5.Text, textBox6.Text, textBox8.Text);
            ReceptionistHome RH = new ReceptionistHome();
            RH.Show();
            Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
