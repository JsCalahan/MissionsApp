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

        private void CreateOrganizationAccount_Clicked(object sender, EventArgs e)
        {
            GlobalConfig.isOrganization = true;
            Navigation.PushAsync(new HomePage());
        }
    }
}