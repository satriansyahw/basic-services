using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(ViewModel1))]
    public partial class ViewModel1Page : PhoneApplicationPage
    {
        #region Constructors

        public ViewModel1Page()
        {
            InitializeComponent();
        }

        #endregion
    }
}