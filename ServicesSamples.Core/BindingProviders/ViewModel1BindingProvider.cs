using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class ViewModel1BindingProvider : BindingProvider
    {
        #region Constructors

        public ViewModel1BindingProvider()
        {
            this.AddBinding("StatusLabel", BindableProperties.TextProperty, "StatusText");
            this.AddBinding("CloseButton", BindableProperties.CommandProperty, "CloseCommand");
        }

        #endregion
    }
}