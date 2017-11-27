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
    public partial class EventInfo : ContentPage
    {
        public Mission MissionOnPage;
        public EventInfo(Mission mission)
        {
            InitializeComponent();

            if (GlobalConfig.isOrganization == true)
            {
                ParticipateButton.IsVisible = false;
            }

            EventNameLabel.Text = mission.Name;
            OrganizationNameLabel.Text = "Organization: " + mission.OrganizationName;
            EventDateLabel.Text = "Date: " + mission.Date;
            EventTime.Text = "Time: " + mission.StartTime + " - " + mission.EndTime;


            Address.Text = "Location: " + mission.Address + ", " + mission.City + " " + mission.State + ", " + mission.ZipCode;

            MissionOnPage = mission;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            UserEvent userEvent = new UserEvent();
            userEvent.EventID = MissionOnPage.ID;
            userEvent.UserID = GlobalConfig.currentUser.ID;
            await GlobalConfig.MobileService.GetTable<UserEvent>().InsertAsync(userEvent);
            Navigation.PushAsync(new MyAccountPage());
        }
    }
}