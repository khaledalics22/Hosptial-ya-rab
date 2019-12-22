using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_ISA
{
    public class StoredProcedures
    {
        // stored procedures goes here 
        public static string removeDocClinic1="removeDocClinic1";
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
        public static string patientAppoints = "patientAppoints";
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
        public static string getAllRoomsID = "getAllRoomsID";
        public static string DoctorAvailableClinicShifts = "DoctorAvailableClinicShifts";
        public static string AddDoctorRoom = "AddDoctorRoom";
        public static string AddDoctor ="AddDoctor";
        public static string getDoctorClinic ="getDoctorClinic";
        public static string selectDoctor ="selectDoctor";
        public static string getDoctorRooms = "getDoctorRooms";
        public static string getDocDepartment = "getDocDepartment";
        public static string editDoctor = "editDoctor";
        public static string removeDoctorClinic="removeDoctorClinic";
        public static string removeDoctorRoom="removeDoctorRoom";
        public static string DoctorAvailableRooms ="DoctorAvailableRooms";
        public static string getDocsAtDep="getDocsAtDep";
        public static string availableappointments = "availableappointments";
        public static string selectPatient = "selectPatient";
        public static string insertPatient="insertPatient";
        public static string AddNewAppointment="AddNewAppointment";
        public static string selectDocByName="selectDocByName";
        public static string changePass="changePass";
        public static string updateDoc = "updateDoc";
        public static string getMedicineDeps = "getMedicineDeps";
        public static string getNonMedicineDeps = "getNonMedicineDeps";

        public static string SelectDoctorbyDep = "SelectDoctorbyDep";
        public static string GetAllDep = "GetAllDep";
        public static string Getdates = "getweekdates";
        public static string getapp = "getappointmentbydate";
        public static string getdoctor = "getdoctorinfo";
        public static string getdocapps = "availableappointments";
        public static string getdocclinicshift = "getdocclinicshift";
        public static string GetPateintDependents = "GetPateintDependents";
        public static string AddDiagnose = "AddDiagnose";
        public static string AddPateintDrag = "AddPateintDrag";
        public static string AddPateint = "AddPateint";
        public static string getavailablerooms = "getavailablerooms";
        public static string AddReservation = "InsertReservation";
        public static string Book = "insertappointment";
        public static string cancelAppoint="cancelAppoint";
        public static string AddDoctorClinic = "AddDoctorClinic";

        public static string getPatientInfo = "getPatientInfo";
        public static string patientHistory = "patientHistory";

    }
}
