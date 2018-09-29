using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_PRODUCTION.Models.Extented
{
    public class PersonalDetail
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }
        public float Price { get; set; }

        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}