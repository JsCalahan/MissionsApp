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

        private async void CreateEvent_Clicked(object sender, EventArgs e)
        {
            Mission Mission = new Mission();

            Mission.Name = EventName.Text;
            Mission.Address = EventAddress.Text;
            Mission.City = EventCity.Text;
            Mission.State = EventState.Text;
            Mission.ZipCode = EventZipCode.Text;
            Mission.Latitude = Convert.ToDouble(EventLatitude.Text);
            Mission.Longitude = Convert.ToDouble(EventLongitude.Text);
            Mission.Date = EventDate.Text;
            Mission.StartTime = EventStartTime.Text;
            Mission.EndTime = EventEndTime.Text;

            await GlobalConfig.MobileService.GetTable<Mission>().InsertAsync(Mission);

            EventName.Text = "";
            EventAddress.Text = "";
            EventCity.Text = "";
            EventState.Text = "";
            EventZipCode.Text = "";
            EventLatitude.Text = "";
            EventLongitude.Text = "";
            EventDate.Text = "";
            EventStartTime.Text = "";
            EventEndTime.Text = "";

            await Navigation.PushAsync(new EventCreated());
        }
    }
}