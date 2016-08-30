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
    public sealed partial class UCAddItem : UserControl
    {
        MainViewModel vm;
        Panel middel;
        Panel right;
        Trip selectedTrip;
        public UCAddItem(MainViewModel vm, Panel middel, Panel right, Trip selectedTrip)
        {
            this.InitializeComponent();
            this.vm = vm;
            //vm.laadItemDictionary();
            this.selectedTrip = selectedTrip;
            this.middel = middel;
            this.right = right;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Item selectedItem = (Item)cmbItem.SelectedItem;
            selectedItem.Amount = int.Parse(txtAmount.Text.ToString());
            selectedTrip.Add(selectedItem);
            middel.Children.Clear();
            var myControl = new PackingList.UserControls.UCItems(selectedTrip, middel, right, vm);
            middel.Children.Add(myControl);
            vm.saveChanges();
        }
    }
}
