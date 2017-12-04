using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MissionsApp1.Classes;

namespace MissionsApp1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            NavigationPage.SetHasBackButton(this, false);

            if (GlobalConfig.isOrganization == false)
            {
                NewEventImage.IsVisible = false;
                NewEventText.IsVisible = false;
            }

        }

        private void AccountPage_Tapped(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new MyAccountPage());
        }

        private void OrganizationSearch_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrganizationSearchPage());
        }

        private void Event_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventsPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewEvent());
        }

        private void LogoutButton_Clicked(object sender, EventArgs e)
        {
            GlobalConfig.currentUser = null;
            GlobalConfig.isOrganization = false;
            Navigation.PushAsync(new MainPage());
        }
    }
}