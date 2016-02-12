using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(SocialServicesViewModel))]
    public sealed partial class SocialServicesPage
    {
        #region Constructors

        public SocialServicesPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}