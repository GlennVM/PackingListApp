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
    public sealed partial class UCTrip : UserControl
    {
        Panel left;
        Panel middel;
        Panel right;
        MainViewModel vm;
        public UCTrip(Panel left, Panel middel, Panel right, MainViewModel vm)
        {
            this.InitializeComponent();
            this.vm = vm;
            this.left = left;
            this.middel = middel;
            this.right = right;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Trip trip = new Trip() { Title = txtTrip.Text.ToString(), items = new List<Item>(), tasks = new List<Task>() };
            vm.addTrip(trip);
            vm.saveChanges();
            left.Children.Clear();
            var myControl = new PackingList.UserControls.UCTrips(left, middel, right, vm);
            left.Children.Add(myControl);
        }
    }
}
