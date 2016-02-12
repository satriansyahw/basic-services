using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(TelephonyServicesViewModel))]
    public sealed partial class TelephonyServicesPage
    {
        #region Constructors

        public TelephonyServicesPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}