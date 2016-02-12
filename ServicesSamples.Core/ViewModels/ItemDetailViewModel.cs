using Intersoft.Crosslight;
using Intersoft.Crosslight.ViewModels;
using ServicesSamples.Models;

namespace ServicesSamples.ViewModels
{
    public class ItemDetailViewModel : DetailViewModelBase<Item>
    {
        #region Constructors

        public ItemDetailViewModel()
        {
            this.Title = "Item Detail";
        }

        #endregion

        #region Methods

        public override void Navigated(NavigatedParameter parameter)
        {
            this.Item = parameter.Data as Item;
        }

        #endregion
    }
}