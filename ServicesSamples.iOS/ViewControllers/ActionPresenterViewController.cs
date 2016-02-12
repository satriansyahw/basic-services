using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS
{
    [ImportBinding(typeof(ActionPresenterBindingProvider))]
    public partial class ActionPresenterViewController : UIViewController<ActionPresenterViewModel>
    {
        #region Constructors

        public ActionPresenterViewController()
            : base("ActionPresenterView", null)
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