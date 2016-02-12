using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(TelephonyServicesViewModel))]
    public partial class TelephonyServices : PhoneApplicationPage
    {
        #region Constructors

        public TelephonyServices()
        {
            InitializeComponent();
        }

        #endregion
    }
}