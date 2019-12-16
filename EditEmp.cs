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
    public partial class EditEmp : Form
    {
        Controller controllerObj;
        int ESSN;
        Boolean NoDepartment;
        DataTable dt;
        string Dname;
        public EditEmp(int ESSN)
        {
            InitializeComponent();
            controllerObj = new Controller();
            this.ESSN = ESSN;
            dt = controllerObj.selectEmployee(this.ESSN);
            DepartmentComboBox.DataSource = controllerObj.getAllDepartments();
            DepartmentComboBox.DisplayMember = "Dname";
            DepartmentComboBox.ValueMember = "Dname";
            SSNTextBox.Text = ESSN.ToString();

            FnameTextBox.Text = dt.Rows[0]["Fname"].ToString();
            LnameTextBox.Text = dt.Rows[0]["Lname"].ToString();
            AgeTextBox.Text = dt.Rows[0]["Age"].ToString();
            GenderComboBox.SelectedItem = dt.Rows[0]["Gender"].ToString();
            SalaryTextBox.Text = dt.Rows[0]["Salary"].ToString();
            CertificateTextBox.Text = (dt.Rows[0]["Certificate"] == DBNull.Value) ? "" : dt.Rows[0][6].ToString();
            JobTextBox.Text = dt.Rows[0]["Job"].ToString();
            PhoneTextBox.Text = dt.Rows[0]["Phone"].ToString();
            ShiftComboBox.SelectedItem = dt.Rows[0]["Shift_From"].ToString().Substring(0, 5);
            if (dt.Rows[0]["Dno"] == DBNull.Value)
            {
                DepartmentComboBox.Text = null;
                DepartmentCheckBox.Checked = true;
                NoDepartment = true;
                DepartmentComboBox.Enabled = false;
                Dname = null;
            }
            else Dname = controllerObj.getDepartmentName(Convert.ToInt32(dt.Rows[0]["Dno"].ToString())).ToString();
            if(Dname != null)
                DepartmentComboBox.SelectedValue = Dname;
        }

        private void EditEmp_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            NoDepartment = DepartmentCheckBox.Checked;
            DepartmentComboBox.Enabled = !NoDepartment;
            if (NoDepartment)
                DepartmentComboBox.Text = null;
            else
            {
                DepartmentComboBox.SelectedValue = Dname;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Dno = (NoDepartment)? -1: (int)controllerObj.getDepartmentNumber(DepartmentComboBox.Text);
            try
            {
                if (!(SalaryTextBox.Text == "" || FnameTextBox.Text == "" || LnameTextBox.Text == ""
                    || AgeTextBox.Text == "" || JobTextBox.Text == "" || PhoneTextBox.Text == ""))
                {
                    int r = controllerObj.EditEmployee(Convert.ToInt32(SSNTextBox.Text), FnameTextBox.Text,
                        LnameTextBox.Text, Convert.ToInt32(AgeTextBox.Text),
                       GenderComboBox.Text, Convert.ToInt32(SalaryTextBox.Text), CertificateTextBox.Text, JobTextBox.Text,
                       PhoneTextBox.Text, ShiftComboBox.Text, Dno);

                    if (r > 0)
                    {
                        MessageBox.Show("Updated Successfully");
                        Close();
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
    }
}
