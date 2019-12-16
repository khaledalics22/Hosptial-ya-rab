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
    public partial class Manager : Form
    {
        Controller controllerObj;
        int SelcetedDssn = -1;        //store selected SSN for any staff, initially with -1 because no item is selected at first
        int SelcetedNssn = -1;
        int SelcetedEssn = -1;

        public Manager()
        {
            InitializeComponent();
            controllerObj = new Controller();
            comboBox1.SelectedItem = "Doctors";     //initially set comboBox with doctors
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginPage l = new LoginPage();
            l.Show();
        }

        //if add button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            //check all comboBox, then go to corespondant SSN to update
            if (comboBox1.SelectedItem.ToString() == "Doctors")
            {
                AddDoctor ed = new AddDoctor();
                ed.Show();
            }

            else if (comboBox1.SelectedItem.ToString() == "Nurses")
            {
                AddNurse en = new AddNurse();
                en.Show();
            }


            else if (comboBox1.SelectedItem.ToString() == "Employees")
            {
                AddEmployee ee = new AddEmployee();
                ee.Show();
            }

        }
        //if update is clicked
        private void button4_Click(object sender, EventArgs e)
        {       
            //check all comboBox, then go to corespondant SSN to update
            if (comboBox1.SelectedItem.ToString() == "Doctors")
            {
                EditDoctor ed = new EditDoctor();
                ed.Show();
            }

            else if (comboBox1.SelectedItem.ToString() == "Nurses")
            {
                EditNurse en = new EditNurse();
                en.Show();
            }
                
            else if (comboBox1.SelectedItem.ToString() == "Employees")
            {
                EditEmp ee = new EditEmp();
                ee.Show();
            }

        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //check if comboBox item is chnaged
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if doctor >> fill gridView with all doctors
            //make all buttons enable to provide manager his functionalities 
            if (comboBox1.SelectedItem.ToString() == "Doctors")
            {
                dataGridView1.DataSource = controllerObj.SelectDoctors();
                dataGridView1.Refresh();
                button2.Enabled = true;
                button4.Enabled = true;
                button1.Enabled = true;
                button5.Enabled = false;

            }
            if (comboBox1.SelectedItem.ToString() == "Nurses")
            {
                dataGridView1.DataSource = controllerObj.SelectNurses();
                dataGridView1.Refresh();
                button2.Enabled = true;
                button4.Enabled = true;
                button1.Enabled = true;
                button5.Enabled = false;
            }

            if (comboBox1.SelectedItem.ToString() == "Employees")
            {
                dataGridView1.DataSource = controllerObj.SelectEmployees();
                dataGridView1.Refresh();

                button2.Enabled = true;
                button4.Enabled = true;
                button1.Enabled = true;
                button5.Enabled = false;
            }
            //if patient >> fill gridView with all patients info.
            //then make all buttons uneditable (manager can't update or add or delete patients)
            if (comboBox1.SelectedItem.ToString() == "Patients")
            {
                dataGridView1.DataSource = controllerObj.SelectPatientsDiag();
                dataGridView1.Refresh();
                button2.Enabled = false;
                button4.Enabled = false;
                button1.Enabled = false;
                button5.Enabled = true;
            }
        }

        //if any row is clicked in dataGridView 
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //check if comboBox has value Doctor
            if (comboBox1.SelectedItem.ToString() == "Doctors")
            {
                int indexi = e.RowIndex;     //get clicked row index
                if(indexi>=0)               //check if this row in table
                {
                    DataGridViewRow selRow = dataGridView1.Rows[indexi];    //store row
                    SelcetedDssn = Convert.ToInt32(selRow.Cells[0].Value.ToString());    //get cel[0] >> which is location of DSSN
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Nurses")
            {
                int indexi = e.RowIndex;
                if (indexi >= 0) 
                {
                    DataGridViewRow selRow = dataGridView1.Rows[indexi];
                    SelcetedNssn = Convert.ToInt32(selRow.Cells[0].Value.ToString());
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Employees")
            {
                int indexi = e.RowIndex;
                if (indexi >= 0)
                {
                    DataGridViewRow selRow = dataGridView1.Rows[indexi];
                    SelcetedEssn = Convert.ToInt32(selRow.Cells[0].Value.ToString());
                }
            }
            //if there's no selected item >> make SSN=-1 (to avoid deleting previous selected row)
            else
            {
                SelcetedDssn = -1;
                SelcetedEssn = -1;
                SelcetedNssn = -1;
            }
        }

        //if delete button is clicked
        private void button2_Click_1(object sender, EventArgs e)
        {
            //check all comboBox, then delete corespondant SSN
            if (comboBox1.SelectedItem.ToString() == "Doctors")
            {
                int r = controllerObj.DeleteDoctor(SelcetedDssn);
                if (r > 0)
                {
                    MessageBox.Show("Doctor Deleted Sucessfully");
                    dataGridView1.DataSource = controllerObj.SelectDoctors();
                    dataGridView1.Refresh();
                }
                else
                    MessageBox.Show("Please, Select Doctor");
            }

            else if (comboBox1.SelectedItem.ToString() == "Nurses")
            {
                int r = controllerObj.DeleteNurse(SelcetedNssn);
                if (r > 0)
                {
                    MessageBox.Show("Nurse Deleted Sucessfully");
                    dataGridView1.DataSource = controllerObj.SelectNurses();
                    dataGridView1.Refresh();
                }
                else
                    MessageBox.Show("Please, Select Nurse");
            }

            else if (comboBox1.SelectedItem.ToString() == "Employees")
            {
                int r = controllerObj.DeleteEmployee(SelcetedEssn);
                if (r > 0)
                {
                    MessageBox.Show("Employee Deleted Sucessfully");
                    dataGridView1.DataSource = controllerObj.SelectEmployees();
                    dataGridView1.Refresh();
                }
                else
                    MessageBox.Show("Please, Select Employee");
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewPatient vp = new ViewPatient();
            vp.Show();
        }
    }
}
