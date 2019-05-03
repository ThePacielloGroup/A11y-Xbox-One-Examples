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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Paciello_Group_A11y_Xbox_One_Examples
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Handling Page Back navigation behaviors
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested +=
                SystemNavigationManager_BackRequested;
        }


        private void SystemNavigationManager_BackRequested(
    object sender,
    Windows.UI.Core.BackRequestedEventArgs e)
        {
            if (!e.Handled)
            {
                e.Handled = this.BackRequested();
            }
        }

        public Frame AppFrame { get { return this.Frame; } }

        private bool BackRequested()
        {
            // Get a hold of the current frame so that we can inspect the app back stack
            if (this.AppFrame == null)
                return false;

            // Check to see if this is the top-most page on the app back stack
            if (this.AppFrame.CanGoBack)
            {
                // If not, set the event to handled and go back to the previous page in the
                // app.
                this.AppFrame.GoBack();
                return true;
            }
            return false;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Exitbutton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }

        private void Hellobutton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }
    }
}
