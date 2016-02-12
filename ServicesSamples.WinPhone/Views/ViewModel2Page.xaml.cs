using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(ViewModel2))]
    public partial class ViewModel2Page : PhoneApplicationPage
    {
        #region Constructors

        public ViewModel2Page()
        {
            InitializeComponent();
        }

        #endregion
    }
}