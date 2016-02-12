using System.Collections.Generic;
using System.Linq;
using Intersoft.Crosslight;
using Intersoft.Crosslight.ViewModels;
using ServicesSamples.Infrastructure;
using ServicesSamples.Models;
using ServicesSamples.ModelServices;

namespace ServicesSamples.ViewModels
{
    public class SimpleListViewModel : ListViewModelBase<Item>
    {
        #region Constructors

        public SimpleListViewModel()
        {
            // source items, should be plain items, not sorted or filtered
            this.SourceItems = this.Repository.GetAll().ToObservable();
            this.Title = "List Navigation";
        }

        #endregion

        #region Properties

        private IItemRepository Repository
        {
            get
            {
                if (Container.Current.CanResolve<IItemRepository>())
                    return Container.Current.Resolve<IItemRepository>();
                else
                    return new ItemRepository(); // for designer support
            }
        }

        public string TotalItemsText
        {
            get
            {
                if (this.Items.Count() == 0)
                    return "No items.";
                else if (this.Items.Count() == 1)
                    return "1 item";
                else
                    return this.Items.Count() + " items";
            }
        }

        #endregion

        #region Methods

        protected override void OnSourceItemsChanged(ICollection<Item> items)
        {
            if (items != null)
                this.Items = items.OrderBy(o => o.Name);
            else
                this.Items = null;
        }

        #endregion
    }
}