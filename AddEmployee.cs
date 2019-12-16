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
    public partial class AddEmployee : Form
    {
        Controller controllerObj;
        Boolean NoDepartment;
        public AddEmployee()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DepartmentComboBox.DataSource = controllerObj.getAllDepartments();
            DepartmentComboBox.DisplayMember = "Dname";
            GenderComboBox.SelectedIndex = 0;
            ShiftComboBox.SelectedIndex = 0;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            NoDepartment = DepartmentCheckBox.Checked;
            DepartmentComboBox.Enabled = !NoDepartment;
            if (NoDepartment)
                DepartmentComboBox.Text = null;
            else
            {
                DepartmentComboBox.SelectedIndex = 0;
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            int Dno = (NoDepartment) ? -1 : (int)controllerObj.getDepartmentNumber(DepartmentComboBox.Text);
            try
            {
                if (!(SalaryTextBox.Text == "" || FnameTextBox.Text == "" || LnameTextBox.Text == ""
                    || AgeTextBox.Text == "" || JobTextBox.Text == "" || PhoneTextBox.Text == ""))
                {
                    int r = controllerObj.InsertEmployee(Convert.ToInt32(SSNTextBox.Text), FnameTextBox.Text,
                        LnameTextBox.Text, Convert.ToInt32(AgeTextBox.Text),
                       GenderComboBox.Text, Convert.ToInt32(SalaryTextBox.Text), CertificateTextBox.Text, JobTextBox.Text,
                       PhoneTextBox.Text, ShiftComboBox.Text, Dno);

                    if (r > 0)
                    {
                        MessageBox.Show("Inserted Successfully");
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
