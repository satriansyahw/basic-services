using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(AboutViewModel))]
    public partial class AboutPage : PhoneApplicationPage
    {
        #region Constructors

        public AboutPage()
        {
            InitializeComponent();
        }

        #endregion
    }
}