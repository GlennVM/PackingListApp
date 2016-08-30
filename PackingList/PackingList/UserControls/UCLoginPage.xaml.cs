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
    public sealed partial class UCLoginPage : UserControl
    {
        private MainViewModel vm;
        private Panel left;
        private Panel mp;
        private Panel ap;
        public UCLoginPage(Panel left, Panel itemsPanel, Panel addPanel, MainViewModel vm)
        {
            this.InitializeComponent();
            this.vm = vm;
            this.left = left;
            this.mp = itemsPanel;
            this.ap = addPanel;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}