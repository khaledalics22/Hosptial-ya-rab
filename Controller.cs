using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DBapplication
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


    }
}
