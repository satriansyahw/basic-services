using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(LocationServicesViewModel))]
    public partial class LocationServices : PhoneApplicationPage
    {
        #region Constructors

        public LocationServices()
        {
            InitializeComponent();
        }

        #endregion
    }
}