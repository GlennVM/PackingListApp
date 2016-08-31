using PackingList.Models;
using PackingList.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Tweetinvi;
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
    public sealed partial class UCItems : UserControl
    {
        private Panel middel;
        private Panel right;
        MainViewModel vm;
        private Trip selectedTrip;
        public UCItems(Trip selectedTrip, Panel middel, Panel right, MainViewModel vm)
        {
            this.InitializeComponent();
            this.DataContext = selectedTrip;
            this.vm = vm;
            this.middel = middel;
            this.right = right;
            this.selectedTrip = selectedTrip;

            int counter = 0;

            for(int i = 0; i < selectedTrip.items.Count; i++)
            {
                if (selectedTrip.items[i].Checked == true)
                {
                    counter++;
                }
            }

            txtProgress.Text = counter + "/" + selectedTrip.items.Count + " Done!";

            progressbar.Value = (counter / selectedTrip.items.Count);
            //base.OnNavigatedTo(e);
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            var myControl = new PackingList.UserControls.UCAddItem(vm, middel, right, selectedTrip);
            middel.Children.Clear();
            middel.Children.Add(myControl);
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            Item updated = box.DataContext as Item;
            
            if(updated.Checked == false)
            {
                updated.Checked = true;
            } else
            {
                updated.Checked = false;
            }
            vm.saveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button but = (Button)sender;
            string prod = but.Tag.ToString();

            Tweet.PublishTweet("Kan iemand me " + prod + " lenen? #dtv");
        }
    }
}
