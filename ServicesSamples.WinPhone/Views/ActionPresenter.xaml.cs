using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(ActionPresenterViewModel))]
    public partial class ActionPresenter : PhoneApplicationPage
    {
        #region Constructors

        public ActionPresenter()
        {
            InitializeComponent();
        }

        #endregion
    }
}