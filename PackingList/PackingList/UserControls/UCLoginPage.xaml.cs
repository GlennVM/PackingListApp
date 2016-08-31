using PackingList.Services;
using PackingList.ViewModels;
using PackingList.Views;
using System;
using Windows.UI.Popups;
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

        DummyService service = new DummyService();

        public UCLoginPage(Panel left, Panel itemsPanel, Panel addPanel, MainViewModel vm)
        {
            this.InitializeComponent();
            this.vm = vm;
            this.left = left;
            this.mp = itemsPanel;
            this.ap = addPanel;
        }

        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            if (UserName.Text != "" && PassWord.Password != "")
            {
                int temp = 0;

                foreach (var userLogin in service.retrieveUsers())
                {
                    if (UserName.Text == userLogin.Name && PassWord.Password == userLogin.Password)
                    {
                        temp = 1;

                        var rootFrame = Window.Current.Content as Frame;
                        rootFrame.Navigate(typeof(MainPage),userLogin);
                        var dialog = new MessageDialog("logged in");
                        await dialog.ShowAsync();
                    }
                    else
                    {
                        var dialog = new MessageDialog("Invalid userName / password");
                        await dialog.ShowAsync();

                        UserName.Text = string.Empty;
                        PassWord.Password = string.Empty;
                    }
                }
            }
            else
            {
                var dialog = new MessageDialog("Enter userName and password");
                await dialog.ShowAsync();
            }
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(SignInPage), vm);
        }
    }
}