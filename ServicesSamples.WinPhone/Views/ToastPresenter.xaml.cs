using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(ToastPresenterViewModel))]
    public partial class ToastPresenter : PhoneApplicationPage
    {
        #region Constructors

        public ToastPresenter()
        {
            InitializeComponent();
        }

        #endregion
    }
}