using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int staffID { get; set; }

        public bool Active { get; set; }
        public DateTime HireDate { get; set; }
        public string staffEmail { get; set; }
        public string staffName { get; set; }
        public string department { get; set; }
    }
}