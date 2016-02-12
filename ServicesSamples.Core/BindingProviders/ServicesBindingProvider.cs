using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class ServicesBindingProvider : BindingProvider
    {
        #region Constructors

        public ServicesBindingProvider()
        {
            string[] commands = new string[] {"Call", "Message", "OpenBrowser", "ComposeMail", "ComposeMailAdvanced", "CapturePhoto", "CaptureVideo", "ChooseLibrary", "PlaySound", "OpenYoutube", "Share", "ShareSocial", "PostFacebook", "PostTwitter", "GetMyLocation", "ShowMyLocation", "ShowLocationAddress", "ShowDirections", "CheckLocation", "GetCurrentConnection", "GetReachability", "MonitorConnection", "ScheduleNotification", "RunUI", "RunBackground"};

            foreach (string command in commands)
            {
                this.AddBinding(command + "Button", BindableProperties.CommandProperty, "InvokeServiceCommand");
                this.AddBinding(command + "Button", BindableProperties.CommandParameterProperty, command, true);
            }

            this.AddBinding("PhoneTextField", BindableProperties.TextProperty, "PhoneNumber", BindingMode.TwoWay);
        }

        #endregion
    }
}