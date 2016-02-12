using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS
{
    [ImportBinding(typeof(ToastPresenterBindingProvider))]
    public partial class ToastPresenterViewController : UIViewController<ToastPresenterViewModel>
    {
        #region Constructors

        public ToastPresenterViewController()
            : base("ToastPresenterView", null)
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