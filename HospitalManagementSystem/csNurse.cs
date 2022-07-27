using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csNurse:csAdministrativeStaff
    {
        public csNurse()
        {

        }
        public csNurse(string name, string cnic, string phoneno, string email, string pass, string duty, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
        {
            Name = name;
            Cnic = cnic;
            PhoneNumber = phoneno;
            Email = email;
            Password = pass;
            Duty = duty;
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
            for (int i = 1; i <= csHospital.Instence.getNurses().Count+10; i++)
            {
                id = "NUT-" + i;
                for (int j = 0; j < csHospital.Instence.getNurses().Count; j++)
                {
                    if (id.Equals(csHospital.Instence.getNurses()[j].Staff_Id))
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

        public void AdministerMedicine() { }
        public void AssignWard() { }
        public void AddTools() { }
        public void RemoveTools() { }
        public void AddBloodPackect() { }
        public void RemoveBloodPackets() { }
    }
}
