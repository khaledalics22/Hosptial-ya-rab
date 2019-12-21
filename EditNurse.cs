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
    public partial class EditNurse : Form
    {
        Controller controllerObj;
        DataTable dt;               //store the old data of the nurse
        int Nssn;
        int SelectedAssignRoom;     //store the selected room from AssignRoomGridView
        int SelectedRemoveRoom;     //store the selected room from RemoveRoomGridView
        public EditNurse(int Nssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            this.Nssn = Nssn;

            // initialize the GUI with the old data of the nurse
            SSNTextBox.Text = Nssn.ToString();
            dt = controllerObj.selectNurse(this.Nssn);
            FnameTextBox.Text = dt.Rows[0]["Fname"].ToString();
            LnameTextBox.Text = dt.Rows[0]["Lname"].ToString();
            PhoneTextBox.Text = dt.Rows[0]["Phone"].ToString();
            AgeTextBox.Text = dt.Rows[0]["Age"].ToString();
            SalaryTextBox.Text = dt.Rows[0]["Salary"].ToString();
            ShiftComboBox.SelectedItem = dt.Rows[0]["Shift_From"].ToString();
            ClinicGridView.DataSource = controllerObj.getAllClinicsId();
            int CID = (int)controllerObj.GetNurseClinic(Nssn);
            
            // just to initially select the old value of the clinic from the gridView
            ClinicGridView.ClearSelection();
            foreach (DataGridViewRow row in ClinicGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (Convert.ToInt32(cell.Value.ToString()) == CID)
                        cell.Selected = true;
                }
            }
            // initially fill the combobox with the shifts of the clinic which can be selected
            ClinicShiftComboBox.DataSource = controllerObj.NurseAvailableClinicShifts(CID, dt.Rows[0]["Shift_From"].ToString(), Nssn);
            ClinicShiftComboBox.DisplayMember = "StartTime";
            
            // initially fill the Nurse rooms and the rooms that can be assigned to the nurse
            AssignRoomGridView.DataSource = controllerObj.AvailableNurseRooms(Nssn);
            RemoveRoomGridView.DataSource = controllerObj.getNurseRooms(Nssn);
            
            // disable the buttons till the user select any room
            AssignButton.Enabled = false;
            RemoveButton.Enabled = false;
        }

        private void EditNurse_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AssignRoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void RemoveRoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        //when the user click on any room put it in SelectedAssignRoom
        private void AssignRoomGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AssignButton.Enabled = true;    //Enable the AssignButton
            int indexi = e.RowIndex;     //get clicked row index
            if (indexi >= 0)               //check if this row in table
            {
                DataGridViewRow selRow = AssignRoomGridView.Rows[indexi];    //store row
                SelectedAssignRoom = Convert.ToInt32(selRow.Cells[0].Value.ToString());    //get cel[0] >> which is location of RID
            }
        }
        //when the user click on any room put it in SelectedRemoveRoom
        private void RemoveRoomGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RemoveButton.Enabled = true;
            int indexi = e.RowIndex;     //get clicked row index
            if (indexi >= 0)               //check if this row in table
            {
                DataGridViewRow selRow = RemoveRoomGridView.Rows[indexi];    //store row
                SelectedRemoveRoom = Convert.ToInt32(selRow.Cells[0].Value.ToString());    
            }
        }

        //Refresh the ClinicShiftComboBox when the user change the selected cell
        private void ClinicGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexi = e.RowIndex;     //get clicked row index
            if (indexi >= 0)               //check if this row in table
            {
                ClinicShiftComboBox.DataSource = controllerObj.NurseAvailableClinicShifts(Convert.ToInt32(ClinicGridView.CurrentCell.Value.ToString()),
                                                                                    ShiftComboBox.Text, Nssn);
                ClinicShiftComboBox.DisplayMember = "StartTime";
            }
            
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            int r = controllerObj.AddNurseRoom(Nssn, SelectedAssignRoom);   //assign room to the nurse
            // if done successfully refresh the GridViews and disable the buttons
            if (r > 0)
            {
                AssignRoomGridView.DataSource = controllerObj.AvailableNurseRooms(Nssn);
                RemoveRoomGridView.DataSource = controllerObj.getNurseRooms(Nssn);
                AssignRoomGridView.Refresh();
                RemoveRoomGridView.Refresh();
                AssignButton.Enabled = false;
                RemoveButton.Enabled = false;
            }
            else
                MessageBox.Show("Assign Failed");
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int r = controllerObj.RemoveNurseRoom(Nssn, SelectedRemoveRoom);    //remove room from the nurse
            // if done successfully refresh the GridViews and disable the buttons
            if (r > 0)
            {
                AssignRoomGridView.DataSource = controllerObj.AvailableNurseRooms(Nssn);
                RemoveRoomGridView.DataSource = controllerObj.getNurseRooms(Nssn);
                AssignRoomGridView.Refresh();
                RemoveRoomGridView.Refresh();
                AssignButton.Enabled = false;
                RemoveButton.Enabled = false;
            }
            else
                MessageBox.Show("Remove Failed");
        }

        // update the ClinicShiftComboBox when the shift changes
        private void ShiftComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ClinicGridView.CurrentCell != null)
            {
                ClinicShiftComboBox.DataSource = controllerObj.NurseAvailableClinicShifts(Convert.ToInt32(ClinicGridView.CurrentCell.Value.ToString()),
                                                                                    ShiftComboBox.Text, Nssn);
                ClinicShiftComboBox.DisplayMember = "StartTime";
            }
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // validate the data and Edit the nurse
            // try-catch for convertion from string to int
            try
            {
                if (!(SalaryTextBox.Text == "" || FnameTextBox.Text == "" || LnameTextBox.Text == ""
                    || AgeTextBox.Text == "" || PhoneTextBox.Text == "" || ClinicShiftComboBox.Text == ""))
                {
                    int r = controllerObj.EditNurse(Convert.ToInt32(SSNTextBox.Text), FnameTextBox.Text,
                        LnameTextBox.Text, PhoneTextBox.Text, Convert.ToInt32(AgeTextBox.Text), 
                        Convert.ToInt32(SalaryTextBox.Text), ShiftComboBox.Text);

                    if (r > 0)
                    {
                        // assign clinic to the nurse when updated
                        controllerObj.AddNurseClinic(Nssn, ClinicShiftComboBox.Text, Convert.ToInt32(ClinicGridView.CurrentCell.Value.ToString()));
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
