using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(ItemDetailViewModel))]
    public partial class ItemDetail : PhoneApplicationPage
    {
        #region Constructors

        public ItemDetail()
        {
            InitializeComponent();
        }

        #endregion
    }
}