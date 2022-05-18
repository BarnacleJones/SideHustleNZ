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
// Setup the device sizing for the application
using Windows.UI.ViewManagement;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SideHustleNZ
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // setup the device sizing for the application
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(App.DeviceMinimumScreenWidth, App.DeviceMinimumScreenHeight));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        private void GoToEmployerHome_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Navigate to employer home
            this.Frame.Navigate(typeof(EmployerHome));
        }

        private void GoToEmployeeHome_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Navigate to employee home
            this.Frame.Navigate(typeof(EmployeeHome));
        }

        private void GuestButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Navigate to home
            this.Frame.Navigate(typeof(GuestPage));
        }

        private void GuestButton_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            //Navigate to home
            this.Frame.Navigate(typeof(GuestPage));
        }

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
    }
}
