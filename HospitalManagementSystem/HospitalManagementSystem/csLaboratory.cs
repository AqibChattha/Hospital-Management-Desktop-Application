using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    class csLaboratory:csRoom
    {
        public  List<String> List_Of_Samples{ get; set; }
        public List<csLabTest> List_Of_Test { get; set; }
        public List<csLabTechnician> Lab_Technicians { get; set; }
        public List<csLabTestReport> Test_Record { get; set; }


    }
}
