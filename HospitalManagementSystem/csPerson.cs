using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public abstract class csPerson
    {
        public String Name { get; set; }
        public String Gender { get; set; }
        public String Cnic { get; set; }
        public String PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Address { get; set; }
    }
}
