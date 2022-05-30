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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.Media.SpeechSynthesis;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SideHustleNZ
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewApplications : Page
    {
        //Talk function to read text of element that is double tapped
        private async void Talk(string message)
        {
            try
            {
                // Configure the audio output.
                var reader = new SpeechSynthesizer();
                // Get the text
                var stream = await reader.SynthesizeTextToStreamAsync(message);
                // Setup the stream for the player
                media.SetSource(stream, stream.ContentType);
                // Play the message
                media.Play();
            }
            catch (System.IO.FileNotFoundException)
            {
                // Voice Package not installed
                var messageDialog = new Windows.UI.Popups.MessageDialog("Media player components unavailable.\nYou need to Install a Voice Package in your Windows Settings.\n\nSettings > Time & Language > Speech > Manage Voices > Add Voices");
                await messageDialog.ShowAsync();
            }
            catch (Exception)
            {
                // If the text is unable to be synthesized, throw an error message to the user.
                media.AutoPlay = false;
                var messageDialog = new Windows.UI.Popups.MessageDialog("Unable to synthesize text");
                await messageDialog.ShowAsync();
            }
        }

        //Applicant dictionary
        Dictionary<string, Applicants> applicantDictionary = new Dictionary<string, Applicants>()
        {
            {"John Doe", new Applicants() { Name="John Doe", Skills="Certified Electrician\nCertified Instrumentation\nI have many years electrical experience and can do any household electrical work", Image="profilephoto.png"}},
            {"Jane Doe", new Applicants() { Name="Jane Doe", Skills="Certified Landscaper\nClass 2 DL, Wheels Tracks Rollers endorsements\nI have many years landscaping experience and am free to help with your job listed.", Image="jane.png"}},
            {"Janet Doe", new Applicants() { Name="Janet Doe", Skills="Hobby Gardener\nCertified Badass\nI have many years of gardening and cat work, I can do your job, today!", Image="janet.jpg"}}
            };
        public ViewApplications()
        {
            this.InitializeComponent();
            //populate listbox with dictionary items
            applicantListBox.ItemsSource = applicantDictionary.Keys;
            // setup the device sizing for the application
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(App.DeviceMinimumScreenWidth, App.DeviceMinimumScreenHeight));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Navigate to home
            this.Frame.Navigate(typeof(EmployerHome));
        }

        private void Button_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            //Navigate to applicant page
            this.Frame.Navigate(typeof(ApplicantPage));
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

        

        private void applicantListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string itemSelected = applicantListBox.SelectedItem.ToString();

            if (applicantDictionary.ContainsKey(itemSelected) == false)
            {
                TextBlockName.Text = TextBlockName.Text + "\nkey " + itemSelected + " not found";
            }
            else
            {
                Applicants theApplicant = applicantDictionary[itemSelected];

                TextBlockName.Text = theApplicant.Name.ToString();

                TextBlockDescription.Text = theApplicant.Skills.ToString();

                ImagePerson.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + theApplicant.Image.ToString(), UriKind.RelativeOrAbsolute));

            }

        }

        private void applicantListBox_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Talk(applicantListBox.SelectedItem.ToString());
        }

        private void TextBlockName_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Talk(TextBlockName.Text);
        }

        private void TextBlockDescription_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Talk(TextBlockDescription.Text);
        }
    }
}
