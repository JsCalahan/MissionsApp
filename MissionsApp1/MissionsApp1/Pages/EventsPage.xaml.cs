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

        protected async override void OnAppearing()
        {
      
            base.OnAppearing();

            List<Mission> missionDatabase = await GlobalConfig.MobileService.GetTable<Mission>().Where(rec => true).ToListAsync();
            this.Missions = new ObservableCollection<Mission>(missionDatabase);

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
    }

}