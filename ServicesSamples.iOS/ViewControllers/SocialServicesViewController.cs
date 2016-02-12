using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS
{
    [ImportBinding(typeof(ServicesBindingProvider))]
    public partial class SocialServicesViewController : UIViewController<SocialServicesViewModel>
    {
        #region Constructors

        public SocialServicesViewController()
            : base("SocialServicesView", null)
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

        public override bool HideKeyboardOnTap
        {
            get { return true; }
        }

        #endregion
    }
}