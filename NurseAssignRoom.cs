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
    public partial class NurseAssignRoom : Form
    {
        Controller controllerObj;
        int Nssn;
        int SelectedAssignRoom;
        int SelectedRemoveRoom;
        public NurseAssignRoom(int Nssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            this.Nssn = Nssn;
            SSNTextBox.Text = Nssn.ToString();
            AssignRoomGridView.DataSource = controllerObj.AvailableNurseRooms(Nssn);
            RemoveRoomGridView.DataSource = controllerObj.getNurseRooms(Nssn);
            AssignButton.Enabled = false;
            RemoveButton.Enabled = false;
        }

        private void AssignRoomGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AssignButton.Enabled = true;
            int indexi = e.RowIndex;     //get clicked row index
            if (indexi >= 0)               //check if this row in table
            {
                DataGridViewRow selRow = AssignRoomGridView.Rows[indexi];    //store row
                SelectedAssignRoom = Convert.ToInt32(selRow.Cells[0].Value.ToString());    //get cel[0] >> which is location of RID
            }
        }
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


        private void AssignButton_Click(object sender, EventArgs e)
        {
            int r = controllerObj.AddNurseRoom(Nssn, SelectedAssignRoom);
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
            int r = controllerObj.RemoveNurseRoom(Nssn, SelectedRemoveRoom);
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

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added Successfully");
            Close();
        }
    }
}
