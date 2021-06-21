using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    class Validat
    {

        #region individual_Validators
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
            if ((((int)cnic[14])-48) % 2 == 0 && gender == "Female")
            {
                return true;
            }
            if ((((int)cnic[14])-48) % 2 != 0 && gender == "Male")
            {
                return true;
            }
            return false;
        }
        private static bool IsValidQualification(String qualification, List<String> lis_Of_qualifiction)
        {
            if (qualification == "")
            {
                return false;
            }
            else
            {
                for (int i = 0; i < lis_Of_qualifiction.Count; i++)
                {
                    if (qualification == lis_Of_qualifiction[i])
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        private static bool IsValidDepartment(String department, List<String> lis_Of_department)
        {
            if (department == "")
            {
                return false;
            }
            else
            {
                for (int i = 0; i < lis_Of_department.Count; i++)
                {
                    if (department == lis_Of_department[i])
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
                && IsValidPassword(pass) == true && IsValidQualification(qualification, csHospital.Instence.getDoctorQualifications()) == true
                && IsValidDepartment(dep, csHospital.Instence.getDepartments()) == true && isValidAddress(address) == true
                && IsEqualGender(cnic, gender) == true && IsvalidSalary(salary) == true
                && isValidDateOFBirth(dob) == true && isValidWorkingHours(sTime, eTime) == true)
            {
                return true;
            }
            //MessageBox.Show(IsValidName(name).ToString()+ IsValidCnic(cnic).ToString()+
            //    IsValidPhoneNumber(phoneno).ToString()+IsValidEmail(email).ToString()+
            //    IsValidPassword(pass).ToString()+IsValidQualification(qualification, csHospital.Instence.getQualifications()).ToString());
            //MessageBox.Show(IsValidDepartment(dep, csHospital.Instence.getDepartments()).ToString()+isValidAddress(address).ToString()+
            //    IsEqualGender(cnic, gender).ToString()+IsvalidSalary(salary).ToString()+
            //    isValidDateOFBirth(dob)+isValidWorkingHours(sTime, eTime).ToString());
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
            //MessageBox.Show(IsValidName(name).ToString()+ IsValidCnic(cnic).ToString()+
            //    IsValidPhoneNumber(phoneno).ToString()+IsValidEmail(email).ToString()+
            //    IsValidPassword(pass).ToString()+IsValidQualification(qualification, csHospital.Instence.getQualifications()).ToString());
            //MessageBox.Show(isValidAddress(address).ToString()+
            //    IsEqualGender(cnic, gender).ToString()+IsvalidSalary(salary).ToString()+
            //    isValidDateOFBirth(dob)+isValidWorkingHours(sTime, eTime).ToString());
            return false;
        }
        public static bool LabTech(string name, string cnic, string phoneno, string email, string pass, string qualification, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
        {
            if (IsValidName(name) == true && IsValidCnic(cnic) == true
                && IsValidPhoneNumber(phoneno) == true && IsValidEmail(email) == true
                && IsValidPassword(pass) == true && IsValidQualification(qualification, csHospital.Instence.getLabTechrQualifications()) == true
                && isValidAddress(address) == true
                && IsEqualGender(cnic, gender) == true && IsvalidSalary(salary) == true
                && isValidDateOFBirth(dob) == true && isValidWorkingHours(sTime, eTime) == true)
            {
                return true;
            }
            //MessageBox.Show(IsValidName(name).ToString()+ IsValidCnic(cnic).ToString()+
            //    IsValidPhoneNumber(phoneno).ToString()+IsValidEmail(email).ToString()+
            //    IsValidPassword(pass).ToString()+IsValidQualification(qualification, csHospital.Instence.getQualifications()).ToString());
            //MessageBox.Show(isValidAddress(address).ToString()+
            //    IsEqualGender(cnic, gender).ToString()+IsvalidSalary(salary).ToString()+
            //    isValidDateOFBirth(dob)+isValidWorkingHours(sTime, eTime).ToString());
            return false;
        }

    }
}
