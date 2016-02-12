using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(ModalNavigationViewModel))]
    public partial class ModalNavigation : PhoneApplicationPage
    {
        #region Constructors

        public ModalNavigation()
        {
            InitializeComponent();
        }

        #endregion
    }
}