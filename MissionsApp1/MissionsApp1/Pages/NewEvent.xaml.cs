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
    public partial class NewEvent : ContentPage
    {
        public NewEvent()
        {
            InitializeComponent();
        }

        private void CreateEvent_Clicked(object sender, EventArgs e)
        {
            Missions Mission = new Missions();

            Mission.Name = EventName.Text;
            Mission.Address = EventAddress.Text;
            Mission.City = EventCity.Text;
            Mission.State = EventState.Text;
            Mission.ZipCode = EventZipCode.Text;
            Mission.Latitude = EventLatitude.Text;
            Mission.Longitude = EventLongitude.Text;
            Mission.Date = EventDate.Text;
            Mission.StartTime = EventStartTime.Text;
            Mission.EndTime = EventEndTime.Text;

            Navigation.PushAsync(new EventCreated());
        }
    }
}