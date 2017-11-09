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
            Organization organization = new Organization();

            organization.Username = UsernameEntry.Text;
            organization.Password = OrganizationPassword.Text;
            organization.Name = OrganizationName.Text;
            organization.Address = AddressEntry.Text;
            organization.City = CityEntry.Text;
            organization.State = StateEntry.Text;
            organization.ZipCode = ZipCodeEntry.Text;
            organization.EmailAddress = EmailEntry.Text;
            organization.PhoneNumber = ContactNumberEntry.Text;
            GlobalConfig.isOrganization = true;

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