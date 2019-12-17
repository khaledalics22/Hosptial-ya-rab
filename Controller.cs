using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital_ISA
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        //select all doctors
        public DataTable SelectDoctors()
        {
            String StoredProcedureName = StoredProcedures.GetDocs;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //select all nurses
        public DataTable SelectNurses()
        {
            String StoredProcedureName = StoredProcedures.GetNurses;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //select all employees
        public DataTable SelectEmployees()
        {
            String StoredProcedureName = StoredProcedures.GetEmps;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //select all patients and diagnoses
        public DataTable SelectPatientsDiag()
        {
            String StoredProcedureName = StoredProcedures.GetAllPatDiag;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //delete emlopyee using ESSN
        public int DeleteEmployee(int id)
        {
            String StoredProcedureName = StoredProcedures.DeleteEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Essn", id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //delete doctor using DSSN
        public int DeleteDoctor(int id)
        {
            String StoredProcedureName = StoredProcedures.DeleteDoc;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dssn", id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //Delete nurse using NSSN 
        public int DeleteNurse(int id)
        {
            String StoredProcedureName = StoredProcedures.DeleteNurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nssn", id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //select all drugs
        public DataTable SelectAllDrugs()
        {
            String StoredProcedureName = StoredProcedures.AllDrugs;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //Select Empty Drugs
        public DataTable SelectEmptyDrugs()
        {
            String StoredProcedureName = StoredProcedures.EmptyDrugs;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //find drugs by name
        public DataTable SearchDrugs(string s)
        {
            String StoredProcedureName = StoredProcedures.FindDrugs;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", s);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //find empty drugs by name
        public DataTable SearchEmptyDrugs(string s)
        {
            String StoredProcedureName = StoredProcedures.FindEmptyDrugs;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", s);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
         //insert drugs
        public int InsertDrugs(int c,string n,int q,float p)
        {
            String StoredProcedureName = StoredProcedures.InsertDrug;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", c);
            Parameters.Add("@name", n);
            Parameters.Add("@q", q);
            Parameters.Add("@p", p);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //increase drug quantity
        public int AddQuantity(int c)
        {
            String StoredProcedureName = StoredProcedures.AddQuantity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", c);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }         
        //sell one item of drug 
        public int SellDrug(int c)
        {
            String StoredProcedureName = StoredProcedures.SellDrug;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", c);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //Add To List of sold drugs
        public int AddToSold(int c)
        {
            String StoredProcedureName = StoredProcedures.AddToSold;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", c);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        // insert the employee
        public int InsertEmployee(int ESSN, string Fname, string Lname, int Age, string Gender,
                                int Salary, string Certificate, string Job,
                                string Phone, string Shift_From, int Dno)
        {
            String StoredProcedureName = StoredProcedures.InsertEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ESSN", ESSN);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Age", Age);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Certificate", Certificate == "" ? Convert.DBNull:Certificate);
            Parameters.Add("@Job", Job);
            Parameters.Add("@Phone", Phone);
            // just for the error
            Shift_From = new DateTime(1, 1, 1, Convert.ToInt32(Shift_From.Substring(0, 2)), 0, 0).ToString("HH:mm:ss"); 
            Parameters.Add("@Shift_From", Shift_From);
            Parameters.Add("@Dno", Dno == -1 ? Convert.DBNull:Dno);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //takes the name of the department and return the number
        public object getDepartmentNumber(string Dname)
        {
            String StoredProcedureName = StoredProcedures.getDepartmentNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dname", Dname);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        //takes the number of the department and return the name
        public object getDepartmentName(int Dnum)
        {
            String StoredProcedureName = StoredProcedures.getDepartmentName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dnum", Dnum);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        // return all the departments names
        public DataTable getAllDepartments()
        {
            String StoredProcedureName = StoredProcedures.getAllDepartments;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        // return all the data for an employee
        public DataTable selectEmployee(int ESSN)
        {
            String StoredProcedureName = StoredProcedures.selectEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ESSN", ESSN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        // update employee data
        public int EditEmployee(int ESSN, string Fname, string Lname, int Age, string Gender,
                                int Salary, string Certificate, string Job,
                                string Phone, string Shift_From, int Dno)
        {
            String StoredProcedureName = StoredProcedures.EditEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ESSN", ESSN);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Age", Age);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Certificate", Certificate == "" ? Convert.DBNull : Certificate);
            Parameters.Add("@Job", Job);
            Parameters.Add("@Phone", Phone);
            Shift_From = new DateTime(1, 1, 1, Convert.ToInt32(Shift_From.Substring(0, 2)), 0, 0).ToString("HH:mm:ss");
            Parameters.Add("@Shift_From", Shift_From);
            Parameters.Add("@Dno", Dno == -1 ? Convert.DBNull : Dno);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        // return the rooms that can be assigned to the nurse
        public DataTable AvailableNurseRooms(int Nssn)
        {
            String StoredProcedureName = StoredProcedures.AvailableNurseRooms;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nssn", Nssn);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        // return all the data of the nurse
        public DataTable selectNurse(int Nssn)
        {
            String StoredProcedureName = StoredProcedures.selectNurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nssn", Nssn);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        // return the nurse rooms
        public DataTable getNurseRooms(int Nssn)
        {
            String StoredProcedureName = StoredProcedures.getNurseRooms;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nssn", Nssn);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        // return the nurse clinic
        public Object getNurseClinic(int Nssn)
        {
            String StoredProcedureName = StoredProcedures.getNurseClinic;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nssn", Nssn);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        // assign a room to the nurse
        public int AddNurseRoom(int Nssn, int RID)
        { 
            String StoredProcedureName = StoredProcedures.AddNurseRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nssn", Nssn);
            Parameters.Add("@RID", RID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        // remove a room from the nurse
        public int RemoveNurseRoom(int Nssn, int RID)
        {
            String StoredProcedureName = StoredProcedures.RemoveNurseRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nssn", Nssn);
            Parameters.Add("@RID", RID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        // return the available shifts of the clinic according to nurse shift and clinic empty shifts
        public DataTable NurseAvailableClinicShifts(int CID, string Shift, int Nssn = -1)
        {
            String StoredProcedureName = StoredProcedures.NurseAvailableClinicShifts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            
            Parameters.Add("@Nssn", Nssn == -1 ? Convert.DBNull:Nssn);
            Parameters.Add("@CID", CID);
            Shift = new DateTime(1, 1, 1, Convert.ToInt32(Shift.Substring(0, 2)), 0, 0).ToString("HH:mm:ss");
            Parameters.Add("@Shift", Shift);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        // return the Ids of all clinics
        public DataTable getAllClinicsId()
        {
            String StoredProcedureName = StoredProcedures.getAllClinicsId;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        // update the nurse data
        public int EditNurse(int Nssn, string Fname, string Lname, string Phone, int Age, int Salary, string Shift_From)
        {
            String StoredProcedureName = StoredProcedures.EditNurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nssn", Nssn);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Phone", Phone);
            Parameters.Add("@Age", Age);
            Parameters.Add("@Salary", Salary);
            Shift_From = new DateTime(1, 1, 1, Convert.ToInt32(Shift_From.Substring(0, 2)), 0, 0).ToString("HH:mm:ss");
            Parameters.Add("@Shift_From", Shift_From);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        // assign a clinic to the nurse and if there is  a clinic assigned to nurse remove it first
        public int AddNurseClinic(int Nssn, string StartTime, int CID)
        {
            String StoredProcedureName = StoredProcedures.AddNurseClinic;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nssn", Nssn);
            StartTime = new DateTime(1, 1, 1, Convert.ToInt32(StartTime.Substring(0, 2)), 0, 0).ToString("HH:mm:ss");
            Parameters.Add("@StartTime", StartTime);
            Parameters.Add("@CID", CID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        // add a new nurse to the data
        public int AddNurse(int Nssn, string Fname, string Lname, string Phone, int Age, int Salary, string Shift_From)
        {
            String StoredProcedureName = StoredProcedures.AddNurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nssn", Nssn);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Phone", Phone);
            Parameters.Add("@Age", Age);
            Parameters.Add("@Salary", Salary);
            Shift_From = new DateTime(1, 1, 1, Convert.ToInt32(Shift_From.Substring(0, 2)), 0, 0).ToString("HH:mm:ss");
            Parameters.Add("@Shift_From", Shift_From);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
    }
}
