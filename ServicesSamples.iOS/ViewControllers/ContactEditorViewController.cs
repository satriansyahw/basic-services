using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS
{
    public partial class ContactEditorViewController : UIFormViewController<ContactEditorViewModel>
    {
        #region Constructors

        public ContactEditorViewController()
        {
            this.CancelButtonVisibility = CancelButtonVisibility.Always;
        }

        #endregion

        #region Properties

        public override bool HideKeyboardOnScroll
        {
            get { return true; }
        }

        #endregion
    }
}