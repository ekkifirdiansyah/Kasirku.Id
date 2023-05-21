using Kasirku.Id.Shared;

namespace Kasirku.Id.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        void LoadCategories();
    }
}
