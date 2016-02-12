using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS
{
    [ImportBinding(typeof(NestedNavigationBindingProvider))]
    public partial class NestedNavigationViewController : UIViewController<NestedNavigationViewModel>
    {
        #region Constructors

        public NestedNavigationViewController()
            : base("NestedNavigationView", null)
        {
        }

        #endregion

        #region Properties

        public override bool AutoFitContentSize
        {
            get { return true; }
        }

        public override bool AutoScrollToVisible
        {
            get { return true; }
        }

        #endregion
    }
}