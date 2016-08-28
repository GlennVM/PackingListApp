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
    public sealed partial class UCAddDictionaryItem : UserControl
    {
        MainViewModel vm;
        Panel left;
        Panel middel;
        public UCAddDictionaryItem(MainViewModel vm, Panel left, Panel middel)
        {
            this.InitializeComponent();
            this.vm = vm;
            this.left = left;
            this.middel = middel;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            String item = txtItem.Text.ToString();
            String cat = (cmbCategory.SelectedItem as ComboBoxItem).Content.ToString();
            Item comp = new Item() { Name = item, Category = cat };
            vm.addItemToDictionary(comp);
            middel.Children.Clear();

            var myControl = new PackingList.UserControls.UCItemDictionary(left, middel, vm);
            left.Children.Clear();
            left.Children.Add(myControl);
        }
    }
}
