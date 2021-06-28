using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csPharmacist:csStaff
    {
        public String Email { get; set; }
        public String Password { get; set; }
        public String Qualification { get; set; }


        public csPharmacist()
        {

        }
        public csPharmacist(string name, string cnic, string phoneno, string email, string pass, string qualification, string address, string gender, int salary, DateTime dob, DateTime sTime, DateTime eTime)
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
            for (int i = 1; i <= csHospital.Instence.getPharmacist().Count+10; i++)
            {
                id = "PHR-" + i;
                for (int j = 0; j < csHospital.Instence.getPharmacist().Count; j++)
                {
                    if (id.Equals(csHospital.Instence.getPharmacist()[j].Staff_Id))
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

        public void SellMedicine() { }
        public void SearchMedicine() { }
        public void ViewMedicine() { }
        public void DeleteMedicine() { }
        public void UpdateMedicine() { }
        public void AddMedicine() { }
        public void AddTools() { }
        public void RemoveTools() { }
    }
}
