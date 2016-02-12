using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(ViewModel1))]
    [RegisterNavigation("ViewModel1Derivative")]
    public partial class ViewModel1DerivativePage : PhoneApplicationPage
    {
        #region Constructors

        public ViewModel1DerivativePage()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();
            (this.ViewModel as ViewModel1).ToastPresenter.Show("Navigated to ViewModel1 but presented with different view.");
        }

        #endregion
    }
}