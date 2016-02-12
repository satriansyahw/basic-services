using System.Linq;
using Intersoft.Crosslight;
using ServicesSamples.Infrastructure;
using ServicesSamples.ModelServices;

namespace ServicesSamples.Models
{
    public partial class CategoryGroup : GroupItem<Item>
    {
        #region Constructors

        public CategoryGroup(IGrouping<string, Item> groupItem)
            : base(groupItem)
        {
            this.Category = this.CategoryRepository.GetByName(groupItem.Key);
        }

        #endregion

        #region Properties

        public Category Category { get; private set; }

        private ICategoryRepository CategoryRepository
        {
            get { return Container.Current.Resolve<ICategoryRepository>(); }
        }

        private IItemRepository ItemRepository
        {
            get { return Container.Current.Resolve<IItemRepository>(); }
        }

        #endregion
    }
}