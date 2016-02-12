using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(BrowserServicesViewModel))]
    public partial class BrowserServices : PhoneApplicationPage
    {
        #region Constructors

        public BrowserServices()
        {
            InitializeComponent();
        }

        #endregion
    }
}