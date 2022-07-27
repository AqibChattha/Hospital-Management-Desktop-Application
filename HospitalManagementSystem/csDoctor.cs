using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csDoctor:csStaff
    {
        public String Email { get; set; }
        public String Password { get; set; }
        public String Qualification { get; set; }
        public String Department { get; set; }
      
        public csDoctor()
        {

        }
        public csDoctor(string name, string cnic, string phoneno, string email, string pass, string qualification, string dep, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
        {
            Name = name;
            Cnic = cnic;
            PhoneNumber = phoneno;
            Email = email;
            Password = pass;
            Qualification = qualification;
            Department = dep;
            Address = address;
            Gender = gender;
            Salary = salary;
            DateOfBirth = dob;
            WH_Start_Time = sTime;
            WH_End_Time = eTime;
            Staff_Id = GenerateStaffId();
        }
        private String GenerateStaffId()
        {
            String id = "";
            bool flag = true;
            for (int i = 1; i <= csHospital.Instence.getDoctors().Count+10; i++)
            {
                id = "MED-" + i;
                for (int j = 0; j < csHospital.Instence.getDoctors().Count; j++)
                {
                    if (id.Equals(csHospital.Instence.getDoctors()[j].Staff_Id)){
                        flag = false;
                    }
                }
                if (flag == false)
                {
                    flag = true;
                }
                else
                {
                    return id;
                }
            }       
            return id;
        }

        public void ViewPatientProfile() { }
        public void PrescribeMedicine() { }
        public void RecommendTest() { }
    }
}
