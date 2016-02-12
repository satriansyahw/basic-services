using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class ActionPresenterBindingProvider : BindingProvider
    {
        #region Constructors

        public ActionPresenterBindingProvider()
        {
            this.AddBinding("ShowButton", BindableProperties.CommandProperty, "ShowPresenterCommand");
            this.AddBinding("ShowButton2", BindableProperties.CommandProperty, "ShowPresenterCommand");

            this.AddBinding("ShowButton", BindableProperties.CommandParameterProperty, "Standard", true);
            this.AddBinding("ShowButton2", BindableProperties.CommandParameterProperty, "Highlight", true);
        }

        #endregion
    }
}