using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS
{
    [ImportBinding(typeof(ModalNavigationBindingProvider))]
    public partial class ModalNavigationViewController : UIViewController<ModalNavigationViewModel>
    {
        #region Constructors

        public ModalNavigationViewController()
            : base("ModalNavigationView", null)
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