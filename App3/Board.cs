using Microsoft.Maker.RemoteWiring;
using Microsoft.Maker.Serial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CortanaRGB
{
    class Board
    {
        private static Board instance;

        private RemoteDevice arduino;

        public Boolean flashtrue;
        public Boolean fadeonetrue;
        public Boolean fadetrue;
        public Boolean ledstriponbluetrue, ledstriponredtrue, ledstripongreentrue, ledstriponyellowtrue, ledstriponorangetrue, ledstriponwhitetrue, ledstriponcyantrue, ledstriponpinktrue, ledstriponpurpletrue ;
        public Boolean SliderOn;
        public byte g = 10; 
        public byte b = 9; 
        public byte r = 11; 


        private Board()
        {

            connect();


        } 


        public static Board Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new Board();

                }
                return instance;
            }

        }


        public void connect()
        {

            String VID = Settings.Instance.VID;
            String PID = Settings.Instance.PID;

            if (VID != null && PID != null)
            {

                UsbSerial usb = new UsbSerial(VID, PID);
                arduino = new RemoteDevice(usb);
                usb.begin(57600, SerialConfig.SERIAL_8N1);

                //"VID_1A86", "PID_7523"

            }

        }

     
        

        public async void Flash(String color, int flashtime)
        {

            System.Diagnostics.Debug.Write(color + flashtime);

            while (flashtrue == true && color == "Blue" && arduino != null)
            {


                arduino.analogWrite(b, 255);
                arduino.analogWrite(g, 0);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 0);

                arduino.analogWrite(r, 0);

                await Delay(flashtime);
                System.Diagnostics.Debug.Write("flash");



            }

            while (flashtrue == true && color == "Red" && arduino != null)
            {

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 0);
                arduino.analogWrite(r, 255);
               
                await Delay(flashtime);

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 0);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);


            }

            while (flashtrue == true && color == "Green")
            {

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 255);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 0);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);


            }

            while (flashtrue == true && color == "Yellow" && arduino != null)
            {

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 255);
                arduino.analogWrite(r, 255);

                await Delay(flashtime);

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 0);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);


            }

            while (flashtrue == true && color == "White" && arduino != null)
            {

                arduino.analogWrite(b, 255);
                arduino.analogWrite(g, 255);
                arduino.analogWrite(r, 255);

                await Delay(flashtime);

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 0);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);


            }

            while (flashtrue == true && color == "Cyan" && arduino != null)
            {

                arduino.analogWrite(b, 255);
                arduino.analogWrite(g, 255);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 0);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);


            }

            while (flashtrue == true && color == "Orange" && arduino != null)
            {

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 165);
                arduino.analogWrite(r, 255);

                await Delay(flashtime);

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 0);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);


            }

            while (flashtrue == true && color == "Pink" && arduino != null)
            {

                arduino.analogWrite(b, 255);
                arduino.analogWrite(g, 255);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 0);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);


            }

            while (flashtrue == true && color == "Purple" && arduino != null)
            {

                arduino.analogWrite(b, 211);
                arduino.analogWrite(g, 148);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);

                arduino.analogWrite(b, 0);
                arduino.analogWrite(g, 0);
                arduino.analogWrite(r, 0);

                await Delay(flashtime);


            }

            LedStripOff();

        }

        public async void ledstriponblue()
        {
            if (arduino != null && ledstriponbluetrue == true)
            {

                for (ushort x = 0; x < 255; x++)
                {


                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, 0);
                    arduino.analogWrite(g, 0);
                    await Delay(10);

                }

            }
        }

        public async void ledstripongreen()
        {


            if (arduino != null && ledstripongreentrue == true)
            {

                for (ushort x = 0; x < 255; x++)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, 0);
                    arduino.analogWrite(g, x);
                    await Delay(10);

                }

            }

        }

        public async void ledstriponred()
        {
            if (arduino != null && ledstriponredtrue == true)
            {

                for (ushort x = 0; x < 255; x++)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, 0);
                    await Delay(10);
                }
            }
        }

        public async void ledstriponwhite()
        {
            if (arduino != null && ledstriponwhitetrue == true)
            {
                for (ushort x = 0; x < 255; x++)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, x);
                    await Delay(10);
                }
            }
        }

        public async void ledstriponyellow()
        {
            if (arduino != null && ledstriponyellowtrue == true)
            {

                for (ushort x = 0; x < 255; x++)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, x);
                    await Delay(10);
                }
            }
        }

        public async void ledstriponcyan()
        {
            if (arduino != null && ledstriponcyantrue == true)
            {

                for (ushort x = 0; x < 255; x++)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, 0);
                    arduino.analogWrite(g, x);
                    await Delay(10);
                }
            }
        }

        public async void ledstriponorange()
        {
            if (arduino != null && ledstriponorangetrue == true)
            {

                for (ushort x = 0; x < 100; x++)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, x);
                    await Delay(10);
                }

                for (ushort x1 = 100; x1 < 255; x1++)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, x1);
                    arduino.analogWrite(g, 100);
                    await Delay(10);
                }
            }
        }

        public async void ledstriponpink()
        {
            if (arduino != null && ledstriponpinktrue == true)
            {

                for (ushort x2 = 0; x2 < 20; x2++)
                {

                    arduino.analogWrite(b, x2);
                    arduino.analogWrite(r, x2);
                    arduino.analogWrite(g, x2);
                    await Delay(10);
                }

                for (ushort x = 20; x < 147; x++)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, 20);
                    await Delay(10);
                }

                for (ushort x1 = 147; x1 < 255; x1++)
                {

                    arduino.analogWrite(b, 147);
                    arduino.analogWrite(r, x1);
                    arduino.analogWrite(g, 20);
                    await Delay(g);
                }

            }

        }

        public async void ledstriponpurple()
        {

            if (arduino != null && ledstriponpurpletrue == true)
            {

                for (ushort x1 = 0; x1 < 148; x1++)
                {

                    arduino.analogWrite(b, x1);
                    arduino.analogWrite(r, x1);
                    arduino.analogWrite(g, 0);
                    await Delay(10);
                }

                for (ushort x = 148; x < 211; x++)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, 148);
                    arduino.analogWrite(g, 0);
                    await Delay(10);
                }

            }

        }


        //fade

        public async void Fade(int FadeDelay)
        {


            while (fadetrue == true && arduino != null)
            {

                setColourRgb(0, 0, 0);

                ushort[] rgbColour = { 255, 0, 0 };




                // Choose the colours to increment and decrement.

                for (int decColour = 0; decColour < 3; decColour += 1)
                {

                    int incColour = decColour == 2 ? 0 : decColour + 1;



                    // cross-fade the two colours.

                    for (int i = 0; i < 255; i += 1)
                    {

                        rgbColour[decColour] -= 1;

                        rgbColour[incColour] += 1;




                        setColourRgb(rgbColour[0], rgbColour[1], rgbColour[2]);

                        await Delay(FadeDelay);




                    }

                }

            }

            LedStripOff();

        }





        public void setColourRgb(ushort red, ushort green, ushort blue)
        {

            arduino.analogWrite(b, blue);

            arduino.analogWrite(g, green);

            arduino.analogWrite(r, red);




        }

        public async void FadeOneColor(int FadeOneColorTime, String FadeOneColorColor)
        {

            while (fadeonetrue == true && FadeOneColorColor == "Red" && arduino != null)
            {

                for (ushort x = 0; x < 255; x++)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, 0);
                    await Delay(FadeOneColorTime);

                }

                for (ushort x = 255; x > 0; x--)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, 0);
                    await Delay(FadeOneColorTime);

                }

            }


            while (fadeonetrue == true && FadeOneColorColor == "Green" && arduino != null)
            {

                for (ushort x = 0; x < 255; x++)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, 0);
                    arduino.analogWrite(g, x);
                    await Delay(FadeOneColorTime);

                }

                for (ushort x = 255; x > 0; x--)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, 0);
                    arduino.analogWrite(g, x);
                    await Delay(FadeOneColorTime);

                }

            }


            while (fadeonetrue == true && FadeOneColorColor == "Blue" && arduino != null)
            {

                for (ushort x = 0; x < 255; x++)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, 0);
                    arduino.analogWrite(g, 0);
                    await Delay(FadeOneColorTime);

                }

                for (ushort x = 255; x > 0; x--)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, 0);
                    arduino.analogWrite(g, 0);
                    await Delay(FadeOneColorTime);

                }

            }


            while (fadeonetrue == true && FadeOneColorColor == "White" && arduino != null)
            {

                for (ushort x = 0; x < 255; x--)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, x);
                    await Delay(FadeOneColorTime);
                }

                for (ushort x = 255; x > 0; x++)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, x);
                    await Delay(FadeOneColorTime);
                }

            }

            while (fadeonetrue == true && FadeOneColorColor == "Yellow" && arduino != null)
            {

                for (ushort x = 0; x < 255; x++)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, x);
                    await Delay(10);
                }

                for (ushort x = 255; x > 0; x--)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, x);
                    await Delay(10);
                }

            }

            while (fadeonetrue == true && FadeOneColorColor == "Cyan")
            {

                for (ushort x = 0; x < 255; x++)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, 0);
                    arduino.analogWrite(g, x);
                    await Delay(10);
                }

                for (ushort x = 255; x > 0; x--)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, 0);
                    arduino.analogWrite(g, x);
                    await Delay(10);
                }

            }

            while (fadeonetrue == true && FadeOneColorColor == "Orange" && arduino != null)
            {

                for (ushort x = 0; x < 100; x++)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, x);
                    await Delay(10);
                }

                for (ushort x1 = 100; x1 < 255; x1++)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, x1);
                    arduino.analogWrite(g, 100);
                    await Delay(10);
                }


                for (ushort x1 = 255; x1 > 100; x1--)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, x1);
                    arduino.analogWrite(g, 100);
                    await Delay(10);
                }

                for (ushort x = 100; x > 0; x--)
                {

                    arduino.analogWrite(b, 0);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, x);
                    await Delay(10);
                }

            }

            while (fadeonetrue == true && FadeOneColorColor == "Pink" && arduino != null)
            {

                for (ushort x2 = 0; x2 < 20; x2++)
                {

                    arduino.analogWrite(b, x2);
                    arduino.analogWrite(r, x2);
                    arduino.analogWrite(g, x2);
                    await Delay(10);
                }

                for (ushort x = 20; x < 147; x++)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, 20);
                    await Delay(10);
                }

                for (ushort x1 = 147; x1 < 255; x1++)
                {

                    arduino.analogWrite(b, 147);
                    arduino.analogWrite(r, x1);
                    arduino.analogWrite(g, 20);
                    await Delay(10);
                }

                for (ushort x1 = 255; x1 > 147; x1--)
                {

                    arduino.analogWrite(b, 147);
                    arduino.analogWrite(r, x1);
                    arduino.analogWrite(g, 20);
                    await Delay(10);
                }

                for (ushort x = 147; x > 20; x--)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, x);
                    arduino.analogWrite(g, 20);
                    await Delay(10);
                }


                for (ushort x2 = 20; x2 > 0; x2--)
                {

                    arduino.analogWrite(b, x2);
                    arduino.analogWrite(r, x2);
                    arduino.analogWrite(g, x2);
                    await Delay(10);
                }

            }

            while (fadeonetrue == true && FadeOneColorColor == "Purple" && arduino != null)
            {

                for (ushort x1 = 0; x1 < 148; x1++)
                {

                    arduino.analogWrite(b, x1);
                    arduino.analogWrite(r, x1);
                    arduino.analogWrite(g, 0);
                    await Delay(10);
                }

                for (ushort x = 148; x < 211; x++)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, 148);
                    arduino.analogWrite(g, 0);
                    await Delay(10);
                }

                for (ushort x = 211; x > 148; x--)
                {

                    arduino.analogWrite(b, x);
                    arduino.analogWrite(r, 148);
                    arduino.analogWrite(g, 0);
                    await Delay(10);
                }

                for (ushort x1 = 148; x1 > 0; x1--)
                {

                    arduino.analogWrite(b, x1);
                    arduino.analogWrite(r, x1);
                    arduino.analogWrite(g, 0);
                    await Delay(10);
                }

            }


            LedStripOff();

        }



        public void LedStripOff()
        {
            if (arduino != null)
            {
                arduino.analogWrite(b, 0);
                arduino.analogWrite(r, 0);
                arduino.analogWrite(g, 0);
                fadetrue = false;
                fadeonetrue = false;
                flashtrue = false;
                fadeonetrue = false;
                flashtrue = false;
                ledstriponbluetrue = false;
                ledstriponredtrue = false;
                ledstripongreentrue = false;
                ledstriponyellowtrue = false;
                ledstriponorangetrue = false;
                ledstriponwhitetrue = false;
                ledstriponcyantrue = false;
                ledstriponpinktrue = false;
                ledstriponpurpletrue = false;
                SliderOn = false;
            }

        }


        public void Slider(ushort R, ushort G, ushort B)
        {

            if (arduino != null && SliderOn == true)
            {

                arduino.analogWrite(r, R);
                arduino.analogWrite(g, G);
                arduino.analogWrite(b, B);
            }
        }

        private async Task Delay(int DelayTime)
        {

            await Task.Delay(DelayTime);

        }

    }
}
