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
            Parameters.Add("@EndDate", DateTime.Today.ToString("yyyy-MM-dd"));
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
                                string Phone, string Shift_From, int Dno,string pass)
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
            Parameters.Add("@PASS", pass);
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
        public Object GetNurseClinic(int Nssn)
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
        
              public int cancelAppoint(int AID)
        {
            String StoredProcedureName = StoredProcedures.cancelAppoint;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AID", AID);
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

        //Get all patient appointments with diagnoses(old diagnosis)
        public DataTable GetPrevAppoint(int pssn)
        {
            String StoredProcedureName = StoredProcedures.GetPrevAppoint;
 
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
 
            Parameters.Add("@PSSN", pssn);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //Get all appoinment medicines
        public DataTable GetApointMed(int aID)
        {
            String StoredProcedureName = StoredProcedures.GetAppointMed;
 
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
 
            Parameters.Add("@AID", aID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public string GetAppDiag(int aID)
        {
            String StoredProcedureName = StoredProcedures.GetAppDiagnose;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AID", aID);
            return (dbMan.ExecuteScalar(StoredProcedureName, Parameters)).ToString();
        }
        //get pass of certian SSN
        public string getPassOf(int ssn, string type)
        {
            string storedProcedure = StoredProcedures.checkPass;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@SSN", ssn);
            parameters.Add("@Type", type);
            object o = dbMan.ExecuteScalar(storedProcedure, parameters);
            if (o != null)
            {
                return o.ToString();
            }
            else
                return "";
        }
        
       public DataTable patientAppoints(int ssn)
        {
            string storedProcedure = StoredProcedures.patientAppoints;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@PSSN", ssn);
            return  dbMan.ExecuteReader(storedProcedure, parameters);
        }
        public DataTable getAllRoomsID()
        {
            string storedProcedure = StoredProcedures.getAllRoomsID;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable o = dbMan.ExecuteReader(storedProcedure, parameters);
            if (o != null)
            {
                return o;
            }
            else
                return null;
        }
        public DataTable DoctorAvailableClinicShifts(int CID)
        {
            string storedProcedure = StoredProcedures.DoctorAvailableClinicShifts;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CID", CID);
            DataTable o = dbMan.ExecuteReader(storedProcedure, parameters);
            if (o != null)
            {
                return o;
            }
            else
                return null;
        }
        public void AddDoctorRoom(int DSSN, int RID)
        {
            string storedProcedure = StoredProcedures.AddDoctorRoom;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@DSSN", DSSN);
            parameters.Add("@RID", RID);
            if (dbMan.ExecuteNonQuery(storedProcedure, parameters) == 0)
            {
                    // return error 
                    // messageBox
            }
        }
        /* @Dssn int,
	@Fname varchar(50),
	@Lname varchar(50),
	@Phone varchar(50),
	@Age int,
	@Salary int,
	@City varchar(50),
	@street varchar(50),
	@houseNum int,
	@Shift_From time(0),
	@Dno int  */
        public int AddDoctor(int Dssn, string Fname, string Lname, string Phone, int Age, int Salary,string city , 
            string street,string houseNum,  string Shift_From, int Dno,string pass)
        {
            String StoredProcedureName = StoredProcedures.AddDoctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dssn", Dssn);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Phone", Phone);
            Parameters.Add("@Age", Age);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@City", city);
            Parameters.Add("@street", street);
            Parameters.Add("@houseNum", houseNum);
            Shift_From = new DateTime(1, 1, 1, Convert.ToInt32(Shift_From.Substring(0, 2)), 0, 0).ToString("HH:mm:ss");
            Parameters.Add("@Shift_From", Shift_From);
            Parameters.Add("@Dno", Dno);
            Parameters.Add("@PASS", pass);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        
        public int updateDoc(int Dssn, string Fname, string Lname, string Phone, int Age, int Salary, string city,
            string street, string houseNum, string Shift_From, int Dno)
        {
            String StoredProcedureName = StoredProcedures.updateDoc;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dssn", Dssn);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Phone", Phone);
            Parameters.Add("@Age", Age);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@City", city);
            Parameters.Add("@street", street);
            Parameters.Add("@houseNum", houseNum);
            Shift_From = new DateTime(1, 1, 1, Convert.ToInt32(Shift_From.Substring(0, 2)), 0, 0).ToString("HH:mm:ss");
            Parameters.Add("@Shift_From", Shift_From);
            Parameters.Add("@Dno", Dno);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int AddDoctorClinic(int Dssn,int CID,string StartTime)
        {
            String StoredProcedureName = StoredProcedures.AddNurseClinic;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dssn", Dssn);
            StartTime = new DateTime(1, 1, 1, Convert.ToInt32(StartTime.Substring(0, 2)), 0, 0).ToString("HH:mm:ss");
            Parameters.Add("@StartTime", StartTime);
            Parameters.Add("@CID", CID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable selectDoctor(int Dssn)
        {
            string StoredProcedureName = StoredProcedures.selectDoctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dssn", Dssn);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        
        public DataTable  getDoctorClinic(int Dssn)
        {
            string StoredProcedureName = StoredProcedures.getDoctorClinic;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dssn", Dssn);
            return  dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        
        public DataTable getDocDepartment(int Dssn)
        {
            string StoredProcedureName = StoredProcedures.getDocDepartment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dssn", Dssn);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable getDocsAtDep(int Dno)
        {
            string StoredProcedureName = StoredProcedures.getDocsAtDep;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dno", Dno);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable getDoctorRooms(int Dssn)
        {
            string StoredProcedureName = StoredProcedures.getDoctorRooms;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dssn", Dssn);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        
    public int editDoctor(int Dssn, string Fname, string Lname, string Phone, int Age, int Salary, string city,
            string street, string houseNum, string Shift_From, int Dno)
        {
            string StoredProcedureName = StoredProcedures.AddDoctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dssn", Dssn);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Phone", Phone);
            Parameters.Add("@Age", Age);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@City", city);
            Parameters.Add("@street", street);
            Parameters.Add("@houseNum", houseNum);
            Shift_From = new DateTime(1, 1, 1, Convert.ToInt32(Shift_From.Substring(0, 2)), 0, 0).ToString("HH:mm:ss");
            Parameters.Add("@Shift_From", Shift_From);
            Parameters.Add("@Dno", Dno);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        
 
              public int removeDoctorClinic(int Nssn, int CID,string shift_start)
 
        {
            String StoredProcedureName = StoredProcedures.removeDoctorClinic;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DSSN", Nssn);
            Parameters.Add("@CID", CID);
            Parameters.Add("@Shift_start", shift_start);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int removeDoctorRoom(int Nssn, int RID)
        {
            String StoredProcedureName = StoredProcedures.removeDoctorRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DSSN", Nssn);
            Parameters.Add("@RID", RID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable DoctorAvailableRooms(int DSSN)
        {
            string storedProcedure = StoredProcedures.DoctorAvailableRooms;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@DSSN", DSSN);
            DataTable o = dbMan.ExecuteReader(storedProcedure, parameters);
            if (o != null)
            {
                return o;
            }
            else
                return null;
        }
        public DataTable availableappointments(string from , string to ,string date , int Dssn)
        {
            String StoredProcedureName = StoredProcedures.availableappointments;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@from", from);
            Parameters.Add("@to", to);
            Parameters.Add("@date", date);
            Parameters.Add("@ssn", Dssn);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public object selectPatient(int pssn)
        {
            String StoredProcedureName = StoredProcedures.selectPatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pssn", pssn);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        
       public object insertPatient(int pssn,string fname, string lname ,string phone,string pass)
        {
            String StoredProcedureName = StoredProcedures.insertPatient;
 
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PSSN", pssn);
            Parameters.Add("@Fname", fname);
            Parameters.Add("@Lname", lname);
            Parameters.Add("@phone", phone);
            Parameters.Add("@PASS", pass);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        
              public int AddNewAppointment(int DSSN, int Pssn ,string date,string start)
        {
            String StoredProcedureName = StoredProcedures.AddNewAppointment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DSSN", DSSN);
            Parameters.Add("@PSSN", Pssn);
            Parameters.Add("@date", date);
            Parameters.Add("@startTime", start);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable selectDocByName(string lname)
        {
            String StoredProcedureName = StoredProcedures.selectDocByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Lname", lname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
 
        public int changePass(int ssn, string oldpass ,string newPass,string type)
 
        {
            String StoredProcedureName = StoredProcedures.changePass;
 
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
 
            Parameters.Add("@SSN", ssn);
            Parameters.Add("@oldPass", oldpass);
            Parameters.Add("@newPass", newPass);
            Parameters.Add("@TYPE", type);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //select all departments
        public DataTable SelectDep()
        {
            String StoredProcedureName = StoredProcedures.GetAllDep;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        
         public DataTable getMedicineDeps()
        {
            String StoredProcedureName = StoredProcedures.getMedicineDeps;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        
              public DataTable getNonMedicineDeps()
        {
            String StoredProcedureName = StoredProcedures.getNonMedicineDeps;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //select week dates
        public DataTable getweekdates()
        {
            String StoredProcedureName = StoredProcedures.Getdates;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //get doctor information
        public DataTable getdocinfo(int s)
        {
            String StoredProcedureName = StoredProcedures.getdoctor;
 
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
 
            Parameters.Add("@dssn", s);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //get available appointments for specific doctor in specific date
 
        public DataTable aviapps(string s1, string s2, string s3, int i)
 
        {
            String StoredProcedureName = StoredProcedures.getdocapps;
 
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
 
            Parameters.Add("@from", s1);
            Parameters.Add("@to", s2);
            Parameters.Add("@date", s3);
            Parameters.Add("@ssn", i);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //select all appointments with specific date
 
        public DataTable selectappointmensbydate(string s)
 
        {
            String StoredProcedureName = StoredProcedures.getapp;
 
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
 
            Parameters.Add("@date", s);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //get available rooms in specific period
 
        public DataTable getavailablerooms(string s, string s2)
 
        {
            String StoredProcedureName = StoredProcedures.getavailablerooms;
 
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
 
            Parameters.Add("@sdate", s);
            Parameters.Add("@edate", s2);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //get all depaendents of pateint
        public DataTable GetPateintDependents(int s)
        {
            String StoredProcedureName = StoredProcedures.GetPateintDependents;
 
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
 
            Parameters.Add("@pssn", s);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //find doctors by dep name
        public DataTable SelectDoctoorsbyDepname(string s)
        {
            String StoredProcedureName = StoredProcedures.SelectDoctorbyDep;
 
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
 
            Parameters.Add("@DepName", s);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //insert pateint_medicine
        public int InsertPateintMedicine(int pssn, string date, string from, string to, string med)
        {
            String StoredProcedureName = StoredProcedures.AddPateintDrag;
 
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
 
            Parameters.Add("@pssn", pssn);
            Parameters.Add("@date", date);
            Parameters.Add("@from", from);
            Parameters.Add("@to", to);
            Parameters.Add("@medicine", med);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //insert pateint_diagnose
        public int Insertdiagnos(int pssn, string diagnose)
        {
            String StoredProcedureName = StoredProcedures.AddDiagnose;
 
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
 
            Parameters.Add("@pssn", pssn);
            Parameters.Add("@diagnose", diagnose);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //insert room reservation
        public int AddReservation(int pssn, int rid, string sd, string ed)
        {
            String StoredProcedureName = StoredProcedures.AddReservation;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@pssn", pssn);
            Parameters.Add("@rid", rid);
            Parameters.Add("@sdate", sd);
            Parameters.Add("@edate", ed);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //insert pateint
        public int AddPateint(int pssn, string s1, string s2, string s3, int age, string s4, string s5, string s6)
        {
            String StoredProcedureName = StoredProcedures.AddPateint;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@pssn", pssn);
            Parameters.Add("@fname", s1);
            Parameters.Add("@lname", s2);
            Parameters.Add("@ins", s3== "" ? Convert.DBNull:s3);
            Parameters.Add("@Age", age==0? Convert.DBNull:age);
            Parameters.Add("@phone", s4);
            Parameters.Add("@city", s5==""? Convert.DBNull:s5);
            Parameters.Add("@street", s6==""? Convert.DBNull:s6);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //insert appointment
        public int AddAppointment(int dssn, int pssn, string s1, string s2,string s3)
        {
            String StoredProcedureName = StoredProcedures.Book;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@dssn", dssn);
            Parameters.Add("@pssn", pssn);
            Parameters.Add("@date", s1);
            Parameters.Add("@from", s2);
            Parameters.Add("@to", s3);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //select doctor shifts in clinic
        public DataTable selectdocshifts(int s)
        {
            String StoredProcedureName = StoredProcedures.getdocclinicshift;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ssn", s);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
    }
}
