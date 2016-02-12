using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS
{
    [ImportBinding(typeof(ContactServicesBindingProvider))]
    public partial class ContactServicesViewController : UIViewController<ContactServicesViewModel>
    {
        #region Constructors

        public ContactServicesViewController()
            : base("ContactServicesView", null)
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