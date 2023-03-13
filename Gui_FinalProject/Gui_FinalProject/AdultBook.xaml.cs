using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Gui_FinalProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdultBook : Page
    {
        private readonly string[] pagedata =
        {
            "Everything you need to know to pass your tests is located in this section. It is important that you study the material for each topic. Sample questions are provided to help you test your knowledge.",
            "Signs and Traffic Signals. You must obey all official signs, signals, and markings unless you see a police officer or road worker redirecting traffic. Signs. Signs often use symbols or pictures rather than words. Each type of sign has a special color and shape to help you easily recognize the sign at a glance. Regulatory Signs—Prohibitive. Traffic signs that prohibit certain actions or movements are red in color and increase safety by controlling the flow of traffic through intersections. Stop—Octagon: This sign means you must come to a complete stop. Yield to other vehicles and stop and stay stopped for pedestrians crossing in marked or unmarked crosswalks. When it is safe, you may enter the intersection. Yield—Triangle: This sign means you should reduce speed and yield right of way. If needed, stop the same as you would for a stop sign.",
            "Do Not Enter—Square: This sign warns you not to enter a road or freeway. You will see this sign if you are going the wrong way. The signs below prohibit certain actions. When you see a sign with a red circle and a slash mark, it means do not make the turn shown. No Left Turn. No Right Turn. No U Turn.",
            "Regulatory Signs—Other. Regulatory signs are rectangular with black words or symbols on a white background and tell you what to do. They are posted at or near where the requirement applies. Not all regulatory signs are shown here. Speed Limit. This indicates the maximum speed in miles per hour. Signs may be electronic and may change based on current conditions. One Way. Traffic flows only in the direction of the arrow. Right Turn Permitted Without Stopping. This sign may appear below a stop sign. Traffic turning right may turn without stopping. Other traffic must stop and yield right of way.",
            "Lane-Use Control These signs are used where turns are required or permitted from lanes as shown. Keep Right A traffic island, median or obstruction divides the road ahead. Keep to the right. Center Lane Turn Only Share the center lane for left turns from both directions. Do Not Pass This sign indicates that you may not pass. No Turn on Red You may not turn during the red light. You must wait for the signal to turn green.",
            "Signs and Traffic Signals. High Occupancy Vehicle The lane is reserved for vehicles carrying at least two or more persons as noted on the sign. A white diamond may be painted on the lane. Warning Signs Warning signs are yellow and alert you to known possible hazards or a change in road conditions ahead. As a driver, you are ultimately responsible for recognizing and reacting correctly to changing conditions, signed or not. Not all warning signs are shown here. Pedestrian Crossing Be alert for people crossing your path. These signs may include a flashing yellow beacon that indicates a pedestrian is crossing, has recently crossed or is about to cross. Multiuse Path Crossing Bicyclists and pedestrians regularly cross the road in the area.",
            "Curve There is a curve ahead. Sharp Turn There is a sharp turn in the road ahead. Chevron A sharp curve or change in the direction of the road is at the sign. Winding Road The road contains a series of turns or curves.",
            "Reversing Curves The road ahead curves to the right, then left. Crossroad A four-way intersection is ahead. Cross traffic may enter the road. Side Road A “T” intersection is ahead. Traffic may enter the road from the left or right. Merge Traffic is merging from the side shown. Lane Reduction The indicated lane ends soon. Vehicles in that lane must merge into the through lane.",
            "Two-Way Traffic Ahead The one-way road joins a two-way road ahead. You will be facing oncoming traffic. Divided Highway Begins or Ends These signs indicate the beginning or end of a divided highway. Keep to the right. Stop Ahead There is a stop sign ahead. Slow down and prepare to stop. Signal Ahead A traffic signal is ahead. Slow down and be ready to stop.",

        };

        public AdultBook()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += MainPage_BackRequested;
            base.OnNavigatedTo(e);
        }

        private void MainPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void FlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var flipview = ((FlipView)sender);
            //USE SELECTED INDEX TO FIGURE OUT WHAT PAGE YOU'RE ON

            switch (flipview.SelectedIndex)
            {
                case 0:

                    TextToSpeech(pagedata[0]);

                    break;

                case 1:

                    TextToSpeech(pagedata[1]);

                    break;


                case 2:

                    TextToSpeech(pagedata[2]);

                    break;


                case 3:

                    TextToSpeech(pagedata[3]);

                    break;

                case 4:

                    TextToSpeech(pagedata[4]);


                    break;

                case 5:

                    TextToSpeech(pagedata[5]);

                    break;

                case 6:

                    TextToSpeech(pagedata[6]);

                    break;

                case 7:

                    TextToSpeech(pagedata[7]);

                    break;

                case 8:

                    TextToSpeech(pagedata[8]);

                    break;

                case 9:

                    TextToSpeech(pagedata[9]);

                    break;

                default:

                    break;
            }
        }
        private async void TextToSpeech(string text)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();

            SpeechSynthesisStream synthesisStream = await synthesizer.SynthesizeTextToStreamAsync(text);

            media.AutoPlay = true;
            media.SetSource(synthesisStream, synthesisStream.ContentType);
            media.Play();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }

        private void VolumeSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            if (slider != null)
            {
                media.Volume = slider.Value / 100;
            }
        }

        private void AudioSpeedSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            if (slider != null)
            {
                media.PlaybackRate = slider.Value / 100;
                media.DefaultPlaybackRate = slider.Value / 100;
            }
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Equals(forwardbutton))
            {
                var temp = adultflipview.SelectedIndex;

                if (++temp < 9)
                {
                    adultflipview.SelectedIndex++;
                }
            }
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Equals(previousbutton))
            {
                var temp = adultflipview.SelectedIndex;

                if (--temp > -1)
                {
                    adultflipview.SelectedIndex--;
                }
            }
        }
    }
}
