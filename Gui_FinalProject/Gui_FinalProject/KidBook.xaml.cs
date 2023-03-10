using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
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
    public sealed partial class KidBook : Page
    {

        private readonly string[] pagedata =
            {
            "Once upon a time there was and old pig with three little pigs, and one day she said to them: “My children, it is time for you to go out in the world and seek your fortunes”. So, bidding their mother good-bye, the three little pigs set out to earn their living.",
            "The first little pig, whose name was Whitey, met a man with a bundle of straw and said to him: “Please, mister, will you give me that straw to build a house with?” The man gave Whitey the straw, and he built himself a house with it.",
            "Presently a wolf came along and knocked at the door of Whitey’s house. “Little pig, little pig,” he said. “Let me come in.” But of course Whitey didn’t want the wolf to come in, so he said: “No, no, by the hair on my chinny-chin-chin!” This made the wolf angry, and he said: Then I’ll puff and I’ll huff, and I’ll blow your house in”. So he puffed and he huffed and he blew the house in. And he carried poor little Whitey away to his home in the forest.",
            "The second little pig, whose name was Blackey, met a man carrying some wood, and he said to him: “Please, mister, will you give me that wood to build a house with?” The man gave Blackey the wood and he built himself a house with it. But along came the wolf and knocked at the door of Blackey’s house. “Little pig, little pig,” he said. “Let me come in.” “No, no,” replied Blackey in great fright. “Not by the hair on my chinny-chin-chin!” “Then I’ll puff and I’ll huff and I’ll blow your house in.” So the wolf puffed and he huffed and at last he blew the house in. And away he went with Blackey to his home in the forest.",
            "Now the third little pig, whose name was Brownie, met a man with a load of bricks and he said to him: “Please, mister, will you give me those bricks to build a house with?” The man gave him the bricks, and Brownie built himself a very snug little house with them. He had just finished his house when the wolf came along. “Little pig, little pig,” he said. “Let me come in!” “No, no, by the hair on my chinny-chin-chin!” “Then I’ll puff and I’ll huff and I’ll blow your house in.” But though the wolf puffed and he huffed, and he huffed and he puffed, he could not blow down Brownie’s house made of bricks. So he said: “Little pig, I know where there is a nice field of turnips.” “Where?” asked Brownie. “Over in Mr. Smith’s field. If you will be ready tomorrow morning, I will call for you and we will go together and get some for dinner.” “Very well,” answered Brownie. “I will be ready. What time do you want to go?” “Around six o’clock,” answered the wolf.",
            "Well, do you know, that smart little pig got up at five o’clock and went out and got the turnips and was back home before the wolf came at six o’clock. When the wolf found that Brownie had been to Mr. Smith’s field before him, he was very angry, and wondered how he could catch him. So he said: “Little pig, I know where there is a nice apple orchard.” “Where?” asked Brownie. “Down at Merry Garden,” replied the wolf. “I will go with you tomorrow morning at five o’clock and we will get some apples.”",
            "But Brownie hustled and bustled around, and went the next morning at four o’clock to the apple orchard. This time he had farther to go and had to climb the tree, so that just as he was getting down with the apples in a basket, he saw the wolf coming. Of course he was frightened. When the wolf came up to the tree, he said to Brownie: “Ah, I see you are here before me. Are they very nice apples?” “Yes, indeed,” replied Brownie. “Here, I will throw one down to you.” And he threw the apple so far that while the wolf was running to pick it up, the little pig jumped down from the tree and ran home.",
            "Now the wolf was very, very angry, and he thought and thought and finally thought of a plan to catch the little pig. Coming to his house the next morning, he said, “Little pig, there is a fair in town this afternoon. Will you go?” “Oh, yes,” replied Brownie. “I will be very glad to go. What time will you want me to be ready?” “At three o’clock,” said the wolf. But Brownie went off to the fair at one o’clock and bought a great big copper kettle. Alas! On the way home with the kettle, he saw the wolf coming up the hill. Poor little Brownie. He didn’t know what to do. And then suddenly he jumped into the copper kettle and gave himself a push. And the kettle went rolling over and over, with the little pig in it. When the wolf saw the kettle coming rolling toward him, he was so frightened that he turned and ran back home without going to the fair.",
            "The next day he stopped at the little pig’s house and told him how frightened he had been by a great, shining thing that had rolled down the hill toward him. Then Brownie laughed and laughed, and said to the wolf: “Ha! I frightened you, Mister Wolf. I had been to the fair and bought a copper kettle, and when I saw you coming I got into it and rolled down the hill.” This made the wolf so very angry that he jumped up on to the roof of the little pig’s house and started to climb down the chimney. When Brownie saw this he made a blazing fire in the fireplace and hung the copper kettle over it full of scalding water. And just as the wolf came down the chimney, the little pig pulled off the cover of the kettle and plop! Into the scalding water fell the wolf.",
            "So Brownie boiled the wolf, and then went out and rescued his two brothers, Whitey and Blackey, from the forest where the wolf had been keeping them. And they all lived happily together in the little brick house forever afterwards."
            };

        public KidBook()
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

        private void VolumeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combobox = ((ComboBox)sender);


            switch (combobox.SelectedIndex)
            {
                case 0:

                    media.Volume = 0;

                    break;

                case 1:

                    media.Volume = 0.25;

                    break;

                case 2:

                    media.Volume = 0.5;

                    break;

                case 3:

                    media.Volume = 0.75;

                    break;

                case 4:

                    media.Volume = 1;

                    break;

                default:

                    break;
            }
        }

        private void VolumeSpeedComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combobox = ((ComboBox)sender);


            switch (combobox.SelectedIndex)
            {
                case 0:

                    media.PlaybackRate = 0.25;


                    break;

                case 1:

                    media.PlaybackRate = 0.5;


                    break;

                case 2:

                    media.PlaybackRate = 0.75;


                    break;

                case 3:

                    media.PlaybackRate = 1;

                    break;

                default:

                    break;
            }
        }
    }
}
