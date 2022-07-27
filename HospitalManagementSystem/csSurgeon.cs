using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csSurgeon:csDoctor
    {
        public int Experience { get; set; }
        public String Specialization { get; set; }


        public csSurgeon()
        {

        }
        public csSurgeon(string name, string cnic, string phoneno, string email, string pass, string qualification, string dep, String specialization, int experiance, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
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
            Experience = experiance;
            Specialization = specialization;
            Staff_Id = GenerateStaffId();
        }
        private String GenerateStaffId()
        {
            String id = "";
            bool flag = true;
            for (int i = 1; i <= csHospital.Instence.getSurgeons().Count+10; i++)
            {
                id = "MES-" + i;
                for (int j = 0; j < csHospital.Instence.getSurgeons().Count; j++)
                {
                    if (id.Equals(csHospital.Instence.getSurgeons()[j].Staff_Id))
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


        public void PerformSurgery() { }
    }
}
