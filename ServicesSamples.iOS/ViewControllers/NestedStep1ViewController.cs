using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS.ViewControllers
{
    [ImportBinding(typeof(NestedStep1BindingProvider))]
    public partial class NestedStep1ViewController : UIViewController<NestedStep1ViewModel>
    {
        #region Constructors

        public NestedStep1ViewController()
            : base("Step1ContentView", null)
        {
            this.NavigationItem.Title = "Step 1";
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