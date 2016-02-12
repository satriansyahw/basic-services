using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS.ViewControllers
{
    [ImportBinding(typeof(ViewModel3BindingProvider))]
    public partial class NavigationViewController3 : UIViewController<ViewModel3>
    {
        #region Constructors

        public NavigationViewController3()
            : base("ModalNavigationContentView", null)
        {
        }

        #endregion
    }
}