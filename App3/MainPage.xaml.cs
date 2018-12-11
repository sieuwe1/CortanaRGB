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
using Microsoft.Maker.Serial;
using Microsoft.Maker.RemoteWiring;
using System.Threading.Tasks;
using Windows.System.Threading;
using System.Threading;
using System.Diagnostics;
using Windows.UI;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CortanaRGB
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {



        public MainPage()
        {
            this.InitializeComponent();

            
            //comoboBoxes  
            RGBcolor.IsEnabled = true;

            if (Settings.Instance.sliderR.ToString() != null)
            {
                sliderR.Value = Settings.Instance.sliderR;
            }

            if (Settings.Instance.sliderG.ToString() != null)
            {
                sliderG.Value = Settings.Instance.sliderG;
            }

            if (Settings.Instance.sliderB.ToString() != null)
            {
                sliderB.Value = Settings.Instance.sliderB;
            }

            if (Settings.Instance.FlashTime.ToString() != null)
            {
                flashtime.Text = Settings.Instance.FlashTime.ToString();
            }

            if (Settings.Instance.FadeTime.ToString() != null)
            {
                fadeTimebox.Text = Settings.Instance.FadeTime.ToString();
            }

            if (Settings.Instance.FadeOneTime.ToString() != null)
            {
                fadeonecolortime.Text = Settings.Instance.FadeOneTime.ToString();
            }


            if (Settings.Instance.ColorInput != null)
            {

                switch (Settings.Instance.ColorInput)
                {
                    case "Red":
                        RGBcolor.SelectedIndex = 0;
                        break;
                    case "Green":
                        RGBcolor.SelectedIndex = 1;
                        break;
                    case "Blue":
                        RGBcolor.SelectedIndex = 2;
                        break;
                    case "Yellow":
                        RGBcolor.SelectedIndex = 3;
                        break;
                    case "Orange":
                        RGBcolor.SelectedIndex = 4;
                        break;
                    case "White":
                        RGBcolor.SelectedIndex = 5;
                        break;
                    case "Cyan":
                        RGBcolor.SelectedIndex = 6;
                        break;
                    case "Pink":
                        RGBcolor.SelectedIndex = 7;
                        break;
                    case "Purple":
                        RGBcolor.SelectedIndex = 8;
                        break;
                }

            }


            if (Settings.Instance.FadeOneColor != null)
            {

                switch (Settings.Instance.FadeOneColor)
                {
                    case "Red":
                        FadeoneColor.SelectedIndex = 0;
                        break;
                    case "Green":
                        FadeoneColor.SelectedIndex = 1;
                        break;
                    case "Blue":
                        FadeoneColor.SelectedIndex = 2;
                        break;
                    case "Yellow":
                        FadeoneColor.SelectedIndex = 3;
                        break;
                    case "Orange":
                        FadeoneColor.SelectedIndex = 4;
                        break;
                    case "White":
                        FadeoneColor.SelectedIndex = 5;
                        break;
                    case "Cyan":
                        FadeoneColor.SelectedIndex = 6;
                        break;
                    case "Pink":
                        FadeoneColor.SelectedIndex = 7;
                        break;
                    case "Purple":
                        FadeoneColor.SelectedIndex = 8;
                        break;
                }

            }


            if (Settings.Instance.FlashColor != null)
            {

                switch (Settings.Instance.FlashColor)
                {
                    case "Red":
                        Flashcolor.SelectedIndex = 0;
                        break;
                    case "Green":
                        Flashcolor.SelectedIndex = 1;
                        break;
                    case "Blue":
                        Flashcolor.SelectedIndex = 2;
                        break;
                    case "Yellow":
                        Flashcolor.SelectedIndex = 3;
                        break;
                    case "Orange":
                        Flashcolor.SelectedIndex = 4;
                        break;
                    case "White":
                        Flashcolor.SelectedIndex = 5;
                        break;
                    case "Cyan":
                        Flashcolor.SelectedIndex = 6;
                        break;
                    case "Pink":
                        Flashcolor.SelectedIndex = 7;
                        break;
                    case "Purple":
                        Flashcolor.SelectedIndex = 8;
                        break;
                }

            }




        }


        static async Task Delay(int DelayTime)
        {

            await Task.Delay(DelayTime);

        }




        private void ledstripoffclick(object sender, RoutedEventArgs e)
        {

            Board.Instance.LedStripOff();
        }


        private void RGBcolor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            var comboBoxItem = RGBcolor.Items[RGBcolor.SelectedIndex] as ComboBoxItem;
            if (comboBoxItem != null)
            {
                String RGBComboBoxInput = comboBoxItem.Content.ToString();
                Settings.Instance.ColorInput = RGBComboBoxInput;

                switch (RGBComboBoxInput)
                {
                    case "Blue":

                        Board.Instance.fadeonetrue = false;
                        Board.Instance.flashtrue = false;
                        Board.Instance.ledstriponbluetrue =true;
                        Board.Instance.ledstriponredtrue = false;
                        Board.Instance.ledstripongreentrue = false;
                        Board.Instance.ledstriponyellowtrue = false;
                        Board.Instance.ledstriponorangetrue = false;
                        Board.Instance.ledstriponwhitetrue = false;
                        Board.Instance.ledstriponcyantrue = false;
                        Board.Instance.ledstriponpinktrue = false;
                        Board.Instance.ledstriponpurpletrue = false;
                        Board.Instance.fadetrue = false;
                        Board.Instance.SliderOn = false;
                        Board.Instance.ledstriponblue();
                        break;

                    case "Red":

                        Board.Instance.fadeonetrue = false;
                        Board.Instance.flashtrue = false;
                        Board.Instance.ledstriponbluetrue = false;
                        Board.Instance.ledstriponredtrue = true;
                        Board.Instance.ledstripongreentrue = false;
                        Board.Instance.ledstriponyellowtrue = false;
                        Board.Instance.ledstriponorangetrue = false;
                        Board.Instance.ledstriponwhitetrue = false;
                        Board.Instance.ledstriponcyantrue = false;
                        Board.Instance.ledstriponpinktrue = false;
                        Board.Instance.ledstriponpurpletrue = false;
                        Board.Instance.fadetrue = false;
                        Board.Instance.SliderOn = false;
                        Board.Instance.ledstriponred();
                        break;

                    case "Green":

                        Board.Instance.fadeonetrue = false;
                        Board.Instance.flashtrue = false;
                        Board.Instance.ledstriponbluetrue = false;
                        Board.Instance.ledstriponredtrue = false;
                        Board.Instance.ledstripongreentrue = true;
                        Board.Instance.ledstriponyellowtrue = false;
                        Board.Instance.ledstriponorangetrue = false;
                        Board.Instance.ledstriponwhitetrue = false;
                        Board.Instance.ledstriponcyantrue = false;
                        Board.Instance.ledstriponpinktrue = false;
                        Board.Instance.ledstriponpurpletrue = false;
                        Board.Instance.fadetrue = false;
                        Board.Instance.SliderOn = false;
                        Board.Instance.ledstripongreen();
                        break;

                    case "White":

                        Board.Instance.fadeonetrue = false;
                        Board.Instance.flashtrue = false;
                        Board.Instance.ledstriponbluetrue = false;
                        Board.Instance.ledstriponredtrue = false;
                        Board.Instance.ledstripongreentrue = false;
                        Board.Instance.ledstriponyellowtrue = false;
                        Board.Instance.ledstriponorangetrue = false;
                        Board.Instance.ledstriponwhitetrue = true;
                        Board.Instance.ledstriponcyantrue = false;
                        Board.Instance.ledstriponpinktrue = false;
                        Board.Instance.ledstriponpurpletrue = false;
                        Board.Instance.fadetrue = false;
                        Board.Instance.SliderOn = false;
                        Board.Instance.ledstriponwhite();
                        break;

                    case "Yellow":

                        Board.Instance.fadeonetrue = false;
                        Board.Instance.flashtrue = false;
                        Board.Instance.ledstriponbluetrue = false;
                        Board.Instance.ledstriponredtrue = false;
                        Board.Instance.ledstripongreentrue = false;
                        Board.Instance.ledstriponyellowtrue = true;
                        Board.Instance.ledstriponorangetrue = false;
                        Board.Instance.ledstriponwhitetrue = false;
                        Board.Instance.ledstriponcyantrue = false;
                        Board.Instance.ledstriponpinktrue = false;
                        Board.Instance.ledstriponpurpletrue = false;
                        Board.Instance.fadetrue = false;
                        Board.Instance.SliderOn = false;
                        Board.Instance.ledstriponyellow();
                        break;

                    case "Cyan":

                        Board.Instance.fadeonetrue = false;
                        Board.Instance.flashtrue = false;
                        Board.Instance.ledstriponbluetrue = false;
                        Board.Instance.ledstriponredtrue = false;
                        Board.Instance.ledstripongreentrue = false;
                        Board.Instance.ledstriponyellowtrue = false;
                        Board.Instance.ledstriponorangetrue = false;
                        Board.Instance.ledstriponwhitetrue = false;
                        Board.Instance.ledstriponcyantrue = true;
                        Board.Instance.ledstriponpinktrue = false;
                        Board.Instance.ledstriponpurpletrue = false;
                        Board.Instance.fadetrue = false;
                        Board.Instance.SliderOn = false;
                        Board.Instance.ledstriponcyan();
                        break;

                    case "Orange":

                        Board.Instance.fadeonetrue = false;
                        Board.Instance.flashtrue = false;
                        Board.Instance.ledstriponbluetrue = false;
                        Board.Instance.ledstriponredtrue = false;
                        Board.Instance.ledstripongreentrue = false;
                        Board.Instance.ledstriponyellowtrue = false;
                        Board.Instance.ledstriponorangetrue = true;
                        Board.Instance.ledstriponwhitetrue = false;
                        Board.Instance.ledstriponcyantrue = false;
                        Board.Instance.ledstriponpinktrue = false;
                        Board.Instance.ledstriponpurpletrue = false;
                        Board.Instance.fadetrue = false;
                        Board.Instance.SliderOn = false;
                        Board.Instance.ledstriponorange();
                        break;

                    case "Pink":

                        Board.Instance.fadeonetrue = false;
                        Board.Instance.flashtrue = false;
                        Board.Instance.ledstriponbluetrue = false;
                        Board.Instance.ledstriponredtrue = false;
                        Board.Instance.ledstripongreentrue = false;
                        Board.Instance.ledstriponyellowtrue = false;
                        Board.Instance.ledstriponorangetrue = false;
                        Board.Instance.ledstriponwhitetrue = false;
                        Board.Instance.ledstriponcyantrue = false;
                        Board.Instance.ledstriponpinktrue = true;
                        Board.Instance.ledstriponpurpletrue = false;
                        Board.Instance.fadetrue = false;
                        Board.Instance.SliderOn = false;
                        Board.Instance.ledstriponpink();
                        break;

                    case "Purple":

                        Board.Instance.fadeonetrue = false;
                        Board.Instance.flashtrue = false;
                        Board.Instance.ledstriponbluetrue = false;
                        Board.Instance.ledstriponredtrue = false;
                        Board.Instance.ledstripongreentrue = false;
                        Board.Instance.ledstriponyellowtrue = false;
                        Board.Instance.ledstriponorangetrue = false;
                        Board.Instance.ledstriponwhitetrue = false;
                        Board.Instance.ledstriponcyantrue = false;
                        Board.Instance.ledstriponpinktrue = false;
                        Board.Instance.ledstriponpurpletrue = true;
                        Board.Instance.fadetrue = false;
                        Board.Instance.SliderOn = false;
                        Board.Instance.ledstriponpurple();
                        break;


                }

            }
        }






        private void fadeonclick(object sender, RoutedEventArgs e)
        {
            Board.Instance.fadeonetrue = false;
            Board.Instance.flashtrue = false;
            Board.Instance.ledstriponbluetrue = false;
            Board.Instance.ledstriponredtrue = false;
            Board.Instance.ledstripongreentrue = false;
            Board.Instance.ledstriponyellowtrue = false;
            Board.Instance.ledstriponorangetrue = false;
            Board.Instance.ledstriponwhitetrue = false;
            Board.Instance.ledstriponcyantrue = false;
            Board.Instance.ledstriponpinktrue = false;
            Board.Instance.ledstriponpurpletrue = false;
            Board.Instance.SliderOn = false;
            Board.Instance.fadetrue = true;
            Board.Instance.Fade(Settings.Instance.FadeTime);
         

        }





        private void flashonclick(object sender, RoutedEventArgs e)
        {

            Board.Instance.fadeonetrue = false;
            Board.Instance.flashtrue = true;
            Board.Instance.ledstriponbluetrue = false;
            Board.Instance.ledstriponredtrue = false;
            Board.Instance.ledstripongreentrue = false;
            Board.Instance.ledstriponyellowtrue = false;
            Board.Instance.ledstriponorangetrue = false;
            Board.Instance.ledstriponwhitetrue = false;
            Board.Instance.ledstriponcyantrue = false;
            Board.Instance.ledstriponpinktrue = false;
            Board.Instance.ledstriponpurpletrue = false;
            Board.Instance.fadetrue = false;
            Board.Instance.SliderOn = false;
            Board.Instance.Flash(Settings.Instance.FlashColor, Settings.Instance.FlashTime);

            Debug.Write("flash");

        }







        private void fadeonecoloronclick(object sender, RoutedEventArgs e)
        {
            Board.Instance.fadeonetrue = true;
            Board.Instance.flashtrue = false;
            Board.Instance.ledstriponbluetrue = false;
            Board.Instance.ledstriponredtrue = false;
            Board.Instance.ledstripongreentrue = false;
            Board.Instance.ledstriponyellowtrue = false;
            Board.Instance.ledstriponorangetrue = false;
            Board.Instance.ledstriponwhitetrue = false;
            Board.Instance.ledstriponcyantrue = false;
            Board.Instance.ledstriponpinktrue = false;
            Board.Instance.ledstriponpurpletrue = false;
            Board.Instance.fadetrue = false;
            Board.Instance.SliderOn = false;
            Board.Instance.FadeOneColor(Settings.Instance.FadeOneTime, Settings.Instance.FadeOneColor);

        }



        //R      
        private void sliderR_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {


            Board.Instance.fadeonetrue = false;
            Board.Instance.flashtrue = false;
            Board.Instance.ledstriponbluetrue = false;
            Board.Instance.ledstriponredtrue = false;
            Board.Instance.ledstripongreentrue = false;
            Board.Instance.ledstriponyellowtrue = false;
            Board.Instance.ledstriponorangetrue = false;
            Board.Instance.ledstriponwhitetrue = false;
            Board.Instance.ledstriponcyantrue = false;
            Board.Instance.ledstriponpinktrue = false;
            Board.Instance.ledstriponpurpletrue = false;
            Board.Instance.fadetrue = false;
            Board.Instance.SliderOn = true;
            Settings.Instance.sliderR = (ushort)sliderR.Value;
            Board.Instance.Slider(Settings.Instance.sliderR, Settings.Instance.sliderG, Settings.Instance.sliderB);


        }

        //G
        private void sliderG_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

            Board.Instance.fadeonetrue = false;
            Board.Instance.flashtrue = false;
            Board.Instance.ledstriponbluetrue = false;
            Board.Instance.ledstriponredtrue = false;
            Board.Instance.ledstripongreentrue = false;
            Board.Instance.ledstriponyellowtrue = false;
            Board.Instance.ledstriponorangetrue = false;
            Board.Instance.ledstriponwhitetrue = false;
            Board.Instance.ledstriponcyantrue = false;
            Board.Instance.ledstriponpinktrue = false;
            Board.Instance.ledstriponpurpletrue = false;
            Board.Instance.fadetrue = false;
            Board.Instance.SliderOn = true;
            Settings.Instance.sliderG = (ushort)sliderG.Value;
            Board.Instance.Slider(Settings.Instance.sliderR, Settings.Instance.sliderG, Settings.Instance.sliderB);

        }

        //B
        private void sliderB_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

            Board.Instance.fadeonetrue = false;
            Board.Instance.flashtrue = false;
            Board.Instance.ledstriponbluetrue = false;
            Board.Instance.ledstriponredtrue = false;
            Board.Instance.ledstripongreentrue = false;
            Board.Instance.ledstriponyellowtrue = false;
            Board.Instance.ledstriponorangetrue = false;
            Board.Instance.ledstriponwhitetrue = false;
            Board.Instance.ledstriponcyantrue = false;
            Board.Instance.ledstriponpinktrue = false;
            Board.Instance.ledstriponpurpletrue = false;
            Board.Instance.fadetrue = false;
            Board.Instance.SliderOn = true;
            Settings.Instance.sliderB = (ushort)sliderB.Value;
            Board.Instance.Slider(Settings.Instance.sliderR, Settings.Instance.sliderG, Settings.Instance.sliderB);


        }




        private void button_Click(object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(BlankPage1));

        }





        private void FadeoneColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var comboBoxItem = FadeoneColor.Items[FadeoneColor.SelectedIndex] as ComboBoxItem;

            if (comboBoxItem != null)
            {
                Settings.Instance.FadeOneColor = comboBoxItem.Content.ToString();
            }

        }




        private void Flashcolor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var comboBoxItem = Flashcolor.Items[Flashcolor.SelectedIndex] as ComboBoxItem;

            if (comboBoxItem != null)
            {
                Settings.Instance.FlashColor = comboBoxItem.Content.ToString();
            }

        }

        private void fadeTimebox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (fadeTimebox.Text != "")
            {
                Settings.Instance.FadeTime = Convert.ToInt32(fadeTimebox.Text);
            }

        }

        private void flashtime_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (flashtime.Text != "")
            {
                Settings.Instance.FlashTime = Convert.ToInt32(flashtime.Text);
            }
        }

        private void fadeonecolortime_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (fadeonecolortime.Text != "")
            {
                Settings.Instance.FadeOneTime = Convert.ToInt32(fadeonecolortime.Text);

            }
        }
    }





}




