using Intersoft.Crosslight;
using ServicesSamples.Models;

namespace ServicesSamples.ModelServices
{
    public interface IItemRepository : IEditableDataRepository<Item, string>
    {
        #region Methods

        CategoryGroup GetCategoryGroup(int group);
        GroupItem<Item> GetLocationGroup(string group);

        #endregion
    }
}