using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csReceptionist:csAdministrativeStaff
    {

        public csReceptionist()
        {

        }
        public csReceptionist(string name, string cnic, string phoneno, string email, string pass, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
        {
            Name = name;
            Cnic = cnic;
            PhoneNumber = phoneno;
            Email = email;
            Password = pass;
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
            for (int i = 1; i <= csHospital.Instence.getReceptionists().Count+10; i++)
            {
                id = "REC-" + i;
                for (int j = 0; j < csHospital.Instence.getReceptionists().Count; j++)
                {
                    if (id.Equals(csHospital.Instence.getReceptionists()[j].Staff_Id))
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


        public void AddPatient() { }
        public void UpdatePatient() { }
        public void RemovePatient() { }
        public void ViewPatient() { }
        public void SearchPatient() { }
        public void AddApointments() { }
    }
}
