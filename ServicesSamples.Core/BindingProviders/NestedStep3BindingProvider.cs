using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class NestedStep3BindingProvider : BindingProvider
    {
        #region Constructors

        public NestedStep3BindingProvider()
        {
            this.AddBinding("StatusLabel", BindableProperties.TextProperty, "StatusText");
            this.AddBinding("ConfirmEmailTextField", BindableProperties.TextProperty, "RegistrationData.ConfirmEmail", BindingMode.TwoWay);
            this.AddBinding("ConfirmEmailTextField", BindableProperties.HideKeyboardOnReturnProperty, true, true);
            this.AddBinding("PasswordField", BindableProperties.IsCheckedProperty, "RegistrationData.IsAgree", BindingMode.TwoWay);

            this.AddBinding("FinishButton", BindableProperties.CommandProperty, "FinishCommand");
            this.AddBinding("CancelButton", BindableProperties.CommandProperty, "CancelCommand");
        }

        #endregion
    }
}