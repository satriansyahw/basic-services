using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(SimpleListViewModel))]
    public partial class SimpleList : PhoneApplicationPage
    {
        #region Constructors

        public SimpleList()
        {
            InitializeComponent();
        }

        #endregion
    }
}