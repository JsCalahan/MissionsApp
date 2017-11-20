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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            List<User> users = await GlobalConfig.MobileService.GetTable<User>().Where(rec=>rec.Username==Username.Text&&rec.Password==Password.Text).ToListAsync();
            if(users.Count==1)
            {
                GlobalConfig.currentUser = users.First();
                List<Organization> organizations = await GlobalConfig.MobileService.GetTable<Organization>().Where(rec => rec.UserID == GlobalConfig.currentUser.ID).ToListAsync();
                if (organizations.Count == 1)
                { GlobalConfig.isOrganization = true; }
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("Error", "Invalid Credentials", "Ok");
            }

            
        }
    }
}