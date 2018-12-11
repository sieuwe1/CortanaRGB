using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CortanaRGB
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
            this.Register();
        }

        private async void Register()
        {
            var storageFile =
                await Windows.Storage.StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///VoiceCommandDefinition.xml"));
            await
                Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager.InstallCommandDefinitionsFromStorageFileAsync(storageFile);
        }

        protected override void OnActivated(IActivatedEventArgs e)
        {
           
            base.OnActivated(e);
            if (e.Kind != Windows.ApplicationModel.Activation.ActivationKind.VoiceCommand)
            {
                return;
            }

            var commandArgs = e as Windows.ApplicationModel.Activation.VoiceCommandActivatedEventArgs;
            var speechRecognitionResult = commandArgs.Result;
            var command = speechRecognitionResult.Text;


            // Get the name of the voice command and the text spoken.
            string voiceCommandName = speechRecognitionResult.RulePath[0];
           
         

            switch (voiceCommandName)
            {

                case "ledstripWhite":

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
                case "ledstriponblue":

                    Board.Instance.fadeonetrue = false;
                    Board.Instance.flashtrue = false;
                    Board.Instance.ledstriponbluetrue = true;
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
                case "ledstriponred":

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
                case "ledstripongreen":

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
                case "ledstriponyellow":

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
                case "ledstriponcyan":

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
                case "ledstriponorange":

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
                case "ledstriponpink":

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
                case "ledstriponpurple":

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
                case "ledstripoff":

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
                    Board.Instance.SliderOn = false;
                    Board.Instance.LedStripOff();
                    break;
                case "ledstriponfade":

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
                    break;
                case "ledstriponflash":

                    Board.Instance.fadeonetrue = false;
                    
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
                    Board.Instance.flashtrue = true;
                    Board.Instance.Flash(Settings.Instance.FlashColor, Settings.Instance.FlashTime);
                    break;
                case "ledstriponfadeonecolor":

                  
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
                    Board.Instance.fadeonetrue = true;
                    Board.Instance.FadeOneColor(Settings.Instance.FadeOneTime, Settings.Instance.FadeOneColor);
                    break;
                default:
                    break;

            }



            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
                //use the "command" which was spoken by the user.
                // i am just checking weather the Activation is by Voice command or not and  navigating.
                if (e.Kind != Windows.ApplicationModel.Activation.ActivationKind.VoiceCommand)
                {
                    rootFrame.Navigate(typeof(MainPage), e.Kind);
                }
                else
                {
                    rootFrame.Navigate(typeof(MainPage), e.Kind);
                }

                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
            }
            // Ensure the current window is active
            Window.Current.Activate();


        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                // Ensure the current window is active
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
