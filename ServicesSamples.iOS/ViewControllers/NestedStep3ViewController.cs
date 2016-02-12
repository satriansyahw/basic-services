using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS.ViewControllers
{
    [ImportBinding(typeof(NestedStep3BindingProvider))]
    public partial class NestedStep3ViewController : UIViewController<NestedStep3ViewModel>
    {
        #region Constructors

        public NestedStep3ViewController()
            : base("Step3ContentView", null)
        {
            this.NavigationItem.Title = "Step 3";
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