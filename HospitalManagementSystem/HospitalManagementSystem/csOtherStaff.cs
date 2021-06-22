using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csOtherStaff:csStaff
    {
        public String Type { get; set; }

        public csOtherStaff()
        {

        }
        public csOtherStaff(string name, string cnic, string phoneno, String type, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
        {
            Name = name;
            Cnic = cnic;
            PhoneNumber = phoneno;
            Type = type;
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
            for (int i = 0; i <= csHospital.Instence.getDoctors().Count; i++)
            {
                id = "ACO-" + (i + 1);
                for (int j = 0; j < csHospital.Instence.getDoctors().Count; j++)
                {
                    if (id.Equals(csHospital.Instence.getDoctors()[j].Staff_Id))
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
