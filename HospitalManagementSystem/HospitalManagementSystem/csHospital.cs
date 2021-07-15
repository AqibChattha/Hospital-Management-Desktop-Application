using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public sealed class csHospital
    {
        private static csHospital _instence;
        private static List<csRoom> list_Of_Rooms { get; set; }
        private static List<csPatient> list_Of_Patients { get; set; }
        private static List<csStaff> list_Of_Staff { get; set; }
        private static List<csDoctor> list_Of_Doctors { get; set; }
        private static List<csNurse> list_Of_Nurses { get; set; }
        private static List<csLabTechnician> list_Of_LabTechnecians { get; set; }
        private static List<csPharmacist> list_Of_Pharmacists { get; set; }
        private static List<csSurgeon> list_Of_Surgeons { get; set; }
        private static List<csReceptionist> list_Of_Receptionists { get; set; }
        private static List<csPatientRecord> list_Of_Patient_record { get; set; }
        private static List<csOtherStaff> list_Of_OtherStaff { get; set; }
        private static List<csLabTest> list_Of_LabTests { get; set; }
        private static List<csLaboratory> list_of_Laboratories { get; set; }


        private static Queue<csOutPatient> patientQueue { get; set; }


        //required for combo box
        private static List<String> list_Of_Departments { get; set; }
        private static List<String> list_Of_DoctorQualifications { get; set; }
        private static List<String> list_Of_LabTechQualifications { get; set; }
        private static List<String> list_Of_PharmacistQualifications { get; set; }
        private static List<String> list_Of_SurgeonQualifications { get; set; }
        private static List<String> list_Of_SurgeonSpecialization { get; set; }
        private static List<String> list_Of_OtherStaffTypes { get; set; }
        private static List<csSample> list_Of_Samples { get; set; }
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
            list_Of_LabTests = new List<csLabTest>();
            list_Of_Samples = new List<csSample>();
            list_of_Laboratories = new List<csLaboratory>();

            patientQueue = new Queue<csOutPatient>();

            list_Of_Departments = new List<string>();
            list_Of_DoctorQualifications = new List<string>();
            list_Of_LabTechQualifications = new List<string>();
            list_Of_PharmacistQualifications = new List<string>();
            list_Of_SurgeonQualifications = new List<string>();
            list_Of_SurgeonSpecialization = new List<string>();
            list_Of_OtherStaffTypes = new List<string>();

            list_of_Laboratories.Add(new csLaboratory("LAB-2","Shokat Khanam", "2nd Floor, LAB-2"));
            list_Of_Samples.Add(new csSample("Blood Test", 899));
            list_Of_Departments.Add("department of neurology");
            list_Of_DoctorQualifications.Add("mmbs");
            list_Of_LabTechQualifications.Add("BSCE");
            list_Of_PharmacistQualifications.Add("Chemist");
            list_Of_SurgeonQualifications.Add("sadd");
            list_Of_SurgeonSpecialization.Add("sdasdad");
            list_Of_OtherStaffTypes.Add("Security");
            list_Of_Rooms.Add(new csWard("WRD-1","first floor", "3 Star"));


            LoadData();
        }
        public void Initialize() { }
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
                "Date Of Birth:  " + doc.DateOfBirth.Date.ToShortDateString() + "\n" + "Email:  " + doc.Email + "\n" +
                "Password:  " + doc.Password + "\n" + "Qualification:  " + doc.Qualification + "\n" +
                "Department:  " + doc.Department + "\n" + "Gender:  " + doc.Gender + "\n" +
                "From:  " + doc.WH_Start_Time.ToShortTimeString() + "  to  " + doc.WH_End_Time.ToShortTimeString() + "\n" +
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
                "Date Of Birth:  " + nurse.DateOfBirth.Date.ToShortDateString() + "\n" + "Email:  " + nurse.Email + "\n" +
                "Password:  " + nurse.Password + "\n" +
                "Duty:  " + nurse.Duty + "\n" + "Gender:  " + nurse.Gender + "\n" +
                "From:  " + nurse.WH_Start_Time.ToShortTimeString() + "  to  " + nurse.WH_End_Time.ToShortTimeString() + "\n" +
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
                "Date Of Birth:  " + LabTech.DateOfBirth.Date.ToShortDateString() + "\n" + "Email:  " + LabTech.Email + "\n" +
                "Password:  " + LabTech.Password + "\n" +
                "Qualification:  " + LabTech.Qualification + "\n" + "Gender:  " + LabTech.Gender + "\n" +
                "From:  " + LabTech.WH_Start_Time.ToShortTimeString() + "  to  " + LabTech.WH_End_Time.ToShortTimeString() + "\n" +
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
                "Date Of Birth:  " + Pharmacist.DateOfBirth.Date.ToShortDateString() + "\n" + "Email:  " + Pharmacist.Email + "\n" +
                "Password:  " + Pharmacist.Password + "\n" +
                "Qualification:  " + Pharmacist.Qualification + "\n" + "Gender:  " + Pharmacist.Gender + "\n" +
                "From:  " + Pharmacist.WH_Start_Time.ToShortTimeString() + "  to  " + Pharmacist.WH_End_Time.ToShortTimeString() + "\n" +
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
                "Date Of Birth:  " + surgeon.DateOfBirth.Date.ToShortDateString() + "\n" + "Email:  " + surgeon.Email + "\n" +
                "Password:  " + surgeon.Password + "\n" + "Qualification:  " + surgeon.Qualification + "\n" +
                "Department:  " + surgeon.Department + "\n" + "Gender:  " + surgeon.Gender + "\n" +
                "Specialization:  " + surgeon.Specialization + "\n" + "Experiance:  " +surgeon.Experience + " Years\n" +
                "From:  " + surgeon.WH_Start_Time.ToShortTimeString() + "  to  " + surgeon.WH_End_Time.ToShortTimeString() + "\n" +
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
                "Date Of Birth:  " + receptionist.DateOfBirth.Date.ToShortDateString() + "\n" + "Email:  " + receptionist.Email + "\n" +
                "Password:  " + receptionist.Password + "\n" + 
                "Gender:  " + receptionist.Gender + "\n" +
                "From:  " + receptionist.WH_Start_Time.ToShortTimeString() + "  to  " + receptionist.WH_End_Time.ToShortTimeString() + "\n" +
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
                "Date Of Birth:  " + otherStaff.DateOfBirth.Date.ToShortDateString() + "\n" +
                "Gender:  " + otherStaff.Gender + "\n" +
                "From:  " + otherStaff.WH_Start_Time.ToShortTimeString() + "  to  " + otherStaff.WH_End_Time.ToShortTimeString() + "\n" +
                "Salary:  " + otherStaff.Salary + "\n" + "Address:  " + otherStaff.Address;
            MessageBox.Show(info, "OtherStaff Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        public List<String> getDepartments()
        {
            return list_Of_Departments;
        }


        #region LabTests
        public List<csLabTest> getLabTests()
        {
            return list_Of_LabTests;
        }
        public List<csSample> getSamples()
        {
            return list_Of_Samples;
        }
        public List<csLaboratory> getLaboratories()
        {
            return list_of_Laboratories;
        }
        public void AddLabTest(csLabTest ltest)
        {
            list_Of_LabTests.Add(ltest);
        }
        public void DeleteLabTest(int index)
        {
            list_Of_LabTests.RemoveAt(index);
        }
        public void UpdateLabTest(int index, csLabTest ltest)
        {
            list_Of_LabTests[index] = ltest;
        }
        public void ViewLabTest(int index)
        {
            csLabTest ltest = list_Of_LabTests[index];
            String info = "";
            info += "Patient Name:  " + ltest.PatientName + "\n" + "Patient ID:  " + ltest.PatientId + "\n" +
                "Lab ID:  " + ltest.labID + "\n" + "Test ID:  " + ltest.TestId + "\n" +
                "Sample Type:  " + ltest.Sample.Name + "\n" + "Test Cost:  " + ltest.Sample.Cost + "\n" +
                "Due Date:  " + ltest.DueDate.ToShortDateString();
            if (!ltest.Result.Equals(""))
            {
                info += "\n" + "Test Result:  " + ltest.Result;
            }
            MessageBox.Show(info, "Test Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void AddLabTesResult(int index, String result)
        {
            list_Of_LabTests[index].AddResult(result);
        }
        #endregion


        #region Patients


        public List<csPatient> getPatients()
        {
            return list_Of_Patients;
        }

        public void AddPatient(csPatient p)
        {
            list_Of_Patients.Add(p);
        }

        public Queue<csOutPatient> getPatientQueue()
        {
            return patientQueue;
        }

        public void AddPatientInQueue(csOutPatient p)
        {
            patientQueue.Enqueue(p);
        }
        public void RempvePatientFrpmQueue()
        {
            patientQueue.Dequeue();
        }

        public void RemovePatient(int index)
        {
            list_Of_Patients.RemoveAt(index);
        }
        public void ViewPatient(int index)
        {
            csPatient patient = list_Of_Patients[index];
            String info = "";
            info += "Name:  " + patient.Name + "\n" + "Patient ID:  " + patient.Patient_Id + "\n" +
                "CNIC:  " + patient.Cnic + "\n" + "Phone No:  " + patient.PhoneNumber + "\n" +
                "Date Of Birth:  " + patient.DateOfBirth.Date.ToShortDateString() + "\n" +
                "Gender:  " + patient.Gender + "\n" +
                "Address:  " + patient.Address;
            MessageBox.Show(info, "OtherStaff Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Rooms


        public List<csRoom> getRooms()
        {
            return list_Of_Rooms;
        }

        #endregion
        



        public List<csStaff> getStaff()
        {
            list_Of_Staff.AddRange(list_Of_Doctors);
            list_Of_Staff.AddRange(list_Of_Nurses);
            list_Of_Staff.AddRange(list_Of_Surgeons);
            list_Of_Staff.AddRange(list_Of_Pharmacists);
            list_Of_Staff.AddRange(list_Of_LabTechnecians);
            list_Of_Staff.AddRange(list_Of_Receptionists);
            list_Of_Staff.AddRange(list_Of_OtherStaff);
            return list_Of_Staff;
        }
        public List<String> getStaffTypes()
        {
            List<String> types = new List<string>();
            types.Add("Doctor");
            types.Add("Surgeons");
            types.Add("Nurses");
            types.Add("Pharmacist");
            types.Add("Lab Technecian");
            types.Add("Receptionist");
            types.AddRange(list_Of_OtherStaffTypes);
            return types;
        }
        public List<String> getStaffIdsByType(String type)
        {
            List<csStaff> typeStaff = new List<csStaff>();
            List<String> ids = new List<string>();
            switch (type)
            {
                case "Doctor":
                    typeStaff.AddRange(list_Of_Doctors);
                    break;
                case "Surgeons":
                    typeStaff.AddRange(list_Of_Surgeons);
                    break;
                case "Nurses":
                    typeStaff.AddRange(list_Of_Nurses);
                    break;
                case "Pharmacist":
                    typeStaff.AddRange(list_Of_Pharmacists);
                    break;
                case "Lab Technecian":
                    typeStaff.AddRange(list_Of_LabTechnecians);
                    break;
                case "Receptionist":
                    typeStaff.AddRange(list_Of_Receptionists);
                    break;

                default:
                    for(int i=0; i< list_Of_OtherStaffTypes.Count; i++)
                    {
                        if (list_Of_OtherStaffTypes[i].Equals(type))
                        {
                            typeStaff.AddRange(list_Of_OtherStaff);
                        }
                    }
                    break;
            }
            if (typeStaff.Count > 0)
            {
                if (typeStaff[0].GetType() == new csOtherStaff().GetType())
                {
                    for (int i = 0; i < typeStaff.Count; i++)
                    {
                        if (((csOtherStaff)typeStaff[i]).Type.Equals(type))
                        {
                            ids.Add(typeStaff[i].Staff_Id);
                        }
                    }
                    return ids;
                }
                else
                {
                    for (int i = 0; i < typeStaff.Count; i++)
                    {
                        ids.Add(typeStaff[i].Staff_Id);
                    }
                    return ids;
                }
            }
            return null;
        }
































        public static void SaveData()
        {
            SaveDoctorsData();
            SaveNursesData();
            SavePharmacistsData();
            SaveLabTechsData();
            SaveSurgeonsData();
            SaveReceptionistsData();
            SaveOhterStaffData();

        }

        #region Individual Save_Data

        private static void SaveDoctorsData()
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"DoctorsData.txt");
                for (int i = 0; i < list_Of_Doctors.Count; i++)
                {
                    csDoctor d = list_Of_Doctors[i];
                    writer.WriteLine(d.Name + ":;" + d.Cnic + ":;" + d.PhoneNumber + ":;" + d.DateOfBirth + ":;" + d.Email + ":;" + d.Password + ":;" + d.Qualification +
                        ":;" + d.Department + ":;" + d.Gender + ":;" + d.WH_Start_Time + ":;" + d.WH_End_Time + ":;" + d.Salary + ":;" + d.Address + ":;" + d.Staff_Id);
                }
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void SaveNursesData()
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"NursesData.txt");
                for (int i = 0; i < list_Of_Nurses.Count; i++)
                {
                    csNurse n = list_Of_Nurses[i];
                    writer.WriteLine(n.Name + ":;" + n.Cnic + ":;" + n.PhoneNumber + ":;" + n.DateOfBirth + ":;" + n.Email + ":;" + n.Password +
                       ":;" + n.Gender + ":;" + n.WH_Start_Time + ":;" + n.WH_End_Time + ":;" + n.Salary + ":;" + n.Address + ":;" + n.Duty + ":;" + n.Staff_Id);
                }
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void SavePharmacistsData()
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"PharmacistsData.txt");
                for (int i = 0; i < list_Of_Pharmacists.Count; i++)
                {
                    csPharmacist p = list_Of_Pharmacists[i];
                    writer.WriteLine(p.Name + ":;" + p.Cnic + ":;" + p.PhoneNumber + ":;" + p.DateOfBirth + ":;" + p.Email + ":;" + p.Password + ":;" + p.Qualification +
                        ":;" + p.Gender + ":;" + p.WH_Start_Time + ":;" + p.WH_End_Time + ":;" + p.Salary + ":;" + p.Address + ":;" + p.Staff_Id);                    
                }
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void SaveLabTechsData()
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"LabTechsData.txt");
                for (int i = 0; i < list_Of_LabTechnecians.Count; i++)
                {
                    csLabTechnician lt = list_Of_LabTechnecians[i];
                    writer.WriteLine(lt.Name + ":;" + lt.Cnic + ":;" + lt.PhoneNumber + ":;" + lt.DateOfBirth + ":;" + lt.Email + ":;" + lt.Password + ":;" + lt.Qualification +
                        ":;" + lt.Gender + ":;" + lt.WH_Start_Time + ":;" + lt.WH_End_Time + ":;" + lt.Salary + ":;" + lt.Address + ":;" + lt.Staff_Id);                    
                }
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void SaveSurgeonsData()
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"SurgeonsData.txt");
                for (int i = 0; i < list_Of_Surgeons.Count; i++)
                {
                    csSurgeon s = list_Of_Surgeons[i];
                    writer.WriteLine(s.Name + ":;" + s.Cnic + ":;" + s.PhoneNumber + ":;" + s.DateOfBirth + ":;" + s.Email + ":;" + s.Password + ":;" + s.Qualification +
                        ":;" + s.Department + ":;" + s.Specialization + ":;" + s.Experience + ":;" + s.Gender + ":;" + s.WH_Start_Time + ":;" + s.WH_End_Time +
                        ":;" + s.Salary + ":;" + s.Address + ":;" + s.Staff_Id);                    
                }
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void SaveReceptionistsData()
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"ReceptionistsData.txt");
                for (int i = 0; i < list_Of_Receptionists.Count; i++)
                {
                    csReceptionist r = list_Of_Receptionists[i];
                    writer.WriteLine(r.Name + ":;" + r.Cnic + ":;" + r.PhoneNumber + ":;" + r.DateOfBirth + ":;" + r.Email + ":;" + r.Password +
                        ":;" + r.Gender + ":;" + r.WH_Start_Time + ":;" + r.WH_End_Time + ":;" + r.Salary + ":;" + r.Address + ":;" + r.Staff_Id);                    
                }
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void SaveOhterStaffData()
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"OhterStaffData.txt");
                for (int i = 0; i < list_Of_OtherStaff.Count; i++)
                {
                    csOtherStaff os = list_Of_OtherStaff[i];
                    writer.WriteLine(os.Name + ":;" + os.Cnic + ":;" + os.PhoneNumber + ":;" + os.DateOfBirth + ":;" + os.Type +
                        ":;" + os.Gender + ":;" + os.WH_Start_Time + ":;" + os.WH_End_Time + ":;" + os.Salary + ":;" + os.Address + ":;" + os.Staff_Id);                    
                }
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

        public static void LoadData()
        {
            LoadDoctorsData();
            LoadNursesrData();
            LoadPharmacistsData();
            LoadLabTechsData();
            LoadSurgeonsData();
            LoadReceptionistsData();
            LoadOhterStaffData();
        }

        #region Individual Load_Data
        private static void LoadDoctorsData()
        {
            try
            {
                StreamReader reader = new StreamReader(@"DoctorsData.txt");
                String line = reader.ReadLine();
                while (line != null)
                {
                    String[] arr = line.Split(":;");
                    csDoctor doctor = new csDoctor();
                    doctor.Name = arr[0];
                    doctor.Cnic = arr[1];
                    doctor.PhoneNumber = arr[2];
                    doctor.DateOfBirth = Convert.ToDateTime(arr[3]);
                    doctor.Email = arr[4];
                    doctor.Password = arr[5];
                    doctor.Qualification = arr[6];
                    doctor.Department = arr[7];
                    doctor.Gender = arr[8];
                    doctor.WH_Start_Time = Convert.ToDateTime(arr[9]);
                    doctor.WH_End_Time = Convert.ToDateTime(arr[10]);
                    doctor.Salary = Convert.ToInt32(arr[11]);
                    doctor.Address = arr[12];
                    doctor.Staff_Id = arr[13];
                    list_Of_Doctors.Add(doctor);
                    line = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void LoadNursesrData()
        {
            try
            {
                StreamReader reader = new StreamReader(@"NursesData.txt");
                String line = reader.ReadLine();
                while (line != null)
                {
                    String[] arr = line.Split(":;");
                    csNurse n = new csNurse();
                    n.Name = arr[0];
                    n.Cnic = arr[1];
                    n.PhoneNumber = arr[2];
                    n.DateOfBirth = Convert.ToDateTime(arr[3]);
                    n.Email = arr[4];
                    n.Password = arr[5];
                    n.Gender = arr[6];
                    n.WH_Start_Time = Convert.ToDateTime(arr[7]);
                    n.WH_End_Time = Convert.ToDateTime(arr[8]);
                    n.Salary = Convert.ToInt32(arr[9]);
                    n.Duty = arr[10];
                    n.Address = arr[11];
                    n.Staff_Id = arr[12];
                    list_Of_Nurses.Add(n);
                    line = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void LoadPharmacistsData()
        {
            try
            {
                StreamReader reader = new StreamReader(@"PharmacistsData.txt");
                String line = reader.ReadLine();
                while (line != null)
                {
                    String[] arr = line.Split(":;");
                    csPharmacist p = new csPharmacist();
                    p.Name = arr[0];
                    p.Cnic = arr[1];
                    p.PhoneNumber = arr[2];
                    p.DateOfBirth = Convert.ToDateTime(arr[3]);
                    p.Email = arr[4];
                    p.Password = arr[5];
                    p.Qualification = arr[6];
                    p.Gender = arr[7];
                    p.WH_Start_Time = Convert.ToDateTime(arr[8]);
                    p.WH_End_Time = Convert.ToDateTime(arr[9]);
                    p.Salary = Convert.ToInt32(arr[10]);
                    p.Address = arr[11];
                    p.Staff_Id = arr[12];
                    list_Of_Pharmacists.Add(p);
                    line = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void LoadLabTechsData()
        {
            try
            {
                StreamReader reader = new StreamReader(@"LabTechsData.txt");
                String line = reader.ReadLine();
                while (line != null)
                {
                    String[] arr = line.Split(":;");
                    csLabTechnician lt = new csLabTechnician();
                    lt.Name = arr[0];
                    lt.Cnic = arr[1];
                    lt.PhoneNumber = arr[2];
                    lt.DateOfBirth = Convert.ToDateTime(arr[3]);
                    lt.Email = arr[4];
                    lt.Password = arr[5];
                    lt.Qualification = arr[6];
                    lt.Gender = arr[7];
                    lt.WH_Start_Time = Convert.ToDateTime(arr[8]);
                    lt.WH_End_Time = Convert.ToDateTime(arr[9]);
                    lt.Salary = Convert.ToInt32(arr[10]);
                    lt.Address = arr[11];
                    lt.Staff_Id = arr[12];
                    list_Of_LabTechnecians.Add(lt);
                    line = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void LoadSurgeonsData()
        {
            try
            {
                StreamReader reader = new StreamReader(@"SurgeonsData.txt");
                String line = reader.ReadLine();
                while (line != null)
                {
                    String[] arr = line.Split(":;");
                    csSurgeon s = new csSurgeon();
                    s.Name = arr[0];
                    s.Cnic = arr[1];
                    s.PhoneNumber = arr[2];
                    s.DateOfBirth = Convert.ToDateTime(arr[3]);
                    s.Email = arr[4];
                    s.Password = arr[5];
                    s.Qualification = arr[6];
                    s.Department = arr[7];
                    s.Specialization = arr[8];
                    s.Experience = Convert.ToInt32(arr[9]);
                    s.Gender = arr[10];
                    s.WH_Start_Time = Convert.ToDateTime(arr[11]);
                    s.WH_End_Time = Convert.ToDateTime(arr[12]);
                    s.Salary = Convert.ToInt32(arr[13]);
                    s.Address = arr[14];
                    s.Staff_Id = arr[15];
                    list_Of_Surgeons.Add(s);

                    line = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void LoadReceptionistsData()
        {
            try
            {
                StreamReader reader = new StreamReader(@"ReceptionistsData.txt");
                String line = reader.ReadLine();
                while (line != null)
                {
                    String[] arr = line.Split(":;");
                    csReceptionist r = new csReceptionist();
                    r.Name = arr[0];
                    r.Cnic = arr[1];
                    r.PhoneNumber = arr[2];
                    r.DateOfBirth = Convert.ToDateTime(arr[3]);
                    r.Email = arr[4];
                    r.Password = arr[5];
                    r.Gender = arr[6];
                    r.WH_Start_Time = Convert.ToDateTime(arr[7]);
                    r.WH_End_Time = Convert.ToDateTime(arr[8]);
                    r.Salary = Convert.ToInt32(arr[9]);
                    r.Address = arr[10];
                    r.Staff_Id = arr[11];
                    list_Of_Receptionists.Add(r);
                    line = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void LoadOhterStaffData()
        {
            try
            {
                StreamReader reader = new StreamReader(@"OhterStaffData.txt");
                String line = reader.ReadLine();
                while (line != null)
                {
                    String[] arr = line.Split(":;");
                    csOtherStaff os = new csOtherStaff();
                    os.Name = arr[0];
                    os.Cnic = arr[1];
                    os.PhoneNumber = arr[2];
                    os.DateOfBirth = Convert.ToDateTime(arr[3]);
                    os.Type = arr[4];
                    os.Gender = arr[5];
                    os.WH_Start_Time = Convert.ToDateTime(arr[6]);
                    os.WH_End_Time = Convert.ToDateTime(arr[7]);
                    os.Salary = Convert.ToInt32(arr[8]);
                    os.Address = arr[9];
                    os.Staff_Id = arr[10];
                    list_Of_OtherStaff.Add(os);
                    line = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

    }
}
