using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    class csSurgeon:csDoctor
    {
        public int Experience { get; set; }
        public String Specialist { get; set; }

        public void PerformSurgery() { }
    }
}
