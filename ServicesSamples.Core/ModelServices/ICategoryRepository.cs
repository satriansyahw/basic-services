using ServicesSamples.Models;

namespace ServicesSamples.ModelServices
{
    public interface ICategoryRepository : IDataRepository<Category, int>
    {
        #region Methods

        Category GetByName(string name);

        #endregion
    }
}