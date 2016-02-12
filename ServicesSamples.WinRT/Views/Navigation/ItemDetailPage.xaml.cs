using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(ItemDetailViewModel))]
    public sealed partial class ItemDetailPage
    {
        #region Constructors

        public ItemDetailPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}