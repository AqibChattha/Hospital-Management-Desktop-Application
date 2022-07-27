using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csOutPatient:csPatient
    {
        public String Email { get; set; }
        public String Password { get; set; }
        public List<String> Disease { get; set; }

        public csOutPatient()
        {

        }

        public csOutPatient(string name, string cnic, string phoneNo, string gender, DateTime dob, string address, string email, string password)
        {
            Name = name;
            Cnic = cnic;
            PhoneNumber = phoneNo;
            Gender = gender;
            DateOfBirth = dob;
            Address = address;
            Email = email;
            Password = password;
            Patient_Id = GenerateTestId();
            Disease = new List<string>();
        }

        public csOutPatient(string name, string cnic, string phoneNo, string gender, DateTime dob, string address, string email, string password, string pID, List<String> disease)
        {
            Disease = new List<string>();
            Name = name;
            Cnic = cnic;
            PhoneNumber = phoneNo;
            Gender = gender;
            DateOfBirth = dob;
            Address = address;
            Email = email;
            Password = password;
            Patient_Id = pID;
            Disease.AddRange(disease);
        }

        public void CheckUp() { }
        public void PayBill() { }
        public void BuyMedicience() { }

    }
}
