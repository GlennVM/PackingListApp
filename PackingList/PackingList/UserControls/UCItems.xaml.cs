﻿using PackingList.Models;
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
    public sealed partial class UCItems : UserControl
    {
        private Panel addPanel;
        public UCItems(Trip selectedTrip, Panel addPanel)
        {
            this.InitializeComponent();
            this.DataContext = selectedTrip;
            this.addPanel = addPanel;
            //base.OnNavigatedTo(e);
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            var myControl = new PackingList.UserControls.UCAddItem();
            addPanel.Children.Clear();
            addPanel.Children.Add(myControl);
        }
    }
}
