using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem 
{
    public class csStaff : csPerson 
    {
        
        public String Staff_Id { get; set; }
        public DateTime WH_Start_Time { get; set; }
        public DateTime WH_End_Time { get; set; }
        public int Salary { get; set; }
       
    }
}
