using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(NotificationServicesViewModel))]
    public sealed partial class NotificationServicesPage
    {
        #region Constructors

        public NotificationServicesPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}