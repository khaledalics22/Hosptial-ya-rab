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
    public partial class ReceptionistDoctorInfo : Form
    {
        string time="-1";
        int dssn;
        Controller contobj;

        public ReceptionistDoctorInfo(string fname,string lname,int d)
        {
            contobj = new Controller();
            InitializeComponent();
            DataTable dt = contobj.getdocinfo(d);
            textBox2.Text = dt.Rows[0][0].ToString();//phone
            textBox3.Text = dt.Rows[0][1].ToString();//specialization
            object ts= dt.Rows[0][2];
            object ts2 = dt.Rows[0][3];
            textBox4.Text = ts.ToString();//shft_from
            textBox5.Text = ts2.ToString();//shift_to
            textBox1.Text = fname + " " + lname;//full name
            dssn= Convert.ToInt32(dt.Rows[0][4]);

            DataTable DT = contobj.getweekdates();
            comboBox1.DataSource = DT;
            comboBox1.DisplayMember = "date";
            comboBox1.Refresh();
        }

 
        private void button1_Click(object sender, EventArgs e)
  
        {

        }

        private void ReceptionistDoctorInfo_Load(object sender, EventArgs e)
        {

        }

 
        private void textBox1_TextChanged(object sender, EventArgs e)
  
        {

        }

 
        private void textBox2_TextChanged(object sender, EventArgs e)
  
        {

        }

 
        private void textBox4_TextChanged(object sender, EventArgs e)
  
        {

        }

 
        private void textBox5_TextChanged(object sender, EventArgs e)
  
        {

        }

 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
  
        {
            if (comboBox1.Text != "System.Data.DataRowView")
            {
                DataTable dt3 = contobj.selectdocshifts(dssn);
                object ts = dt3.Rows[0][0];
                object ts2 = dt3.Rows[0][1];
                string s = ts2.ToString();
                if (s == "00:00:00") s = "23:59:00";
                {
                    DateTime t = DateTime.Parse(s, System.Globalization.CultureInfo.CurrentCulture);
                    s = t.ToString("HH:mm:ss tt");
                }
                DataTable dt2 = contobj.aviapps(ts.ToString(), s.Substring(0,8), comboBox1.Text, dssn);
                dataGridView1.DataSource = dt2;
                dataGridView1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexi = e.RowIndex;     //get clicked row index
            if (indexi >= 0)               //check if this row in table
            {
                DataGridViewRow selRow = dataGridView1.Rows[indexi];    //store row
                time = selRow.Cells[0].Value.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || comboBox1.Text == "System.Data.DataRowView" || time == "-1") MessageBox.Show("Please,enter valid values");
            else
            {
                DateTime date = DateTime.Parse(time, System.Globalization.CultureInfo.CurrentCulture);
                string t = date.ToString("HH:mm:ss tt");
                date = date + TimeSpan.Parse("00:30:00");
                string t2 = date.ToString("HH:mm:ss tt");
                if (contobj.AddAppointment(dssn, Convert.ToInt32(textBox6.Text), comboBox1.Text, t.Substring(0, 8), t2.Substring(0, 8)) == 0) MessageBox.Show("Please,enter valid values");
                else { MessageBox.Show("Appointment was booked"); Close(); }
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

