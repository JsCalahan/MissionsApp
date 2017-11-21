using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Settings.Abstractions;
using Plugin.Settings;
using Newtonsoft.Json;

namespace MissionsApp1.Classes
{
    class Settings
    {
        private const string UserJson = "";
        private static readonly string UserJsonDefault = "";


        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }
        public static User UserData
        {
            get
            {
                string data = AppSettings.GetValueOrDefault(UserJson, UserJsonDefault);
                if (String.IsNullOrEmpty(data))
                {
                    return null;
                }
                else
                {
                    return JsonConvert.DeserializeObject<User>(data);
                }
            }
            set
            {
                string data = JsonConvert.SerializeObject(value);
                AppSettings.AddOrUpdateValue(UserJson, data);
            }
        }

        public static bool isOrganization
        {
            get
            {
                bool data = AppSettings.GetValueOrDefault("isOrganization", false);
                return data;
            }
            set
            {
                AppSettings.AddOrUpdateValue("isOrganization", value);
            }
        }

    }
}


