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
    public sealed partial class UCItemDictionary : UserControl
    {
        private MainViewModel vm;
        Panel left;
        Panel middel;
        public UCItemDictionary(Panel left, Panel middel, MainViewModel vm)
        {
            this.InitializeComponent();
            this.vm = vm;
            //vm.laadItemDictionary();
            this.left = left;
            this.middel = middel;
        }
    
        private void AddItem(object sender, RoutedEventArgs e)
        {
            var myControl = new PackingList.UserControls.UCAddDictionaryItem(vm, left, middel);
            middel.Children.Clear();
            middel.Children.Add(myControl);
        }
    }
}
