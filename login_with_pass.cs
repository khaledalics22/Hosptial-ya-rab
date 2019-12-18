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
            }
            else if (type == "manager")
            {
                if (pass.Equals(c.getPassOf(ssn, "M")))
                {
                    Manager m = new Manager();
                    m.Show();
                    Close();
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
            }
            else if (type == "pharmacist")
            {
                if (pass.Equals(c.getPassOf(ssn, "PH")))
                {
                    Pharmacist m = new Pharmacist();
                    m.Show();
                    Close();
                }
            }
        }
    }
}
