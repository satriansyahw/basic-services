using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(NotificationServicesViewModel))]
    public partial class NotificationServices : PhoneApplicationPage
    {
        #region Constructors

        public NotificationServices()
        {
            InitializeComponent();
        }

        #endregion
    }
}