using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public abstract class csAdministrativeStaff:csStaff
    {
        public String Duty { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        
    }
}
