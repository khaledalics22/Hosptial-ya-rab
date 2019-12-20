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
    public partial class Book : Form
    {
        private string date; 
        private int DSSN ;
        Controller c; 
        public Book(int DSSN, string date)
        {
            InitializeComponent();
            c = new Controller();
            this.date = date;
            this.DSSN = DSSN; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Explore ex = new Explore();
            ex.Show();
            Close(); 
        }

        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(patiendFName.Text == "" || PatientPhone.Text == "" || patiendLName.Text == ""
                || patientSSn.Text == ""))
            {

                if (c.selectPatient(Convert.ToInt32(patientSSn.Text.ToString())) == null)
                {
                    c.insertPatient(Convert.ToInt32(patientSSn.Text.ToString()), patiendFName.Text,
                       patiendLName.Text, PatientPhone.Text,Pass.Text);
                   
                }
                c.AddNewAppointment(DSSN, Convert.ToInt32(patientSSn.Text.ToString()),date);

            }
        }
    }
}
