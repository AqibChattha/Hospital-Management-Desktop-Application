using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    public class csWard:csRoom
    {
        public String Room_Rating { get; set; }
        

        public csWard()
        {
            Id = "";
            Address = "";
            Room_Rating = "";
        }
        public csWard(string id, string address, string roomRating)
        {
            Id = id;
            Address = address;
            Room_Rating = roomRating;
        }
    }
}
