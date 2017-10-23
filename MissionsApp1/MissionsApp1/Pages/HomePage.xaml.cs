using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MissionsApp1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
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
    }
}