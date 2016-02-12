using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class ActivityPresenterBindingProvider : BindingProvider
    {
        #region Constructors

        public ActivityPresenterBindingProvider()
        {
            this.AddBinding("ShowButton", BindableProperties.CommandProperty, "ShowPresenterCommand");
            this.AddBinding("ShowButton2", BindableProperties.CommandProperty, "ShowPresenterCommand");
            this.AddBinding("ShowButton3", BindableProperties.CommandProperty, "ShowPresenterCommand");
            this.AddBinding("ShowButton4", BindableProperties.CommandProperty, "ShowPresenterCommand");

            this.AddBinding("ShowButton", BindableProperties.CommandParameterProperty, "Large", true);
            this.AddBinding("ShowButton2", BindableProperties.CommandParameterProperty, "LargeText", true);
            this.AddBinding("ShowButton3", BindableProperties.CommandParameterProperty, "Small", true);
            this.AddBinding("ShowButton4", BindableProperties.CommandParameterProperty, "Translucent", true);
        }

        #endregion
    }
}