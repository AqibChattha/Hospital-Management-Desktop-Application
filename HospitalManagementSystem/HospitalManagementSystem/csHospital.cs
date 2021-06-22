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
        private List<csPharmacist> list_Of_Pharmacists { get; set; }
        private List<csSurgeon> list_Of_Surgeons { get; set; }
        private List<csReceptionist> list_Of_Receptionists { get; set; }
        private List<csPatientRecord> list_Of_Patient_record { get; set; }
        private List<csOtherStaff> list_Of_OtherStaff { get; set; }

        private List<String> list_Of_Departments { get; set; }
        private List<String> list_Of_DoctorQualifications { get; set; }
        private List<String> list_Of_LabTechQualifications { get; set; }
        private List<String> list_Of_PharmacistQualifications { get; set; }
        private List<String> list_Of_SurgeonQualifications { get; set; }
        private List<String> list_Of_SurgeonSpecialization { get; set; }
        private List<String> list_Of_OtherStaffTypes { get; set; }
        private csHospital()
        {
            list_Of_Rooms = new List<csRoom>();
            list_Of_Patients = new List<csPatient>();
            list_Of_Staff = new List<csStaff>();
            list_Of_Doctors = new List<csDoctor>();
            list_Of_Nurses = new List<csNurse>();
            list_Of_LabTechnecians = new List<csLabTechnician>();
            list_Of_Pharmacists = new List<csPharmacist>();
            list_Of_Patient_record = new List<csPatientRecord>();
            list_Of_Surgeons = new List<csSurgeon>();
            list_Of_Receptionists = new List<csReceptionist>();
            list_Of_OtherStaff = new List<csOtherStaff>();

            list_Of_Departments = new List<string>();
            list_Of_DoctorQualifications = new List<string>();
            list_Of_LabTechQualifications = new List<string>();
            list_Of_PharmacistQualifications = new List<string>();
            list_Of_SurgeonQualifications = new List<string>();
            list_Of_SurgeonSpecialization = new List<string>();
            list_Of_OtherStaffTypes = new List<string>();

            list_Of_Departments.Add("department of neurology");
            list_Of_DoctorQualifications.Add("mmbs");
            list_Of_LabTechQualifications.Add("BSCE");
            list_Of_PharmacistQualifications.Add("Chemist");
            list_Of_SurgeonQualifications.Add("sadd");
            list_Of_SurgeonSpecialization.Add("sdasdad");
            list_Of_OtherStaffTypes.Add("Security");
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

        #region -----Doctor
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
        public List<String> getDoctorQualifications()
        {
            return list_Of_DoctorQualifications;
        }
        public void UpdateDoctor(int index, csDoctor doc)
        {
            list_Of_Doctors[index] = doc;
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
        #endregion

        #region -----Nurse
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

        #region -----LabTechnician
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
        public List<String> getLabTechrQualifications()
        {
            return list_Of_LabTechQualifications;
        }
        public void UpdateLabTech(int index, csLabTechnician LabTech)
        {
            list_Of_LabTechnecians[index] = LabTech;
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
        #endregion

        #region -----Pharmacist
        public List<csPharmacist> getPharmacist()
        {
            return list_Of_Pharmacists;
        }
        public void AddPharmacist(csPharmacist Pharmacist)
        {
            list_Of_Pharmacists.Add(Pharmacist);
        }
        public void DeletePharmacist(int index)
        {
            list_Of_Pharmacists.RemoveAt(index);
        }
        public List<String> getPharmacistrQualifications()
        {
            return list_Of_PharmacistQualifications;
        }
        public void UpdatePharmacist(int index, csPharmacist Pharmacist)
        {
            list_Of_Pharmacists[index] = Pharmacist;
        }
        public void ViewPharmacist(int index)
        {
            csPharmacist Pharmacist = list_Of_Pharmacists[index];
            String info = "";
            info += "Name:  " + Pharmacist.Name + "\n" + "Staff ID:  " + Pharmacist.Staff_Id + "\n" +
                "CNIC:  " + Pharmacist.Cnic + "\n" + "Phone No:  " + Pharmacist.PhoneNumber + "\n" +
                "Date Of Birth:  " + Pharmacist.DateOfBirth.Date.ToString() + "\n" + "Email:  " + Pharmacist.Email + "\n" +
                "Password:  " + Pharmacist.Password + "\n" +
                "Qualification:  " + Pharmacist.Qualification + "\n" + "Gender:  " + Pharmacist.Gender + "\n" +
                "From:  " + Pharmacist.WH_Start_Time.TimeOfDay + "  to  " + Pharmacist.WH_End_Time.TimeOfDay + "\n" +
                "Salary:  " + Pharmacist.Salary + "\n" + "Address:  " + Pharmacist.Address;
            MessageBox.Show(info, "Pharmacist Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region -----Surgeon
        public List<csSurgeon> getSurgeons()
        {
            return list_Of_Surgeons;
        }
        public void AddSurgeon(csSurgeon surgeon)
        {
            list_Of_Surgeons.Add(surgeon);
        }
        public void DeleteSurgeon(int index)
        {
            list_Of_Surgeons.RemoveAt(index);
        }
        public List<String> getSurgeonQualifications()
        {
            return list_Of_SurgeonQualifications;
        }
        public List<String> getSurgeonSpecializations()
        {
            return list_Of_SurgeonSpecialization;
        }
        public void UpdateSurgeon(int index, csSurgeon surgeon)
        {
            list_Of_Surgeons[index] = surgeon;
        }
        public void ViewSurgeon(int index)
        {
            csSurgeon surgeon = list_Of_Surgeons[index];
            String info = "";
            info += "Name:  " + surgeon.Name + "\n" + "Staff ID:  " + surgeon.Staff_Id + "\n" +
                "CNIC:  " + surgeon.Cnic + "\n" + "Phone No:  " + surgeon.PhoneNumber + "\n" +
                "Date Of Birth:  " + surgeon.DateOfBirth.Date.ToString() + "\n" + "Email:  " + surgeon.Email + "\n" +
                "Password:  " + surgeon.Password + "\n" + "Qualification:  " + surgeon.Qualification + "\n" +
                "Department:  " + surgeon.Department + "\n" + "Gender:  " + surgeon.Gender + "\n" +
                "Specialization:  " + surgeon.Specialization + "\n" + "Experiance:  " +surgeon.Experience + " Years\n" +
                "From:  " + surgeon.WH_Start_Time.TimeOfDay + "  to  " + surgeon.WH_End_Time.TimeOfDay + "\n" +
                "Salary:  " + surgeon.Salary + "\n" + "Address:  " + surgeon.Address;
            MessageBox.Show(info, "Surgeon Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region -----Receptionist
        public List<csReceptionist> getReceptionists()
        {
            return list_Of_Receptionists;
        }
        public void AddReceptionist(csReceptionist receptionist)
        {
            list_Of_Receptionists.Add(receptionist);
        }
        public void DeleteReceptionist(int index)
        {
            list_Of_Receptionists.RemoveAt(index);
        }
        public void UpdateReceptionist(int index, csReceptionist receptionist)
        {
            list_Of_Receptionists[index] = receptionist;
        }
        public void ViewReceptionist(int index)
        {
            csReceptionist receptionist = list_Of_Receptionists[index];
            String info = "";
            info += "Name:  " + receptionist.Name + "\n" + "Staff ID:  " + receptionist.Staff_Id + "\n" +
                "CNIC:  " + receptionist.Cnic + "\n" + "Phone No:  " + receptionist.PhoneNumber + "\n" +
                "Date Of Birth:  " + receptionist.DateOfBirth.Date.ToString() + "\n" + "Email:  " + receptionist.Email + "\n" +
                "Password:  " + receptionist.Password + "\n" + 
                "Gender:  " + receptionist.Gender + "\n" +
                "From:  " + receptionist.WH_Start_Time.TimeOfDay + "  to  " + receptionist.WH_End_Time.TimeOfDay + "\n" +
                "Salary:  " + receptionist.Salary + "\n" + "Address:  " + receptionist.Address;
            MessageBox.Show(info, "Receptionist Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region -----OtherStaff
        public List<csOtherStaff> getOtherStaffs()
        {
            return list_Of_OtherStaff;
        }
        public void AddOtherStaff(csOtherStaff otherStaff)
        {
            list_Of_OtherStaff.Add(otherStaff);
        }
        public void DeleteOtherStaff(int index)
        {
            list_Of_OtherStaff.RemoveAt(index);
        }
        public void UpdateOtherStaff(int index, csOtherStaff otherStaff)
        {
            list_Of_OtherStaff[index] = otherStaff;
        }
        public List<String> getOtherStaffTypes()
        {
            return list_Of_OtherStaffTypes;
        }
        public void ViewOtherStaff(int index)
        {
            csOtherStaff otherStaff = list_Of_OtherStaff[index];
            String info = "";
            info += "Name:  " + otherStaff.Name + "\n" + "Staff ID:  " + otherStaff.Staff_Id + "\n" +
                "CNIC:  " + otherStaff.Cnic + "\n" + "Phone No:  " + otherStaff.PhoneNumber + "\n" +
                "Date Of Birth:  " + otherStaff.DateOfBirth.Date.ToString() + "\n" +
                "Gender:  " + otherStaff.Gender + "\n" +
                "From:  " + otherStaff.WH_Start_Time.TimeOfDay + "  to  " + otherStaff.WH_End_Time.TimeOfDay + "\n" +
                "Salary:  " + otherStaff.Salary + "\n" + "Address:  " + otherStaff.Address;
            MessageBox.Show(info, "OtherStaff Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion


        public List<String> getDepartments()
        {
            return list_Of_Departments;
        }
    }
}
