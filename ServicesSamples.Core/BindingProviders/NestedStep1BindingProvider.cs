using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class NestedStep1BindingProvider : BindingProvider
    {
        #region Constructors

        public NestedStep1BindingProvider()
        {
            this.AddBinding("StatusLabel", BindableProperties.TextProperty, "StatusText");
            this.AddBinding("EmailTextField", BindableProperties.TextProperty, "RegistrationData.Email", BindingMode.TwoWay);
            this.AddBinding("EmailTextField", BindableProperties.HideKeyboardOnReturnProperty, true, true);
            this.AddBinding("PasswordField", BindableProperties.TextProperty, "RegistrationData.Password", BindingMode.TwoWay);
            this.AddBinding("PasswordField", BindableProperties.HideKeyboardOnReturnProperty, true, true);

            this.AddBinding("NextButton", BindableProperties.CommandProperty, "NextCommand");
            this.AddBinding("CancelButton", BindableProperties.CommandProperty, "CancelCommand");
        }

        #endregion
    }
}