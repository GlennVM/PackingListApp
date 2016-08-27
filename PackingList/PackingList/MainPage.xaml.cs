﻿using PackingList.Models;
using PackingList.UserControls;
using PackingList.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(400, 650));
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
            var myControl = new PackingList.UserControls.UCTrips(itemsPanel, addPanel, vm);
            tripsPanel.Children.Add(myControl);
        }

        private void loadingitems(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            tripsPanel.Children.Clear();
            itemsPanel.Children.Clear();
            addPanel.Children.Clear();
            var myControl = new PackingList.UserControls.UCItemDictionary(itemsPanel, vm);
            tripsPanel.Children.Add(myControl);
        }
    }
}
