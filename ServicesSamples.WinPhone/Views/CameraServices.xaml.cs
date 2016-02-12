using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(CameraServicesViewModel))]
    public partial class CameraServices : PhoneApplicationPage
    {
        #region Constructors

        public CameraServices()
        {
            InitializeComponent();
        }

        #endregion
    }
}