using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_ISA
{
    public class StoredProcedures
    {
        // stored procedures goes here 
        
        public static string GetDocs = "GetAllDocs";
        public static string GetNurses = "GetAllNurse";
        public static string GetEmps = "GetAllEmp";
        public static string GetAllPatDiag = "GetAllPatientDiag";
        public static string DeleteEmp = "DeleteEmp";
        public static string DeleteDoc = "DeleteDoctor";
        public static string DeleteNurse = "DeleteNurse";

        public static string AllDrugs = "SelectAllDrugs";
        public static string EmptyDrugs = "SelectEmptyDrugs";
        public static string FindDrugs = "FindDrug";
        public static string FindEmptyDrugs = "FindEmptyDrug";
        public static string InsertDrug = "InsertDrug";

        public static string AddQuantity = "AddQuantity";
        public static string SellDrug = "SellDrug";
        public static string AddToSold = "AddToSold";
        public static string getAllDepartments = "getAllDepartments";
        public static string InsertEmployee = "InsertEmployee";
        public static string getDepartmentNumber = "getDepartmentNumber";
        public static string getDepartmentName = "getDepartmentName";
        public static string selectEmployee = "selectEmployee";
        public static string EditEmployee = "EditEmployee";

        public static string AddNurse = "AddNurse";
        public static string AddNurseClinic = "AddNurseClinic";
        public static string AddNurseRoom = "AddNurseRoom";
        public static string AvailableNurseRooms = "AvailableNurseRooms";
        public static string EditNurse = "EditNurse";
        public static string EditNurseClinic = "EditNurseClinic";
        public static string getNurseRooms = "getNurseRooms";
        public static string getNurseClinic = "getNurseClinic";
        public static string getAllClinicsId = "getAllClinicsId";
        public static string NurseAvailableClinicShifts = "NurseAvailableClinicShifts";
        public static string RemoveNurseRoom = "RemoveNurseRoom";
        public static string selectNurse = "selectNurse";


        public static string GetPrevAppoint = "ViewPrevAppoint";
        public static string GetAppointMed = "GetAppointMed";
        public static string GetAppDiagnose = "GetAppDiag";

        //khaled
        public static string checkPass = "checkPass";
        public static string storePass = "storePass";


    }
}
