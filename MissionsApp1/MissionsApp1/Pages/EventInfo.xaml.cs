using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissionsApp1.Classes;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MissionsApp1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventInfo : ContentPage
    {
        public EventInfo(Mission mission)
        {
            InitializeComponent();

            EventNameLabel.Text = mission.Name;
            OrganizationNameLabel.Text = mission.OrganizationName;
            EventAddressLabel.Text = mission.Address;
            EventCityLabel.Text = mission.City;
            EventStateLabel.Text = mission.State;
            EventZipCodeLabel.Text = mission.ZipCode;
            //EventLatitudeLabel.Text = Convert.ToString(mission.Latitude);
            //EventLongitudeLabel.Text = Convert.ToString(mission.Longitude);
            EventDateLabel.Text = mission.Date;
            EventStartTime.Text = mission.StartTime;
            EventEndTime.Text = mission.EndTime;


        }
    }
}