using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;
using UIKit;

namespace ServicesSamples.iOS
{
    [ImportBinding(typeof(BasicNavigationBindingProvider))]
    public partial class BasicNavigationViewController : UIViewController<BasicNavigationViewModel>
    {
        #region Constructors

        public BasicNavigationViewController()
            : base("BasicNavigationView", null)
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

        #region Methods

        protected override void InitializeView()
        {
            base.InitializeView();

            UIBarButtonItem navigateBarItem = new UIBarButtonItem();
            navigateBarItem.Title = "Navigate";

            this.NavigationItem.SetRightBarButtonItem(navigateBarItem, false);

            // The following code associates the button item with "NavigateBarItem" identifier
            // This allows automatic binding registration when imported from a binding provider
            this.RegisterViewIdentifier("NavigateBarItem", navigateBarItem);
        }

        #endregion
    }
}