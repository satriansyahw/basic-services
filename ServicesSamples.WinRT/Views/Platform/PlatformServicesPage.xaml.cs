using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(PlatformServicesViewModel))]
    public sealed partial class PlatformServicesPage
    {
        #region Constructors

        public PlatformServicesPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}