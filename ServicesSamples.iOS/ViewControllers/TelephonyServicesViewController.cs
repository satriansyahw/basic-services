using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;
using UIKit;

namespace ServicesSamples.iOS
{
    [ImportBinding(typeof(ServicesBindingProvider))]
    public partial class TelephonyServicesViewController : UIViewController<TelephonyServicesViewModel>
    {
        #region Constructors

        public TelephonyServicesViewController()
            : base("TelephonyServicesView", null)
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

            this.PhoneTextField.KeyboardType = UIKeyboardType.PhonePad;
            this.CallButton.SetPropertyValue(BindableProperties.HideKeyboardOnReturnProperty, true);
            this.MessageButton.SetPropertyValue(BindableProperties.HideKeyboardOnReturnProperty, true);
        }

        #endregion
    }
}