using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class ViewModel3BindingProvider : BindingProvider
    {
        #region Constructors

        public ViewModel3BindingProvider()
        {
            this.AddBinding("StatusLabel", BindableProperties.TextProperty, "StatusText");
            this.AddBinding("MessageTextField", BindableProperties.TextProperty, "InputText", BindingMode.TwoWay);
            this.AddBinding("MessageTextField", BindableProperties.HideKeyboardOnReturnProperty, true, true);

            this.AddBinding("OKButton", BindableProperties.CommandProperty, "OKCommand");
            this.AddBinding("OKButton", BindableProperties.HideKeyboardOnReturnProperty, true, true);
            this.AddBinding("CancelButton", BindableProperties.CommandProperty, "CancelCommand");
        }

        #endregion
    }
}