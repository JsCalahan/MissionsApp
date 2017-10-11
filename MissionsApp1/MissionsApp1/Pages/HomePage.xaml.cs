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

        private void AccountPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AccountPage());
        }

        private void OrganizationSearch_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrganizationSearchPage());
        }
    }
}