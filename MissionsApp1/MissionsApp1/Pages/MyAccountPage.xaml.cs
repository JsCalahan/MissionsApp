using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MissionsApp1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyAccountPage : ContentPage
    {
        public ObservableCollection<string> Missions { get; set; }
        public MyAccountPage()
        {
            InitializeComponent();

            this.Missions = new ObservableCollection<string>();
        }

        private void AddMissionButton_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NewMissionEntry.Text))
            {
                DisplayAlert("Error", "Entry is empty.", "Ok");
            }
            else
            {
                this.Missions.Add(NewMissionEntry.Text);
                UserEventListView.ItemsSource = this.Missions;
                NewMissionEntry.Text = "";
            }
        }
    }
}