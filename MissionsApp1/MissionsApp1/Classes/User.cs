using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionsApp1.Classes
{
    class User
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }

        public void Register()
        {

        }

        public bool Authenticate()
        {
            throw new NotImplementedException();
        }

        public void Donate(double amount)
        {

        }


    }
}
