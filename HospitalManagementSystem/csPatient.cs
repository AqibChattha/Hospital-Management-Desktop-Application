using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csPatient : csPerson
    {
       
        public String Patient_Id { get; set; }

        protected String GenerateTestId()
        {
            String id = "";
            bool flag = true;
            for (int i = 1; i <= csHospital.Instence.getPatients().Count + 10; i++)
            {
                id = "EPU-" + i;
                for (int j = 0; j < csHospital.Instence.getPatients().Count; j++)
                {
                    if (id.Equals(csHospital.Instence.getPatients()[j].Patient_Id))
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
