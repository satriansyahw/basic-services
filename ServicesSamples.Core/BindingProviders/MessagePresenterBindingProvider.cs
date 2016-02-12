using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class MessagePresenterBindingProvider : BindingProvider
    {
        #region Constructors

        public MessagePresenterBindingProvider()
        {
            this.AddBinding("ShowButton", BindableProperties.CommandProperty, "ShowPresenterCommand");
            this.AddBinding("ShowButton2", BindableProperties.CommandProperty, "ShowPresenterCommand");
            this.AddBinding("ShowButton3", BindableProperties.CommandProperty, "ShowPresenterCommand");

            this.AddBinding("ShowButton", BindableProperties.CommandParameterProperty, "Message", true);
            this.AddBinding("ShowButton2", BindableProperties.CommandParameterProperty, "MessageTitle", true);
            this.AddBinding("ShowButton3", BindableProperties.CommandParameterProperty, "MessageTitleButtons", true);
        }

        #endregion
    }
}