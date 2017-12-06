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
    public partial class CreateOrganizationPage : ContentPage
    {
        public CreateOrganizationPage()
        {
            InitializeComponent();
        }

        private async void CreateOrganizationAccount_Clicked(object sender, EventArgs e)
        {
            CreateOrganizationAccount.IsVisible = false;
            Loader.IsVisible = true;

            User user = new User();
            Organization organization = new Organization();

            user.Username = UsernameEntry.Text;
            user.Password = PasswordEntry.Text;
            user.EmailAddress = EmailEntry.Text;
            user.FirstName = OrganizationNameEntry.Text;
            user.LastName = " ";
            user.ID = Guid.NewGuid().ToString();

            organization.Name = OrganizationNameEntry.Text;
            organization.Address = AddressEntry.Text;
            organization.City = CityEntry.Text;
            organization.State = StateEntry.Text;
            organization.ZipCode = ZipCodeEntry.Text;
            organization.EmailAddress = EmailEntry.Text;
            organization.PhoneNumber = ContactNumberEntry.Text;
            organization.UserID = user.ID;
            


            await GlobalConfig.MobileService.GetTable<User>().InsertAsync(user);
            await GlobalConfig.MobileService.GetTable<Organization>().InsertAsync(organization);
            GlobalConfig.currentUser = user;
            Settings.UserData = user;
            Settings.isOrganization = true;
            GlobalConfig.isOrganization = true;

            UsernameEntry.Text = "";
            AddressEntry.Text = "";
            CityEntry.Text = "";
            StateEntry.Text = "";
            ZipCodeEntry.Text = "";
            EmailEntry.Text = "";
            ContactNumberEntry.Text = "";

            await Navigation.PushAsync(new HomePage());
        }
    }
}