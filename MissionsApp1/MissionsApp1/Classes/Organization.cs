﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionsApp1.Classes
{
    public class Organization
    {
        public string ID { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public void Register()
        {

        }

        public bool Authenticate()
        {
            throw new NotImplementedException();
        }

        public void AddMission()
        {

        }

        public void RemoveMission()
        {

        }
    }
}
