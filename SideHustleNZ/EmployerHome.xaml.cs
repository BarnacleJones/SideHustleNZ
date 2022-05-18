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
    public sealed partial class EmployerHome : Page
    {
        public EmployerHome()
        {
            this.InitializeComponent();


            // setup the device sizing for the application
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(App.DeviceMinimumScreenWidth, App.DeviceMinimumScreenHeight));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        //private void HomeButton_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    Navigate to home
        //    this.Frame.Navigate(typeof(MainPage));
        //}

        //private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    Navigate to home
        //    this.Frame.Navigate(typeof(EmployerSettings));
        //}

        private void Button_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            //Navigate to job list page
            this.Frame.Navigate(typeof(ListJob));


           
        }

        private void Button_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            //Navigate to view applications
            this.Frame.Navigate(typeof(ViewApplications));
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

        private void Image_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            //Navigate to home
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            //Navigate to settings
            this.Frame.Navigate(typeof(EmployerSettings));
        }
    }
}
