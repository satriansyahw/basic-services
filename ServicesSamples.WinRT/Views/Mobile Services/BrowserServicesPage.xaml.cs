using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(BrowserServicesViewModel))]
    public sealed partial class BrowserServicesPage
    {
        #region Constructors

        public BrowserServicesPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}