using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_PRODUCTION.Models.Extented
{
    public class Booking
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string DoctorName { get; set; }
        public string BookingDate { get; set; }
        public string BookingTime { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public string DoctorAddress { get; set; }
        public string UserName { get; set; }
        
    }
}