using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    class csIllStaff:csPatient
    {
        public String Staff_Type { get; set; }
        public String Staff_Id { get; set; }
        public List<String> Disease { get; set; }


        public csIllStaff()
        {

        }

        public csIllStaff(string name, string cnic, string phoneNo, string gender, DateTime dob, string address, string type, string id)
        {
            Name = name;
            Cnic = cnic;
            PhoneNumber = phoneNo;
            Gender = gender;
            DateOfBirth = dob;
            Address = address;
            Patient_Id = GenerateTestId();
            Staff_Type = type;
            Staff_Id = id;
            Disease = new List<string>();
        }

        public csIllStaff(string name, string cnic, string phoneNo, string gender, DateTime dob, string address, string type, string id, string email, string password, string pID, List<String> disease)
        {
            Disease = new List<string>();
            Name = name;
            Cnic = cnic;
            PhoneNumber = phoneNo;
            Gender = gender;
            DateOfBirth = dob;
            Address = address;
            Patient_Id = pID;
            Staff_Type = type;
            Staff_Id = id;
            Disease.AddRange(disease);
        }


        public void SubmitApplication() { }
    }
}
