using PackingList.Models;
using PackingList.UserControls;
using PackingList.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PackingList.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SignInPage : Page
    {
        MainViewModel mv;

        public SignInPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MainViewModel mv = (MainViewModel)e.Parameter;
            this.mv = mv;
            base.OnNavigatedTo(e);
        }

        private async void Submit_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("");

            if (!Regex.IsMatch(TxtUserName.Text.Trim(), @"^[A-Za-z_][a-zA-Z0-9_\s]*$"))
            {
                dialog = new MessageDialog("Invalid UserName");
                await dialog.ShowAsync();
            }
            else if (TxtPwd.Password.Length < 6)
            {
                dialog = new MessageDialog("Password length should be minimum of 6 characters!");
                await dialog.ShowAsync();
            }
            else if (!Regex.IsMatch(TxtEmail.Text.Trim(), @"^([a-zA-Z_])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$"))
            {
                dialog = new MessageDialog("Invalid Email address");
                await dialog.ShowAsync();
            }

            else if(TxtUserName.Text != "" && TxtPwd.Password != "" && TxtEmail.Text != "")
            {
                User newUser = new User();
                newUser.Name = TxtUserName.Text;
                newUser.Password = TxtPwd.Password;
                newUser.EmailAddress = TxtEmail.Text;
                newUser.ItemDictionary = new List<Item>();
                newUser.Trips = new List<Trip>();
                mv.register(newUser);
                //Frame.Navigate(typeof(UCLoginPage), newUser);
                
            }
            else
            {
                dialog = new MessageDialog("Please enter all details");
                await dialog.ShowAsync();
            }
            
        }
    }
}
