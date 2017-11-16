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

        public ObservableCollection<string> Missions; 

        public MyAccountPage (User user)
		{
            InitializeComponent();

            //ProfileNameLabel.Text = user.FirstName + " " + user.LastName;
        }
    }
}