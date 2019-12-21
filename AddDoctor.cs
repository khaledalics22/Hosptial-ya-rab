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
    public partial class AddDoctor : Form
    {
        Controller c;
        Queue<string> rooms = new Queue<string>();
        public AddDoctor()
        {
            InitializeComponent();
            c = new Controller();
            // set list of departments
            depCombo.DataSource = c.getMedicineDeps();
            depCombo.DisplayMember = "Dname";
            depCombo.ValueMember = "Dnum";
            depCombo.Refresh();

            // set list of clinic numbers 
            comboBox3.DataSource = c.getAllClinicsId();
            comboBox3.DisplayMember = "CID";
            comboBox3.ValueMember = "CID";
            comboBox3.Refresh();

            //set list of rooms 

            DataTable rooms = c.getAllRoomsID();
            if (rooms != null)
            {
                comboBox4.DataSource = rooms;
                comboBox4.DisplayMember = "RID";
                comboBox4.ValueMember = "RID";
                comboBox4.Refresh();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            m.Show();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(DocSalary.Text == "" || DocFName.Text == "" || DocLName.Text == ""
                    || DocAge.Text == "" || DocPhone.Text == "" 
                   || DocCity.Text== "" || DocStreet.Text == "" ||DocHouseNum.Text ==""||comboBox3.SelectedValue==null
                   || comboBox5.SelectedValue==null||pass.Text==""))
                {

                    int r = c.AddDoctor(Convert.ToInt32(DocSSN.Text.ToString()), DocFName.Text.ToString(),
                        DocLName.Text.ToString(), DocPhone.Text.ToString(), Convert.ToInt32(DocAge.Text.ToString()),
                        Convert.ToInt32(DocSalary.Text.ToString()), DocCity.Text.ToString(), DocStreet.Text.ToString(),
                        DocHouseNum.Text.ToString(),
                        DocShiftFrom.SelectedItem.ToString(), Convert.ToInt32(depCombo.SelectedValue.ToString()),
                        pass.Text.ToString()) ;
                    if (r > 0)
                    {
                        // assign clinic to the nurse
                        c.AddDoctorClinic(Convert.ToInt32(DocSSN.Text), Convert.ToInt32(comboBox3.SelectedValue.ToString()),
                            comboBox5.SelectedValue.ToString());
                        while (rooms.Count > 0)
                        {
                            c.AddDoctorRoom(Convert.ToInt32(DocSSN.Text.ToString()), Convert.ToInt32(rooms.Dequeue()));
                        }
                    }
                    else
                        MessageBox.Show("Please Enter Valid Values");
                }
                else
                    MessageBox.Show("Please Enter Valid Values");
            }
            catch
            {
                MessageBox.Show("Please Enter Valid Values");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!rooms.Contains(comboBox4.SelectedValue.ToString()))
            {
                rooms.Enqueue(comboBox4.SelectedValue.ToString());
                roomsAssigned.Text += comboBox4.SelectedValue.ToString() + ",";
            }
            else {
                MessageBox.Show("room is already assigned");            
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////////////////////////////////////////////
            comboBox3.DisplayMember = "CID";
            comboBox3.ValueMember = "CID";
            comboBox3.Refresh();
            DataTable  shifts  = c.DoctorAvailableClinicShifts(Convert.ToInt32(comboBox3.SelectedValue.ToString()));
            if (shifts != null)
            {
                comboBox5.DataSource = shifts;
                comboBox5.DisplayMember = "StartTime";
                comboBox5.ValueMember = "StartTime";
                comboBox5.Refresh();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
