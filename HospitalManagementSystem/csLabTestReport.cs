using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csLabTestReport
    {
        public String Name { get; set; }
        public String Lab_Technician_Name { get; set; }
        public String Report_Id { get; set; }
        public String Test_Result { get; set; }
        public double Cost { get; set; }
        public DateTime Test_Date { get; set; }
    }
}
