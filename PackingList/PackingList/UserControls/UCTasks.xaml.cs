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
    public sealed partial class UCTasks : UserControl
    {
        private Panel middel;
        private Panel right;
        MainViewModel vm;
        private Trip selectedTrip;
        public UCTasks(Trip selectedTrip, Panel middel, Panel right, MainViewModel vm)
        {
            this.InitializeComponent();
            this.DataContext = selectedTrip;
            this.vm = vm;
            this.middel = middel;
            this.right = right;
            this.selectedTrip = selectedTrip;
            //base.OnNavigatedTo(e);
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            var myControl = new PackingList.UserControls.UCAddTask(vm, middel, right, selectedTrip);
            right.Children.Clear();
            right.Children.Add(myControl);
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            Task updated = box.DataContext as Task;

            if (updated.Checked == false)
            {
                updated.Checked = true;
            }
            else
            {
                updated.Checked = false;
            }
        }
    }
}
