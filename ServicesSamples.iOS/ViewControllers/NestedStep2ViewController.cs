using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS.ViewControllers
{
    [ImportBinding(typeof(NestedStep2BindingProvider))]
    public partial class NestedStep2ViewController : UIViewController<NestedStep2ViewModel>
    {
        #region Constructors

        public NestedStep2ViewController()
            : base("Step2ContentView", null)
        {
            this.NavigationItem.Title = "Step 2";
        }

        #endregion

        #region Properties

        public override bool HideKeyboardOnTap
        {
            get { return true; }
        }

        #endregion
    }
}