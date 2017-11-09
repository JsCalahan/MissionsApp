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
    public partial class CreateUserPage : ContentPage
    {
        public CreateUserPage()
        {
            InitializeComponent();
        }

        private async void CreateUserAccount_Clicked(object sender, EventArgs e)
        {
            User user = new User();

            user.Username = UsernameEntry.Text;
            user.FirstName = FirstNameEntry.Text;
            user.LastName = LastNameEntry.Text;
            user.Password = PasswordEntry.Text;
            user.EmailAddress = EmailEntry.Text;
            GlobalConfig.isOrganization = false;

            await GlobalConfig.MobileService.GetTable<User>().InsertAsync(user);

            UsernameEntry.Text = "";
            FirstNameEntry.Text = "";
            LastNameEntry.Text = "";
            PasswordEntry.Text = "";
            EmailEntry.Text = "";

            await Navigation.PushAsync(new HomePage());
        }


    }
}