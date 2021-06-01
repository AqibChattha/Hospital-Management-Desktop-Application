using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    class csHospital
    {
        public List<csRoom> List_Of_Rooms { get; set; }
        public List<csPatient> List_Of_Patients { get; set; }
        public List<csStaff> List_Of_Staffs { get; set; }
        public List<csPatientRecord> List_Of_Patient_record { get; set; }
    }
}
