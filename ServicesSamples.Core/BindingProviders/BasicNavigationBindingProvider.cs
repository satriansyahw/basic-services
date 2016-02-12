using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class BasicNavigationBindingProvider : BindingProvider
    {
        #region Constructors

        public BasicNavigationBindingProvider()
        {
            this.AddBinding("NavigateTypeButton", BindableProperties.CommandProperty, "NavigateTypeCommand");
            this.AddBinding("NavigateIdentifierButton", BindableProperties.CommandProperty, "NavigateIdentifierCommand");
            this.AddBinding("NavigateParameterButton", BindableProperties.CommandProperty, "NavigateParameterCommand");
            this.AddBinding("NavigateParameterButton", BindableProperties.CommandParameterProperty, "InputText");

            this.AddBinding("NavigateBarItem", BindableProperties.CommandProperty, "NavigateTypeCommand");

            this.AddBinding("TextField", BindableProperties.HideKeyboardOnReturnProperty, true, true);
            this.AddBinding("TextField", BindableProperties.TextProperty, "InputText", BindingMode.TwoWay);
        }

        #endregion
    }
}