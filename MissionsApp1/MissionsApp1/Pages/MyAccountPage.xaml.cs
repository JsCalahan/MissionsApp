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
            //linking user event table
            List<UserEvent> userEvents = await GlobalConfig.MobileService.GetTable<UserEvent>().Where(rec => rec.UserID == GlobalConfig.currentUser.ID).ToListAsync();
            //
            foreach(UserEvent link in userEvents)
            {
                List<Mission> events = await GlobalConfig.MobileService.GetTable<Mission>().Where(rec => rec.ID == link.EventID).ToListAsync();
                myEvents.Add(events.First());
            }
            UserEventListView.ItemsSource = myEvents;
        }

        public ObservableCollection<string> Missions; 

        public MyAccountPage ()
		{
            InitializeComponent();

            //ProfileNameLabel.Text = user.FirstName + " " + user.LastName;
        }
    }
}