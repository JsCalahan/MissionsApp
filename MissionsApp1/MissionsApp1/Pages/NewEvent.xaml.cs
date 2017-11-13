﻿using System;
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
            Mission mission = new Mission();

            mission.Name = EventName.Text;
            //mission.OrganizationName = Organ
            mission.Address = EventAddress.Text;
            mission.City = EventCity.Text;
            mission.State = EventState.Text;
            mission.ZipCode = EventZipCode.Text;
            mission.Latitude = Convert.ToDouble(EventLatitude.Text);
            mission.Longitude = Convert.ToDouble(EventLongitude.Text);
            mission.Date = EventDate.Text;
            mission.StartTime = EventStartTime.Text;
            mission.EndTime = EventEndTime.Text;

            await GlobalConfig.MobileService.GetTable<Mission>().InsertAsync(mission);

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

            await Navigation.PushAsync(new EventsPage());
        }
    }
}