﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionsApp1.Classes
{
    public class Mission
    {
        public string ID { get; set; }
        public string OrganizationID { get; set; }
        public string Name { get; set; }
        public string OrganizationName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public void SetDate()
        {

        }
        public void SetTime()
        {

        }

    }
}
