using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csSample
    {
        public String Name { get; set; }
        public Double Cost { get; set; }

        public csSample()
        {

        }

        public csSample(String name, Double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
