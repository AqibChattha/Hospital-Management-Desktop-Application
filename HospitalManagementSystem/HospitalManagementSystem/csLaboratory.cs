using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csLaboratory:csRoom
    {

        public String Name { get; set; }

        public csLaboratory()
        {

        }
        public csLaboratory(String id, String name, String address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

    }
}
