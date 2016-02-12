using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS
{
    [ImportBinding(typeof(ItemDetailBindingProvider))]
    public partial class ItemDetailViewController : UIViewController<ItemDetailViewModel>
    {
        #region Constructors

        public ItemDetailViewController()
            : base("ItemDetailViewController", null)
        {
            this.NavigationItem.Title = "Item Detail";
        }

        #endregion

        #region Properties

        public override bool AutoFitContentSize
        {
            get { return true; }
        }

        #endregion
    }
}