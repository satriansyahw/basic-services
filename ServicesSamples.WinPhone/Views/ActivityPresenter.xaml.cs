using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(ActivityPresenterViewModel))]
    public partial class ActivityPresenter : PhoneApplicationPage
    {
        #region Constructors

        public ActivityPresenter()
        {
            InitializeComponent();
        }

        #endregion
    }
}