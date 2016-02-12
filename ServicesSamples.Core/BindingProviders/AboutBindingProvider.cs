using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class AboutBindingProvider : BindingProvider
    {
        #region Constructors

        public AboutBindingProvider()
        {
            this.AddBinding("GreetingLabel", BindableProperties.TextProperty, "GreetingText");
            this.AddBinding("LearnMoreButton", BindableProperties.CommandProperty, "LearnMoreCommand");
        }

        #endregion
    }
}