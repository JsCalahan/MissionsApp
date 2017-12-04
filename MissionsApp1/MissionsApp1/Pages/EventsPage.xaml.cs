using MissionsApp1.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissionsApp1.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MissionsApp1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventsPage : ContentPage
    {
        public ObservableCollection<Mission> Missions; // { get; set; }
        private List<Mission> allMissions;
        protected async override void OnAppearing()
        {
      
            base.OnAppearing();

            DateTime yesterday = DateTime.Now.AddDays(-1);
            List<Mission> missionDatabase = await GlobalConfig.MobileService.GetTable<Mission>().Where(rec => rec.Date >= yesterday).ToListAsync();
            this.Missions = new ObservableCollection<Mission>(missionDatabase);
            allMissions = missionDatabase;

            this.EventsListView.ItemsSource = this.Missions;
        }
        public EventsPage()
        {
            InitializeComponent();

            NavigationPage.SetHasBackButton(this, false);
        }

        private void EventsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }

            //grabs selected item in listview
            Mission selectedMission = e.SelectedItem as Mission;

            //deselect
            (sender as ListView).SelectedItem = null;

            //sends mission to detailed page
            Navigation.PushAsync(new EventInfo(selectedMission));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(String.IsNullOrEmpty(e.NewTextValue))
            {
                this.Missions = new ObservableCollection<Mission>(this.allMissions);
            }
            else
            {
                this.Missions = new ObservableCollection<Mission>(this.Missions.Where(rec => rec.Name.ToLower().Contains(e.NewTextValue.ToLower())));
            }
            this.EventsListView.ItemsSource = this.Missions;
        }
    }

}