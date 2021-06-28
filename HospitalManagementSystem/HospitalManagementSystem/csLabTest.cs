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
        public csLabTest(string pname, string pID, String tID, String lab, DateTime due, csSample sample)
        {
            PatientName = pname;
            PatientId = pID;
            Result = "";
            TestId = tID;
            labID = lab;
            DueDate = due;
            Sample = sample;
        }
        public csLabTest(string pname, string pID, string res, String tID, String lab, DateTime due, csSample sample)
        {
            PatientName = pname;
            PatientId = pID;
            Result = res;
            TestId = tID;
            labID = lab;
            DueDate = due;
            Sample = sample;
        }
    }
}
