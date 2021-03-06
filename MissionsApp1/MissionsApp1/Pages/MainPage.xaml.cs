﻿using MissionsApp1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MissionsApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new LoginPage());
        }
        private void CreateUserButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateUserPage());
        }

        private void CreateOrganizationButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateOrganizationPage());
        }
    }
}
