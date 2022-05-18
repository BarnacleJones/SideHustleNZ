using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SideHustleNZ
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LookAtJobs : Page
    {
        Dictionary<string, Jobs> JobsDictionary = new Dictionary<string, Jobs>()
        {
            {"Gardening", new Jobs() { Name="Gardening - One Off", Description="One off gardening work. Involves weeding, laying paving stones and enjoying the sun."}},
            {"Plumbing", new Jobs() { Name="Plumbing - One Off", Description="One off plumbing work. Involves replacing a pipe and getting my taps to run again"}},
            {"Building", new Jobs() { Name="Building - Ongoing work (6 Month)", Description="6 month term building work. Involves building an outdoor pergola and enclosure for my cats"}},
            {"Landscaping", new Jobs() { Name="One week - Landscaping Work", Description="One week landscaping work. Involves putting large rocks and a retaining wall in my enclosure for my cats"}},
            {"Electrical Work", new Jobs() { Name="Electrical - One Off", Description="One off electrical work. Involves wiring up my new shed and hooking up my lizard Tom's heat rock to my solar panels"}},
            {"Concrete Laying", new Jobs() { Name="Concrete Laying - One Off", Description="One off concrete laying work. Involves laying a no-slip footpath to my cat enclosure"}}
        };

        public LookAtJobs()
        {
            this.InitializeComponent();

            JobsListBox.ItemsSource = JobsDictionary.Keys;


            // setup the device sizing for the application
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(App.DeviceMinimumScreenWidth, App.DeviceMinimumScreenHeight));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        /*private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }*/

        /*private void Button_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            //Navigate to home
            this.Frame.Navigate(typeof(EmployeeHome));
        }*/

        private async void GoToApplyJob_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Create the message dialog and set its content
            var messageDialog = new Windows.UI.Popups.MessageDialog("This is where you will apply to job (few details, push submit).");


            // Show the message dialog
            await messageDialog.ShowAsync();
        }

        private async void GoToAcceptJob_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Create the message dialog and set its content
            var messageDialog = new Windows.UI.Popups.MessageDialog("This is where you will accept your job (few details, push submit).");


            // Show the message dialog
            await messageDialog.ShowAsync();

        }

        private void Button_Tapped_3(object sender, TappedRoutedEventArgs e)
        {

            //Navigate to home
            this.Frame.Navigate(typeof(EmployeeHome));
        }
        //can I delete these two below without breaking? (program lagged and these were all added)
        /*private void Button_Tapped_2(object sender, TappedRoutedEventArgs e)
        {

        }

        private void Button_Tapped_3(object sender, TappedRoutedEventArgs e)
        {

        }*/

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Lock the device sizing for the application
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Navigate to home
            this.Frame.Navigate(typeof(MainPage));
        }

        private void JobsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string itemSelected = JobsListBox.SelectedItem.ToString();

            if (JobsDictionary.ContainsKey(itemSelected) == false)
            {
                TextBlockName.Text = TextBlockName.Text + "\nkey " + itemSelected + " not found";
            }
            else
            {
                Jobs theJob = JobsDictionary[itemSelected];

                TextBlockName.Text = theJob.Name.ToString();

                TextBlockDescription.Text = theJob.Description.ToString();

            }

        }
    }
}
