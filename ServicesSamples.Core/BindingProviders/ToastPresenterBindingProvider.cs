using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class ToastPresenterBindingProvider : BindingProvider
    {
        #region Constructors

        public ToastPresenterBindingProvider()
        {
            this.AddBinding("ShowButton", BindableProperties.CommandProperty, "ShowPresenterCommand");

            for (int i = 2; i <= 8; i++)
                this.AddBinding("ShowButton" + i, BindableProperties.CommandProperty, "ShowPresenterCommand");

            this.AddBinding("ShowButton", BindableProperties.CommandParameterProperty, "Message", true);
            this.AddBinding("ShowButton2", BindableProperties.CommandParameterProperty, "MessageTitle", true);
            this.AddBinding("ShowButton3", BindableProperties.CommandParameterProperty, "MessageTitleImage", true);
            this.AddBinding("ShowButton4", BindableProperties.CommandParameterProperty, "UseOverlay", true);
            this.AddBinding("ShowButton5", BindableProperties.CommandParameterProperty, "Top", true);
            this.AddBinding("ShowButton6", BindableProperties.CommandParameterProperty, "Center", true);
            this.AddBinding("ShowButton7", BindableProperties.CommandParameterProperty, "UseOwner", true);
            this.AddBinding("ShowButton8", BindableProperties.CommandParameterProperty, "ShortDuration", true);
        }

        #endregion
    }
}