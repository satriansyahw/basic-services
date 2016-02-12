using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(SocialServicesViewModel))]
    public partial class SocialServices : PhoneApplicationPage
    {
        #region Constructors

        public SocialServices()
        {
            InitializeComponent();
        }

        #endregion
    }
}