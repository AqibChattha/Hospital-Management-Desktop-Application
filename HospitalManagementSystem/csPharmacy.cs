using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    class csPharmacy:csRoom
    {
        public List<csPharmacist> pharmacists { get; set; }
        public List<csMedicine> List_Of_Medicines { get; set; }
    }
}
