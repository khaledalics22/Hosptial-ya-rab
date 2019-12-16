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
            Shift_From = new DateTime(1, 1, 1, Convert.ToInt32(Shift_From.Substring(0, 2)), 0, 0).ToString("HH:mm:ss");
            Parameters.Add("@Shift_From", Shift_From);
            Parameters.Add("@Dno", Dno == -1 ? Convert.DBNull:Dno);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public object getDepartmentNumber(string Dname)
        {
            String StoredProcedureName = StoredProcedures.getDepartmentNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dname", Dname);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable getAllDepartments()
        {
            String StoredProcedureName = StoredProcedures.getAllDepartments;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
    }
}
