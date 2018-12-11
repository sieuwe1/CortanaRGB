using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CortanaRGB
{
    class Settings
    {

        private static Settings instance;

        private Windows.Storage.ApplicationDataContainer localsettings = Windows.Storage.ApplicationData.Current.LocalSettings;


        public String FlashColor
        {

            get {

                if(localsettings.Values["flashcolor"] == null)
                {

                    localsettings.Values["flashcolor"] = "Green";

                }

                return (String)localsettings.Values["flashcolor"];

            }
            set
            {

                localsettings.Values["flashcolor"] = value;


            }
}



        public String VID
        {

            get
            {
                if (localsettings.Values["vid"] == null)
                {

                    localsettings.Values["flashcolor"] = "vid";

                }

                return (String)localsettings.Values["vid"];

            }
            set
            {

                localsettings.Values["vid"] = value;



            }


        }



        public String PID
        {

            get
            {
                if (localsettings.Values["pid"] == null)
                {

                    localsettings.Values["pid"] = "pid";

                }

                return (String)localsettings.Values["pid"];

            }
            set
            {

                localsettings.Values["pid"] = value;



            }


        }


        public String ColorInput
        {

            get
            {

                if (localsettings.Values["ColorInput"] == null)
                {
                    
                    localsettings.Values["ColorInput"] = null;

                }
                return (String)localsettings.Values["ColorInput"];

            }
            set
            {

                localsettings.Values["ColorInput"] = value;

            }


        }

        public int FlashTime
        {

            get
            {
                if (localsettings.Values["FlashTime"] == null)
                {

                    localsettings.Values["FlashTime"] = 70;

                }

                return (int)localsettings.Values["FlashTime"];

            }
            set
            {

                localsettings.Values["FlashTime"] = value;

            }


        }

        public int FadeTime
        {

            get
            {

                if (localsettings.Values["FadeTime"] == null)
                {

                    localsettings.Values["FadeTime"] = 20;

                }

                return (int)localsettings.Values["FadeTime"];

            }
            set
            {

                localsettings.Values["FadeTime"] = value;

            }


        }

        public String FadeOneColor
        {

            get
            {

                if (localsettings.Values["FadeOneColor"] == null)
                {

                    localsettings.Values["FadeOneColor"] = "Cyan";

                }

                return (String)localsettings.Values["FadeOneColor"];

            }
            set
            {

                localsettings.Values["FadeOneColor"] = value;

            }


        }

        public int FadeOneTime
        {

            get
            {

                if (localsettings.Values["FadeOneTime"] == null)
                {

                    localsettings.Values["FadeOneTime"] = 5;

                }

                return (int)localsettings.Values["FadeOneTime"];

            }
            set
            {

                localsettings.Values["FadeOneTime"] = value;

            }


        }

        public ushort sliderR
        {

            get
            {

                if (localsettings.Values["sliderR"] == null)
                {

                    localsettings.Values["sliderR"] = 20;

                }

                return Convert.ToUInt16(localsettings.Values["sliderR"]);

            }
            set
            {

                localsettings.Values["sliderR"] = value;

            }


        }

        public ushort sliderG
        {

            get
            {

                if (localsettings.Values["sliderG"] == null)
                {

                    localsettings.Values["sliderG"] = 150;

                }


                return Convert.ToUInt16(localsettings.Values["sliderG"]);

            }
            set
            {

                localsettings.Values["sliderG"] = value;

            }


        }

        public ushort sliderB
        {

            get
            {

                if (localsettings.Values["sliderB"] == null)
                {

                    localsettings.Values["sliderB"] = 210;

                }


                return Convert.ToUInt16(localsettings.Values["sliderB"]);

            }
            set
            {

                localsettings.Values["sliderB"] = value;

            }


        }


        private Settings()
        {



        }

        public static Settings Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new Settings();

                }
                return instance;
            }

        }

    }
}
