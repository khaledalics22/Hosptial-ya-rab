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
    public partial class EditDoctor : Form
    {
        Controller c;
        int Dssn;
        Queue<string> rooms = new Queue<string>();
        DataTable dt;
        int SelectedremoveClinic;     //store the selected room from AssignRoomGridView
        int SelectedRemoveRoom;
        string SelectedRemoveClinicSHift;
        public EditDoctor(int Dssn)
        {
            InitializeComponent();
            c = new Controller();
            this.Dssn = Dssn;
            // initialize the GUI with the old data of the nurse
            DocNewSSN.Text = Dssn.ToString();
            dt = c.selectDoctor(this.Dssn);
            DocFName.Text = dt.Rows[0]["Fname"].ToString();
            DocLName.Text = dt.Rows[0]["Lname"].ToString();
            DocPhone.Text = dt.Rows[0]["Phone"].ToString();
            DocAge.Text = dt.Rows[0]["Age"].ToString();
            DocCity.Text = dt.Rows[0]["City"].ToString();
            DocStreet.Text = dt.Rows[0]["Street"].ToString();
            DocHouseNum.Text = dt.Rows[0]["House_Num"].ToString();
            DocSalary.Text = dt.Rows[0]["Salary"].ToString();
            DocShiftCombo.SelectedItem = dt.Rows[0]["Shift_From"].ToString();
            DocClinicShiftsGrid.DataSource = c.getDoctorClinic(Dssn);

            DocDepCombo.DataSource = c.getAllDepartments();
            DocDepCombo.DisplayMember = "Dname";
            DocDepCombo.ValueMember = "Dnum";
            DocDepCombo.Refresh();
            string dep =  c.getDocDepartment(this.Dssn).Rows[0]["Dname"].ToString();
            //needs to be selected 
            
            foreach (DataRowView Row in DocDepCombo.Items)
            {
                if (Row["Dname"].ToString() == dep) DocDepCombo.SelectedItem = Row;

            }

            DocDepCombo.Refresh();
            // initially fill the combobox with the shifts of the clinic which can be selected
            DocClinicCombo.DataSource = c.getAllClinicsId();
            DocClinicCombo.DisplayMember = "CID";

            DocAvailableClinicShiftsCombo.DataSource = c.DoctorAvailableClinicShifts(Dssn);
            DocAvailableClinicShiftsCombo.DisplayMember = "StartTime";
           

            // initially fill the Nurse rooms and the rooms that can be assigned to the nurse
            DocCurrRoomsGrid.DataSource = c.getDoctorRooms(Dssn);
            DocAvailableRoomsCombo.DataSource = c.getAllRoomsID();
            DocAvailableRoomsCombo.DisplayMember = "RID";
            DocAvailableRoomsCombo.ValueMember = "RID";
            

            // disable the buttons till the user select any room
            AssignButton.Enabled = false;
            removeButton.Enabled = false;
            button1.Enabled = false;
            removeButton.Enabled = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(DocSalary.Text == "" || DocFName.Text == "" || DocLName.Text == ""
                    || DocAge.Text == "" || DocPhone.Text == "" ))
                {
                    int r = c.AddDoctor(Convert.ToInt32(DocNewSSN.Text.ToString()), DocFName.Text.ToString(),
                        DocLName.Text.ToString(), DocPhone.Text.ToString(), Convert.ToInt32(DocAge.Text.ToString()),
                        Convert.ToInt32(DocSalary.Text.ToString()), DocCity.Text.ToString(), DocStreet.Text.ToString(),
                        DocHouseNum.Text.ToString(),
                        DocShiftCombo.Text, Convert.ToInt32(DocDepCombo.SelectedValue.ToString()));
                    if (r > 0)
                    {
                        // assign clinic to the nurse
                        c.AddDoctorClinic(Convert.ToInt32(DocNewSSN.Text), Convert.ToInt32(DocClinicCombo.SelectedValue.ToString()),
                            DocAvailableClinicShiftsCombo.SelectedValue.ToString());
                        while (rooms.Count > 0)
                        {
                            c.AddDoctorRoom(Convert.ToInt32(DocNewSSN.Text.ToString()), Convert.ToInt32(rooms.Dequeue()));
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

        private void DocClinicCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocClinicCombo.DisplayMember = "CID";
            DocClinicCombo.ValueMember = "CID";
            DocClinicCombo.Refresh();
            DataTable shifts = c.DoctorAvailableClinicShifts(Convert.ToInt32(DocClinicCombo.SelectedValue.ToString()));
            if (shifts != null)
            {
                DocAvailableClinicShiftsCombo.DataSource = shifts;
                DocAvailableClinicShiftsCombo.DisplayMember = "StartTime";
                DocAvailableClinicShiftsCombo.ValueMember = "StartTime";
                DocAvailableClinicShiftsCombo.Refresh();
            }
        }

        private void DocAvailableRoomsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssignButton.Enabled = true;
            removeButton.Enabled = true;
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            if (!rooms.Contains(DocAvailableRoomsCombo.SelectedValue.ToString()))
            {
                rooms.Enqueue(DocAvailableRoomsCombo.SelectedValue.ToString());
                roomsAssigned.Text += DocAvailableRoomsCombo.SelectedValue.ToString() + ",";
            }
            else
            {
                MessageBox.Show("room is already assigned");
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            // needs to get the selected 
            int r = c.removeDoctorClinic(Dssn, SelectedremoveClinic,SelectedRemoveClinicSHift);    //remove room from the nurse
            // if done successfully refresh the GridViews and disable the buttons
            if (r > 0)
            {
                DocClinicShiftsGrid.DataSource = c.getDoctorClinic(Dssn);
                DocClinicCombo.DataSource = c.getDoctorClinic(Dssn);
                DocClinicCombo.DisplayMember = "CID";
                DocClinicCombo.ValueMember = "CID";

                DocClinicCombo.Refresh();
                DocClinicShiftsGrid.Refresh();
                AssignButton.Enabled = false;
            }
            else
                MessageBox.Show("Remove Failed");
        }

        private void DocClinicShiftsGrid_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            int indexi = e.RowIndex;     //get clicked row index
            if (indexi >= 0)               //check if this row in table
            {
                DataGridViewRow selRow = DocClinicShiftsGrid.Rows[indexi];    //store row
                SelectedremoveClinic = Convert.ToInt32(selRow.Cells[0].Value.ToString());
                SelectedRemoveClinicSHift = selRow.Cells[1].Value.ToString();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int r = c.removeDoctorRoom(Dssn, SelectedRemoveRoom);    //remove room from the nurse
            // if done successfully refresh the GridViews and disable the buttons
            if (r > 0)
            {
                DocCurrRoomsGrid.DataSource = c.getDoctorClinic(Dssn);
                DocAvailableRoomsCombo.DataSource = c.DoctorAvailableRooms(Dssn);
                DocAvailableRoomsCombo.DisplayMember = "RID";
                DocAvailableRoomsCombo.ValueMember = "RID";
                DocClinicCombo.Refresh();
                DocClinicShiftsGrid.Refresh();
                AssignButton.Enabled = false;
            }
            else
                MessageBox.Show("Remove Failed");
        }

        private void DocCurrRoomsGrid_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexi = e.RowIndex;     //get clicked row index
            if (indexi >= 0)               //check if this row in table
            {
                DataGridViewRow selRow = DocCurrRoomsGrid.Rows[indexi];    //store row
                SelectedRemoveRoom = Convert.ToInt32(selRow.Cells[0].Value.ToString());
                removeButton.Enabled = true;
            }
        }
    }
}
