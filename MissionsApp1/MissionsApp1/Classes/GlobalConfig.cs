using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using Newtonsoft.Json;

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
        