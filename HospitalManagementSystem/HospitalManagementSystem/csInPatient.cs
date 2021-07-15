using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    class csInPatient:csPatient
    {
        public List<String> Issue { get; set; }
        public List<String> AffectedArea { get; set; }
        public String Room_Id { get; set; }


        public csInPatient()
        {

        }

        public csInPatient(string name, string cnic, string phoneNo, string gender, DateTime dob, string address, string roomId)
        {
            Name = name;
            Cnic = cnic;
            PhoneNumber = phoneNo;
            Gender = gender;
            DateOfBirth = dob;
            Address = address;
            Room_Id = roomId;
            Patient_Id = GenerateTestId();
            Issue = new List<string>();
            AffectedArea = new List<string>();
        }

        public csInPatient(string name, string cnic, string phoneNo, string gender, DateTime dob, string address, string roomId, string pID, List<String> issue, List<String> affectArea)
        {
            Issue = new List<string>();
            AffectedArea = new List<string>();
            Name = name;
            Cnic = cnic;
            PhoneNumber = phoneNo;
            Gender = gender;
            DateOfBirth = dob;
            Room_Id = roomId;
            Address = address;

            Patient_Id = pID;
            Issue.AddRange(issue);
            AffectedArea.AddRange(affectArea);
        }


        public void CheckUp() { }
        public void PayBill() { }
        public void BuyMedicience() { }
    }
}
