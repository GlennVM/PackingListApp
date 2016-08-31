using PackingList.Models;
using PackingList.UserControls;
using PackingList.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Tweetinvi;
using Tweetinvi.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PackingList
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MainViewModel vm = new MainViewModel();
        Models.User user = new Models.User();
        public static object Auth { get; private set; }

        public MainPage()
        {
            this.InitializeComponent();
            InitTwitterCred();
          //  ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(1024, 768));
            ApplicationView.PreferredLaunchViewSize = new Size(1024, 768);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

            if (!IsLoggedIn())
            {
                var control = new UCLoginPage(tripsPanel, itemsPanel, addPanel, MySplitViewContent, vm);
                MySplitViewContent.Children.Add(control);
            }
            //vm.laadReizen();
        }

        private bool IsLoggedIn()
        {
            //if (user.Name == null)
            //{
            //    return false;
            //}
            //return true;
            return false;
        }

        /**protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Models.User user = (Models.User)e.Parameter;
            base.OnNavigatedTo(e);
        }*/

        private static void InitTwitterCred()
        {
            var creds = new TwitterCredentials("229575700-IhBnxVXAaGjf4EVq5vViattUE6tDlskcIZK6AIz8", "P5OvcBkUgOmLkjbWo35hPi52OiDbDPea8IITn8eQgnXzb", "Azhicej5KqMapjsDgoEZybvrE", "gY8ItkQMZD1y0uu9lhdmcz6olaaAULn5MMexQwlwgMOTzMQ2D5");
            Tweetinvi.Auth.SetUserCredentials("Azhicej5KqMapjsDgoEZybvrE", "gY8ItkQMZD1y0uu9lhdmcz6olaaAULn5MMexQwlwgMOTzMQ2D5", "229575700-IhBnxVXAaGjf4EVq5vViattUE6tDlskcIZK6AIz8", "P5OvcBkUgOmLkjbWo35hPi52OiDbDPea8IITn8eQgnXzb");
            Tweetinvi.Auth.ApplicationCredentials = creds;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Loadingtrips(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            tripsPanel.Children.Clear();
            itemsPanel.Children.Clear();
            addPanel.Children.Clear();
            //vm.laadReizen();
            var myControl = new PackingList.UserControls.UCTrips(tripsPanel, itemsPanel, addPanel, vm);
            tripsPanel.Children.Add(myControl);
        }

        private void loadingitems(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            tripsPanel.Children.Clear();
            itemsPanel.Children.Clear();
            addPanel.Children.Clear();
            //vm.laadItemDictionary();
            var myControl = new PackingList.UserControls.UCItemDictionary(tripsPanel, itemsPanel, vm);
            tripsPanel.Children.Add(myControl);
        }
    }
}
