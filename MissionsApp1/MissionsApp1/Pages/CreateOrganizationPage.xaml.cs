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
            User user = new User();
            Organization organization = new Organization();

            user.EmailAddress = EmailEntry.Text;
            user.Username = UserNameEntry.Text;
            user.Password = PasswordEntry.Text;
            user.FirstName = " ";
            user.LastName = " ";
            user.ID = Guid.NewGuid().ToString();

            organization.Name = OrganizationName.Text;
            organization.Address = AddressEntry.Text;
            organization.City = CityEntry.Text;
            organization.State = StateEntry.Text;
            organization.ZipCode = ZipCodeEntry.Text;
            organization.EmailAddress = EmailEntry.Text;
            organization.PhoneNumber = ContactNumberEntry.Text;
            organization.UserID = user.ID;
            GlobalConfig.isOrganization = true;
            GlobalConfig.currentOrganization = organization;


            await GlobalConfig.MobileService.GetTable<User>().InsertAsync(user);
            await GlobalConfig.MobileService.GetTable<Organization>().InsertAsync(organization);

            UsernameEntry.Text = "";
            OrganizationPassword.Text = "";
            OrganizationName.Text = "";
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