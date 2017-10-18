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
    public partial class EventCreated : ContentPage
    {
        public EventCreated()
        {
            InitializeComponent();
        }

        private void BackToHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}