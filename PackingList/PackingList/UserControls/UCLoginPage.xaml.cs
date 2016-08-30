using PackingList.ViewModels;
using PackingList.Views;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(SignInPage));
        }
    }
}