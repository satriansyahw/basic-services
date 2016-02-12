using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS.ViewControllers
{
    [ImportBinding(typeof(ViewModel1BindingProvider))]
    public partial class NavigationParameterViewController : UIViewController<ViewModel2>
    {
        #region Constructors

        public NavigationParameterViewController()
            : base("NavigationContentView", null)
        {
        }

        #endregion
    }
}