using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
   public  class csLabTechnician : csStaff
    {
        public String Email { get; set; }
        public String Password { get; set; }
        public String Qualification { get; set; }


        public csLabTechnician()
        {

        }
        public csLabTechnician(string name, string cnic, string phoneno, string email, string pass, string qualification, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
        {
            Name = name;
            Cnic = cnic;
            PhoneNumber = phoneno;
            Email = email;
            Password = pass;
            Qualification = qualification;
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
            for (int i = 1; i <= csHospital.Instence.getLabTech().Count+10; i++)
            {
                id = "TEC-" + i;
                for (int j = 0; j < csHospital.Instence.getLabTech().Count; j++)
                {
                    if (id.Equals(csHospital.Instence.getLabTech()[j].Staff_Id))
                    {
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
    }
}
