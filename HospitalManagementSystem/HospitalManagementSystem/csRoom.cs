using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public abstract class csRoom
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public List<csTools> Tools { get; set; }

    }
}
