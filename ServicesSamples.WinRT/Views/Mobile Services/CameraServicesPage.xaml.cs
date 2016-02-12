using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(CameraServicesViewModel))]
    public sealed partial class CameraServicesPage
    {
        #region Constructors

        public CameraServicesPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}