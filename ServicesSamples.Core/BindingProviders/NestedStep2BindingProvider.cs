using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class NestedStep2BindingProvider : BindingProvider
    {
        #region Constructors

        public NestedStep2BindingProvider()
        {
            this.AddBinding("StatusLabel", BindableProperties.TextProperty, "StatusText");
            this.AddBinding("NameTextField", BindableProperties.TextProperty, "RegistrationData.Name", BindingMode.TwoWay);
            this.AddBinding("NameTextField", BindableProperties.HideKeyboardOnReturnProperty, true, true);
            this.AddBinding("ContactTextField", BindableProperties.TextProperty, "RegistrationData.Contact", BindingMode.TwoWay);
            this.AddBinding("ContactTextField", BindableProperties.HideKeyboardOnReturnProperty, true, true);

            this.AddBinding("NextButton", BindableProperties.CommandProperty, "NextCommand");
            this.AddBinding("CancelButton", BindableProperties.CommandProperty, "CancelCommand");
        }

        #endregion
    }
}