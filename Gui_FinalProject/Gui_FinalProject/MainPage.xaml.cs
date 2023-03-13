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

namespace Gui_FinalProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ThreeLittlePigs_ButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(KidBook)); 
        }

        private void DMV_ButtonClick(Object sender, RoutedEventArgs e) 
        {
            this.Frame.Navigate(typeof(AdultBook));
        }

        private async void ProjectInfoButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog aboutDialog = new ContentDialog()
            {
                Title = "Book E-Reader Project",
                Content = "Created In GUI, Winter Term, 2023.\nPress Ok To Close.",
                CloseButtonText = "Ok"
            };

            await aboutDialog.ShowAsync();
        }
    }
}
