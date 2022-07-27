using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public abstract class Validat
    {

        #region individual_Validators

        private static bool isValidRoomId(String id)
        {
            List<csRoom> rooms = csHospital.Instence.getRooms();
            for (int i = 0; i < rooms.Count; i++)
            {
                if (rooms[i].Id.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool isValidTestID(String id)
        {
            String idt = "";
            for (int i = 0; i < csHospital.Instence.getLabTests().Count+2; i++)
            {
                idt = "TST-" + i;
                if (idt.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool isValidSample(csSample sample, List<csSample> samples)
        {
            for(int i=0; i<samples.Count; i++)
            {
                if(sample.Name.Equals(samples[i].Name))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool isValidLaboratories(String labID, List<csLaboratory> laboratories)
        {
            for (int i = 0; i < laboratories.Count; i++)
            {
                if (labID.Equals(laboratories[i].Id))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsValidName(String name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!((name[i] >= 'A' && name[i] <= 'Z') || (name[i] >= 'a' && name[i] <= 'z') || name[i]==' '))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool IsValidCnic(String cnic)
        {
            if (cnic.Length == 15)
            {
                return true;
            }
            return false;
        }
        private static bool IsValidPhoneNumber(String phoneNo)
        {
            if (phoneNo.Length == 12)
            {
                return true;
            }
            return false;
        }
        private static bool IsEqualGender(String cnic, String gender)
        {
            if (cnic.Length == 15)
            {
                if ((((int)cnic[14]) - 48) % 2 == 0 && gender == "Female")
                {
                    return true;
                }
                if ((((int)cnic[14]) - 48) % 2 != 0 && gender == "Male")
                {
                    return true;
                }
            }
            return false;
        }
        private static bool ListContainElement(String element, List<String> list)
        {
            if (element == "")
            {
                return false;
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (element == list[i])
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        private static bool IsvalidSalary(int salary)
        {
            if (salary == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool isValidDateOFBirth(DateTime date)
        {
            if (date.CompareTo(DateTime.Now) < 0)
            {
                return true;
            }
            return false;

        }
        private static bool isValidWorkingHours(DateTime dateStart, DateTime dateEnd)
        {
            if (dateStart.CompareTo(dateEnd) < 0)
            {
                return true;
            }
            return false;

        }
        private static bool isValidAddress(String address)
        {
            if (address != "")
            {
                return true;
            }
            return false;

        }
        private static bool IsValidEmail(string email)
        {
            int dot = -1;
            int at = -1;
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    at++;
                }
                else if (email[i] == '.')
                {
                    dot++;
                }

            }
            if (dot == -1)
            {
                return false;
            }
            else if (at == -1)
            {
                return false;
            }
            else if (dot < at)
            {
                return false;
            }
            return true;
        }
        private static int GetAge(String b_Date)
        {

            DateTime birthday = DateTime.Parse(b_Date);
            DateTime today = DateTime.Now;
            int i = birthday.CompareTo(today);
            if (i < 0)
            {

                TimeSpan t = today - birthday;
                DateTime age = DateTime.MinValue + t;

                int years = age.Year - 1;
                return years;
            }
            else
            {
                return 0;
            }
        }
        private static bool IsValidPassword(String pass)
        {

            int uppercaseLetterCount = 0;
            int lowerCaseLetterCount = 0;
            int numberCount = 0;
            int specialCharactersCount = 0;
            int[] specialChar = { '!', '@', '#', ';', '.', '&', '*', '%', ',', '|' };
            if (pass.Length >= 8)
            {
                foreach (char c in pass)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        uppercaseLetterCount++;
                    }
                    else if (c >= 'a' && c <= 'z')
                    {
                        lowerCaseLetterCount++;
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        numberCount++;
                    }
                    foreach (char ch in specialChar)
                    {
                        if (c == ch)
                        {
                            specialCharactersCount++;
                        }
                    }
                }

                if (uppercaseLetterCount == 0 || lowerCaseLetterCount == 0 || numberCount == 0 || specialCharactersCount == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private static bool IsValidDuty(String a)
        {
            if (a.Equals(""))
            {
                return false;
            }
            return true;
        }
        #endregion

        public static bool Doctor(string name, string cnic, string phoneno, string email, string pass, string qualification, string dep, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
        {
            if (IsValidName(name) == true && IsValidCnic(cnic) == true
                && IsValidPhoneNumber(phoneno) == true && IsValidEmail(email) == true
                && IsValidPassword(pass) == true && ListContainElement(qualification, csHospital.Instence.getDoctorQualifications()) == true
                && ListContainElement(dep, csHospital.Instence.getDepartments()) == true && isValidAddress(address) == true
                && IsEqualGender(cnic, gender) == true && IsvalidSalary(salary) == true
                && isValidDateOFBirth(dob) == true && isValidWorkingHours(sTime, eTime) == true)
            {
                return true;
            }
            //MessageBox.Show(IsValidName(name).ToString() + IsValidCnic(cnic) +
            //    IsValidPhoneNumber(phoneno) + isValidDateOFBirth(dob) + IsValidEmail(email) +
            //    IsValidPassword(pass) + ListContainElement(qualification, csHospital.Instence.getDoctorQualifications()) +
            //    ListContainElement(dep, csHospital.Instence.getDepartments()) + IsEqualGender(cnic, gender) + 
            //    isValidWorkingHours(sTime, eTime) + IsvalidSalary(salary) + isValidAddress(address));
            return false;
        }
        public static bool Nurse(string name, string cnic, string phoneno, string email, string pass, string duty, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
        {
            if (IsValidName(name) == true && IsValidCnic(cnic) == true
                && IsValidPhoneNumber(phoneno) == true && IsValidEmail(email) == true
                && IsValidPassword(pass) == true && isValidAddress(address) == true
                && IsValidDuty(duty) == true
                && IsEqualGender(cnic, gender) == true && IsvalidSalary(salary) == true
                && isValidDateOFBirth(dob) == true && isValidWorkingHours(sTime, eTime) == true)
            {
                return true;
            }
            //MessageBox.Show(IsValidName(name).ToString() + IsValidCnic(cnic) +
            //    IsValidPhoneNumber(phoneno) + isValidDateOFBirth(dob) + IsValidEmail(email) +
            //    IsValidPassword(pass) + IsvalidSalary(salary) + IsEqualGender(cnic, gender) +
            //    isValidWorkingHours(sTime, eTime) + IsValidDuty(duty) + isValidAddress(address));
            return false;
        }
        public static bool LabTech_Pharmacist(string name, string cnic, string phoneno, string email, string pass, string qualification, List<String> qualificationList, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
        {
            if (IsValidName(name) == true && IsValidCnic(cnic) == true
                && IsValidPhoneNumber(phoneno) == true && IsValidEmail(email) == true
                && IsValidPassword(pass) == true && ListContainElement(qualification, qualificationList) == true
                && isValidAddress(address) == true
                && IsEqualGender(cnic, gender) == true && IsvalidSalary(salary) == true
                && isValidDateOFBirth(dob) == true && isValidWorkingHours(sTime, eTime) == true)
            {
                return true;
            }
            //MessageBox.Show(IsValidName(name).ToString() + IsValidCnic(cnic) +
            //    IsValidPhoneNumber(phoneno) + isValidDateOFBirth(dob) + IsValidEmail(email) +
            //    IsValidPassword(pass) + ListContainElement(qualification, qualificationList) + IsvalidSalary(salary) +
            //    IsEqualGender(cnic, gender) + isValidWorkingHours(sTime, eTime) + isValidAddress(address));
            return false;
        }
        public static bool Surgeon(string name, string cnic, string phoneno, string email, string pass, string qualification, string dep, String Specialization, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
        {
            if (IsValidName(name) == true && IsValidCnic(cnic) == true
                && IsValidPhoneNumber(phoneno) == true && IsValidEmail(email) == true
                && IsValidPassword(pass) == true && ListContainElement(qualification, csHospital.Instence.getSurgeonQualifications()) == true
                && ListContainElement(dep, csHospital.Instence.getDepartments()) == true && isValidAddress(address) == true
                && ListContainElement(Specialization, csHospital.Instence.getSurgeonSpecializations()) == true
                && IsEqualGender(cnic, gender) == true && IsvalidSalary(salary) == true
                && isValidDateOFBirth(dob) == true && isValidWorkingHours(sTime, eTime) == true)
            {
                return true;
            }
            //MessageBox.Show(IsValidName(name).ToString() + IsValidCnic(cnic) +
            //    IsValidPhoneNumber(phoneno) + isValidDateOFBirth(dob) + IsValidEmail(email) +
            //    IsValidPassword(pass) + ListContainElement(qualification, csHospital.Instence.getSurgeonQualifications()) +
            //    ListContainElement(dep, csHospital.Instence.getDepartments()) + ListContainElement(Specialization, csHospital.Instence.getSurgeonSpecializations()) +
            //    IsEqualGender(cnic, gender) + isValidWorkingHours(sTime, eTime) + IsvalidSalary(salary) + isValidAddress(address));
            return false;
        }
        public static bool Receptionist(string name, string cnic, string phoneno, string email, string pass, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
        {
            if (IsValidName(name) == true && IsValidCnic(cnic) == true
                && IsValidPhoneNumber(phoneno) == true && IsValidEmail(email) == true
                && IsValidPassword(pass) == true && isValidAddress(address) == true
                && IsEqualGender(cnic, gender) == true && IsvalidSalary(salary) == true
                && isValidDateOFBirth(dob) == true && isValidWorkingHours(sTime, eTime) == true)
            {
                return true;
            }
            //MessageBox.Show(IsValidName(name).ToString() + IsValidCnic(cnic) +
            //    IsValidPhoneNumber(phoneno) + isValidDateOFBirth(dob) + IsValidEmail(email) +
            //    IsValidPassword(pass) +
            //    isValidWorkingHours(sTime, eTime) + IsvalidSalary(salary) + isValidAddress(address));
            return false;
        }
        public static bool OtherStaff(string name, string cnic, string phoneno, String type, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
        {
            if (IsValidName(name) == true && IsValidCnic(cnic) == true && ListContainElement(type, csHospital.Instence.getOtherStaffTypes()) == true
                && IsValidPhoneNumber(phoneno) == true && isValidAddress(address) == true
                && IsEqualGender(cnic, gender) == true && IsvalidSalary(salary) == true
                && isValidDateOFBirth(dob) == true && isValidWorkingHours(sTime, eTime) == true)
            {
                return true;
            }
            //MessageBox.Show(IsValidName(name).ToString() + IsValidCnic(cnic) +
            //    IsValidPhoneNumber(phoneno) + isValidDateOFBirth(dob) +
            //    isValidWorkingHours(sTime, eTime) + IsvalidSalary(salary) + isValidAddress(address));
            return false;
        }

        //Incomplete and will be completed after patient portion is done
        public static bool LabTest(string pname, string pID, String lab, DateTime due, csSample sample)
        {
            if(IsValidName(pname) && isValidSample(sample, csHospital.Instence.getSamples()) &&
                isValidLaboratories(lab, csHospital.Instence.getLaboratories()))
            {
                return true;
            }
            return false;
        }

        public static bool OutPatient(string name, string cnic, string phoneNo, DateTime dob, string address, string email, string password)
        {
            if(IsValidName(name) && IsValidCnic(cnic) && IsValidPhoneNumber(phoneNo) && isValidDateOFBirth(dob) &&
                isValidAddress(address) && isValidAddress(email) && IsValidPassword(password))
            {
                return true;
            }
            return false;
        }

        public static bool InPatient(string name, string cnic, string phoneNo, DateTime dob, string address, string roomId)
        {
            if (IsValidName(name) && IsValidCnic(cnic) && IsValidPhoneNumber(phoneNo) && isValidDateOFBirth(dob) &&
                isValidAddress(address) && isValidRoomId(roomId))
            {
                return true;
            }
            return false;
        }
        // incomplete......
        public static bool IllStaff(string name, string cnic, string phoneNo, DateTime dob, string address, string type, string id)
        {
            if (IsValidName(name) && IsValidCnic(cnic) && IsValidPhoneNumber(phoneNo) && isValidDateOFBirth(dob) &&
                isValidAddress(address))
            {
                return true;
            }
            return false;
        }

    }
}
