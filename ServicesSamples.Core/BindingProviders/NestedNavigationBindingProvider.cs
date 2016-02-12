using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class NestedNavigationBindingProvider : BindingProvider
    {
        #region Constructors

        public NestedNavigationBindingProvider()
        {
            this.AddBinding("NavigateModalButton", BindableProperties.CommandProperty, "NavigateModalCommand");
        }

        #endregion
    }
}