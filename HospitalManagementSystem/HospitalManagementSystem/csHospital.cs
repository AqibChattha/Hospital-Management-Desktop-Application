using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public sealed class csHospital
    {
        private static csHospital _instence;
        private List<csRoom> list_Of_Rooms { get; set; }
        private List<csPatient> list_Of_Patients { get; set; }
        private List<csStaff> list_Of_Staff { get; set; }
        private List<csDoctor> list_Of_Doctors { get; set; }
        private List<csNurse> list_Of_Nurses { get; set; }
        private List<csLabTechnician> list_Of_LabTechnecians { get; set; }
        private List<csOtherStaff> list_Of_OtherEmployees { get; set; }
        private List<csPharmacist> list_Of_Pharmacists { get; set; }
        private List<csReceptionist> list_Of_Receptionists { get; set; }
        private List<csSurgeon> list_Of_Surgeons { get; set; }
        private List<csPatientRecord> list_Of_Patient_record { get; set; }
        private List<String> list_Of_Departments { get; set; }
        private List<String> list_Of_DoctorQualifications { get; set; }
        private List<String> list_Of_LabTechQualifications { get; set; }
        private csHospital()
        {
            list_Of_Rooms = new List<csRoom>();
            list_Of_Patients = new List<csPatient>();
            list_Of_Staff = new List<csStaff>();
            list_Of_Doctors = new List<csDoctor>();
            list_Of_Nurses = new List<csNurse>();
            list_Of_LabTechnecians = new List<csLabTechnician>();
            list_Of_OtherEmployees = new List<csOtherStaff>();
            list_Of_Pharmacists = new List<csPharmacist>();
            list_Of_Receptionists = new List<csReceptionist>();
            list_Of_Surgeons = new List<csSurgeon>();
            list_Of_Patient_record = new List<csPatientRecord>();
            list_Of_Departments = new List<string>();
            list_Of_DoctorQualifications = new List<string>();
            list_Of_Departments.Add("department of neurology");
            list_Of_DoctorQualifications.Add("mmbs");
            list_Of_LabTechQualifications.Add("BSCE");
        }
        public static csHospital Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new csHospital();
                }
                return _instence;
            }
        }

        #region Doctor
        public List<csDoctor> getDoctors()
        {
            return list_Of_Doctors;
        }
        public void AddDoctor(csDoctor doc)
        {
            list_Of_Doctors.Add(doc);
        }
        public void DeleteDoctor(int index)
        {
            list_Of_Doctors.RemoveAt(index);
        }
        public void ViewDoctor(int index)
        {
            csDoctor doc = list_Of_Doctors[index];
            String info = "";
            info += "Name:  " + doc.Name + "\n" + "Staff ID:  " + doc.Staff_Id + "\n" +
                "CNIC:  " + doc.Cnic + "\n" + "Phone No:  " + doc.PhoneNumber + "\n" +
                "Date Of Birth:  " + doc.DateOfBirth.Date.ToString() + "\n" + "Email:  " + doc.Email + "\n" +
                "Password:  " + doc.Password + "\n" + "Qualification:  " + doc.Qualification + "\n" +
                "Department:  " + doc.Department + "\n" + "Gender:  " + doc.Gender + "\n" +
                "From:  " + doc.WH_Start_Time.TimeOfDay + "  to  " + doc.WH_End_Time.TimeOfDay + "\n" +
                "Salary:  " + doc.Salary + "\n" + "Address:  " + doc.Address;
            MessageBox.Show(info, "Doctor Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateDoctor(int index, csDoctor doc)
        {
            list_Of_Doctors[index] = doc;
        }
        #endregion

        #region Nurse
        public List<csNurse> getNurses()
        {
            return list_Of_Nurses;
        }
        public void AddNurse(csNurse nurse)
        {
            list_Of_Nurses.Add(nurse);
        }
        public void DeleteNurse(int index)
        {
            list_Of_Nurses.RemoveAt(index);
        }
        public void ViewNurse(int index)
        {
            csNurse nurse = list_Of_Nurses[index];
            String info = "";
            info += "Name:  " + nurse.Name + "\n" + "Staff ID:  " + nurse.Staff_Id + "\n" +
                "CNIC:  " + nurse.Cnic + "\n" + "Phone No:  " + nurse.PhoneNumber + "\n" +
                "Date Of Birth:  " + nurse.DateOfBirth.Date.ToString() + "\n" + "Email:  " + nurse.Email + "\n" +
                "Password:  " + nurse.Password + "\n" +
                "Duty:  " + nurse.Duty + "\n" + "Gender:  " + nurse.Gender + "\n" +
                "From:  " + nurse.WH_Start_Time.TimeOfDay + "  to  " + nurse.WH_End_Time.TimeOfDay + "\n" +
                "Salary:  " + nurse.Salary + "\n" + "Address:  " + nurse.Address;
             MessageBox.Show(info, "Nurse Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateNurse(int index, csNurse nurse)
        {
            list_Of_Nurses[index] = nurse;
        }
        #endregion

        #region LabTechnician
        public List<csLabTechnician> getLabTech()
        {
            return list_Of_LabTechnecians;
        }
        public void AddLabTech(csLabTechnician LabTech)
        {
            list_Of_LabTechnecians.Add(LabTech);
        }
        public void DeleteLabTech(int index)
        {
            list_Of_LabTechnecians.RemoveAt(index);
        }
        public void ViewLabTech(int index)
        {
           csLabTechnician LabTech = list_Of_LabTechnecians[index];
            String info = "";
            info += "Name:  " + LabTech.Name + "\n" + "Staff ID:  " + LabTech.Staff_Id + "\n" +
                "CNIC:  " + LabTech.Cnic + "\n" + "Phone No:  " + LabTech.PhoneNumber + "\n" +
                "Date Of Birth:  " + LabTech.DateOfBirth.Date.ToString() + "\n" + "Email:  " + LabTech.Email + "\n" +
                "Password:  " + LabTech.Password + "\n" +
                "Qualification:  " + LabTech.Qualification + "\n" + "Gender:  " + LabTech.Gender + "\n" +
                "From:  " + LabTech.WH_Start_Time.TimeOfDay + "  to  " + LabTech.WH_End_Time.TimeOfDay + "\n" +
                "Salary:  " + LabTech.Salary + "\n" + "Address:  " + LabTech.Address;
             MessageBox.Show(info, "Lab Technician Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateLabTech(int index, csLabTechnician LabTech)
        {
           list_Of_LabTechnecians[index] = LabTech;
        }
        #endregion
        public List<String> getDepartments()
        {
            return list_Of_Departments;
        }
        public List<String> getDoctorQualifications()
        {
            return list_Of_DoctorQualifications;
        }
        public List<String> getLabTechrQualifications()
        {
            return list_Of_LabTechQualifications;
        }
    }
}
