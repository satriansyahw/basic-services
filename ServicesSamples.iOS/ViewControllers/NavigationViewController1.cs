using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS.ViewControllers
{
    [ImportBinding(typeof(ViewModel1BindingProvider))]
    public partial class NavigationViewController1 : UIViewController<ViewModel1>
    {
        #region Constructors

        public NavigationViewController1()
            : base("NavigationContentView", null)
        {
        }

        #endregion
    }
}