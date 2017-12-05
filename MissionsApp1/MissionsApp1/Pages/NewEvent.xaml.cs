using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissionsApp1.Classes;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Globalization;

namespace MissionsApp1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewEvent : ContentPage
    {
        public NewEvent()
        {
            InitializeComponent();
        }

        private async void CreateEvent_Clicked(object sender, EventArgs e)
        {
            Mission mission = new Mission();

            mission.Name = EventName.Text;
            mission.OrganizationName = GlobalConfig.currentUser.FirstName;
            mission.Address = EventAddress.Text;
            mission.City = EventCity.Text;
            mission.State = EventState.Text;
            mission.ZipCode = EventZipCode.Text;
            mission.Latitude = Convert.ToDouble(EventLatitude.Text);
            mission.Longitude = Convert.ToDouble(EventLongitude.Text);
            mission.Date = EventDate.Date;
            mission.StartTime = EventStartTime.Time.ToString(/*"hh:mm tt", CultureInfo.InvariantCulture*/);
            mission.EndTime = EventEndTime.Time.ToString(/*"hh:mm tt", CultureInfo.InvariantCulture*/);

            await GlobalConfig.MobileService.GetTable<Mission>().InsertAsync(mission);

            EventName.Text = "";
            EventAddress.Text = "";
            EventCity.Text = "";
            EventState.Text = "";
            EventZipCode.Text = "";
            EventLatitude.Text = "";
            EventLongitude.Text = "";

            await Navigation.PushAsync(new EventsPage());
        }
    }
}