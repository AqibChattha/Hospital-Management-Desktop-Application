using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    class csInPatient:csPatient
    {
        public List<String> Issue { get; set; }
        public List<String> AffectedArea { get; set; }
        public int Room_Id { get; set; }
        public void CheckUp() { }
        public void PayBill() { }
        public void BuyMedicience() { }
    }
}
