using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS
{
    [ImportBinding(typeof(ActivityPresenterBindingProvider))]
    public partial class ActivityPresenterViewController : UIViewController<ActivityPresenterViewModel>
    {
        #region Constructors

        public ActivityPresenterViewController()
            : base("ActivityPresenterView", null)
        {
        }

        #endregion

        #region Properties

        public override bool AutoFitContentSize
        {
            get { return true; }
        }

        #endregion
    }
}