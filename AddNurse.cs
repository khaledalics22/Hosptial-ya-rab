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
    public partial class AddNurse : Form
    {
        Controller controllerObj;
        public AddNurse()
        {
            InitializeComponent();
            controllerObj = new Controller();
            ClinicGridView.DataSource = controllerObj.getAllClinicsId();
            ClinicShiftComboBox.Enabled = false;
            ShiftComboBox.SelectedIndex = 0;

        }

        private void ClinicGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClinicShiftComboBox.Enabled = true;
            int indexi = e.RowIndex;     //get clicked row index
            if (indexi >= 0)               //check if this row in table
            {
                ClinicShiftComboBox.DataSource = controllerObj.NurseAvailableClinicShifts(Convert.ToInt32(ClinicGridView.CurrentCell.Value.ToString()),
                                                                                    ShiftComboBox.Text);
                ClinicShiftComboBox.DisplayMember = "StartTime";
            }

        }

        private void ShiftComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClinicGridView.CurrentCell != null && ShiftComboBox.Enabled)
            {
                ClinicShiftComboBox.DataSource = controllerObj.NurseAvailableClinicShifts(Convert.ToInt32(ClinicGridView.CurrentCell.Value.ToString()),
                                                                                    ShiftComboBox.Text);
                ClinicShiftComboBox.DisplayMember = "StartTime";
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(SalaryTextBox.Text == "" || FnameTextBox.Text == "" || LnameTextBox.Text == ""
                    || AgeTextBox.Text == "" || PhoneTextBox.Text == "" || 
                    ClinicShiftComboBox.Text == "" || ClinicGridView.CurrentCell.Value == null))
                {
                    int r = controllerObj.AddNurse(Convert.ToInt32(SSNTextBox.Text), FnameTextBox.Text,
                        LnameTextBox.Text, PhoneTextBox.Text, Convert.ToInt32(AgeTextBox.Text),
                        Convert.ToInt32(SalaryTextBox.Text), ShiftComboBox.Text);

                    if (r > 0)
                    {
                        controllerObj.AddNurseClinic(Convert.ToInt32(SSNTextBox.Text), ClinicShiftComboBox.Text,
                                                Convert.ToInt32(ClinicGridView.CurrentCell.Value.ToString()));
                        NurseAssignRoom n = new NurseAssignRoom(Convert.ToInt32(SSNTextBox.Text));
                        n.Show();
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
