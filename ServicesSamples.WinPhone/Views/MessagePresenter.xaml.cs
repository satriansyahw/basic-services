using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(MessagePresenterViewModel))]
    public partial class MessagePresenter : PhoneApplicationPage
    {
        #region Constructors

        public MessagePresenter()
        {
            InitializeComponent();
        }

        #endregion
    }
}