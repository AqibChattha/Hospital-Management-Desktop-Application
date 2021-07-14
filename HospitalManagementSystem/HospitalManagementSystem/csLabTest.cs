using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csLabTest
    {
        public String PatientName { get; set; }
        public String PatientId { get; set; }
        public String TestId { get; set; }
        public csSample Sample { get; set; }
        public DateTime DueDate { get; set; }
        public String labID { get; set; }
        public String Result { get; set; }

        public csLabTest()
        {

        }
        public csLabTest(string pname, string pID, String lab, csSample sample, DateTime due)
        {
            PatientName = pname;
            PatientId = pID;
            Result = "";
            labID = lab;
            DueDate = due;
            Sample = sample;
            TestId = GenerateTestId();
        }
        public csLabTest(string pname, string pID, String tID, String lab, DateTime due, csSample sample, string res)
        {
            PatientName = pname;
            PatientId = pID;
            Result = res;
            TestId = tID;
            labID = lab;
            DueDate = due;
            Sample = sample;
        }

        private String GenerateTestId()
        {
            String id = "";
            bool flag = true;
            for (int i = 1; i <= csHospital.Instence.getLabTests().Count + 10; i++)
            {
                id = "TET-" + i;
                for (int j = 0; j < csHospital.Instence.getLabTests().Count; j++)
                {
                    if (id.Equals(csHospital.Instence.getLabTests()[j].TestId))
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
        public void AddResult(String result)
        {
            this.Result = result;
        }
    }
}
