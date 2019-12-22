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
    public partial class ViewPatient : Form
    {
        Controller controllerObj;
        int Pssn;
        DataTable PatientInfo;
        public ViewPatient(int Pssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            this.Pssn = Pssn;
            SSNTextBox.Text = Pssn.ToString();
            PatientInfo = controllerObj.getPatientInfo(Pssn);
            NameTextBox.Text = PatientInfo.Rows[0]["Fname"].ToString() + " " + PatientInfo.Rows[0]["Lname"].ToString();
            PhoneTextBox.Text = PatientInfo.Rows[0]["Phone"].ToString();
            AgeTextBox.Text = (PatientInfo.Rows[0]["Age"] == null) ? "" : PatientInfo.Rows[0]["Age"].ToString();
            InsuranceTextBox.Text = (PatientInfo.Rows[0]["Insurance"] == null) ? "" : PatientInfo.Rows[0]["Insurance"].ToString();

            AddressTextBox.Text = (PatientInfo.Rows[0]["Street"] == null) ? "" : PatientInfo.Rows[0]["Street"].ToString() + " st. ";
            AddressTextBox.Text += (PatientInfo.Rows[0]["City"] == null) ? "" : PatientInfo.Rows[0]["City"].ToString();

            HistoryGridView.DataSource = controllerObj.patientHistory(Pssn);
        }
        public ViewPatient()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
