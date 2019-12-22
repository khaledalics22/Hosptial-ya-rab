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
    public partial class login_with_pass : Form
    {
        Controller c;
        public static string type;
        public login_with_pass(string t)
        {
            InitializeComponent();
            type = t;
            c = new Controller();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 ||
             textBox2.Text.Length == 0)
            {
                MessageBox.Show("invalid ESSN or Password");
                return; 
            }
            int ssn = Convert.ToInt32(textBox1.Text.ToString());
            string pass = textBox2.Text.ToString();
            if (type == "doctor")
            {   //check pass 
                if (pass.Equals(c.getPassOf(ssn, "D")))
                {
                    DoctorAppointments m = new DoctorAppointments();
                    m.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("invalid DSSN or Password");
                    return;
                }
            }
            else if (type == "manager")
            {
                if (pass.Equals(c.getPassOf(ssn, "M")))
                {
                    ManagerMain m = new ManagerMain();
                    m.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("invalid MSSN or Password");
                    return;
                }

            }
            else if (type == "receptionist")
            {
                if (pass.Equals(c.getPassOf(ssn, "R")))
                {
                    ReceptionistHome rh = new ReceptionistHome();
                    rh.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("invalid RSSN or Password");
                    return;
                }
            }
            else if (type == "pharmacist")
            {
                if (pass.Equals(c.getPassOf(ssn, "PH")))
                {
                    Pharmacist m = new Pharmacist();
                    m.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("invalid PH_SSN or Password");
                    return;
                }
            }
            else if (type == "P")
            {
                if (pass.Equals(c.getPassOf(ssn, "P")))
                {
                    Prescription pre = new Prescription(ssn);
                    pre.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("invalid P_SSN or Password");
                    return;
                }           }
        }
    }
}
