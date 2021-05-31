using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    class csOutPatient:csPatient
    {
        public String Email { get; set; }
        public String Password { get; set; }
        public List<String> Diease { get; set; }

        public void CheckUp() { }
        public void PayBill() { }
        public void BuyMedicience() { }

    }
}
