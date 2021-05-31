using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    class csDoctor:csStaff
    {
        public String Email { get; set; }
        public String Password { get; set; }
        public String Qualification { get; set; }
        public String Specialist { get; set; }
        public String Department { get; set; }

        public void ViewPatientProfile() { }
        public void PrescribeMedicine() { }
        public void RecommendTest() { }
    }
}
