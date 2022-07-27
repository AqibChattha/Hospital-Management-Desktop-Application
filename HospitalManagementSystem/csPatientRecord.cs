using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    class csPatientRecord
    {
        public String Name { get; set; }
        public String DoctorName { get; set; }
        public String Blood_Group { get; set; }
        public String Doctor_Review { get; set; }
        public List<String> Dieases { get; set; }
        public double Cost { get; set; }

    }
}
