using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(NestedNavigationViewModel))]
    public partial class NestedNavigation : PhoneApplicationPage
    {
        #region Constructors

        public NestedNavigation()
        {
            InitializeComponent();
        }

        #endregion
    }
}