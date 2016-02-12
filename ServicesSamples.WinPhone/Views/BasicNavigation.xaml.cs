using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(BasicNavigationViewModel))]
    public partial class BasicNavigation : PhoneApplicationPage
    {
        #region Constructors

        public BasicNavigation()
        {
            InitializeComponent();
        }

        #endregion
    }
}