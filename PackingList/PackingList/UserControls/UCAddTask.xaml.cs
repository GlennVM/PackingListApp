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
    public sealed partial class UCAddTask : UserControl
    {
        MainViewModel vm;
        Panel middel;
        Panel right;
        Trip selectedTrip;
        public UCAddTask(MainViewModel vm, Panel middel, Panel right, Trip selectedTrip)
        {
            this.InitializeComponent();
            this.vm = vm;
            this.middel = middel;
            this.right = right;
            this.selectedTrip = selectedTrip;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task() { Name = txtTask.Text.ToString(), Checked = false };
            selectedTrip.tasks.Add(task);
            var myControl = new PackingList.UserControls.UCTasks(selectedTrip, middel, right, vm);
            right.Children.Clear();
            right.Children.Add(myControl);
            vm.saveChanges();
        }
    }
}
