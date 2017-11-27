using MissionsApp1.Classes;
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

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            //making a new list to hold missions user is participating in
            List<Mission> myEvents = new List<Mission>();
            if (GlobalConfig.isOrganization == false)
            {
                //linking user event table
                List<UserEvent> userEvents = await GlobalConfig.MobileService.GetTable<UserEvent>().Where(rec => rec.UserID == GlobalConfig.currentUser.ID).ToListAsync();
                //
                foreach (UserEvent link in userEvents)
                {
                    List<Mission> events = await GlobalConfig.MobileService.GetTable<Mission>().Where(rec => rec.ID == link.EventID).ToListAsync();
                    myEvents.Add(events.First());
                }
                UserEventListView.ItemsSource = myEvents;
            }
            else
            {
                List<Mission> orgMissions = await GlobalConfig.MobileService.GetTable<Mission>().Where(rec => rec.OrganizationName == GlobalConfig.currentUser.FirstName).ToListAsync();
                UserEventListView.ItemsSource = orgMissions;
            }
        }

        public ObservableCollection<string> Missions; 

        public MyAccountPage ()
		{
            InitializeComponent();

            ProfileNameLabel.Text = GlobalConfig.currentUser.FirstName;
        }
        private void EventsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
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