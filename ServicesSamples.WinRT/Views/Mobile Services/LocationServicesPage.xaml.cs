using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(LocationServicesViewModel))]
    public sealed partial class LocationServicesPage
    {
        #region Constructors

        public LocationServicesPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}