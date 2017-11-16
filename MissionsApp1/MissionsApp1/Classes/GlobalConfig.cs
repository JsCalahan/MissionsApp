using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MissionsApp1.Classes
{
    public static class GlobalConfig
    {
        public static MobileServiceClient MobileService =
        new MobileServiceClient(
        "https://missionsapp.azurewebsites.net");

        public static bool isOrganization = false;
        public static User currentUser;
    }
}
