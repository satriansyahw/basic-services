using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(PlatformServicesViewModel))]
    public partial class PlatformServices : PhoneApplicationPage
    {
        #region Constructors

        public PlatformServices()
        {
            InitializeComponent();
        }

        #endregion
    }
}