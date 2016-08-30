using PackingList.Models;
using PackingList.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PackingList.UserControls
{
    public sealed partial class UCTrips : UserControl
    {
        private MainViewModel vm;
        private Panel left;
        private Panel mp;
        private Panel ap;
        public UCTrips(Panel left, Panel itemsPanel, Panel addPanel, MainViewModel vm)
        {
            this.InitializeComponent();
            //vm.laadReizen();
            this.vm = vm;
            this.left = left;
            this.mp = itemsPanel;
            this.ap = addPanel;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView lv = (ListView)sender;
            Trip geselecteerdeTrip = lv.SelectedItem as Trip;
            var myControl = new PackingList.UserControls.UCItems(geselecteerdeTrip, mp, ap, vm);
            var controlTasks = new PackingList.UserControls.UCTasks(geselecteerdeTrip, mp, ap, vm);
            mp.Children.Clear();
            ap.Children.Clear();
            mp.Children.Add(myControl);
            ap.Children.Add(controlTasks);
            //var frame = Window.Current.Content as Frame;
            //frame.Navigate(typeof(TripDetails), geselecteerdeTrip);
        }

        private void btnAddTrip_Click(object sender, RoutedEventArgs e)
        {
            var myControl = new PackingList.UserControls.UCTrip(left, mp, ap, vm);
            left.Children.Clear();
            left.Children.Add(myControl);
        }
    }
}
