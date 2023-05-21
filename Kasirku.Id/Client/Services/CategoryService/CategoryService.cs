using Kasirku.Id.Shared;

namespace Kasirku.Id.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category { Id = 1, Name = "Bahan Pokok", Url = "bahan pokok", Icon = "box" },
                new Category { Id = 2, Name = "Bahan Plester", Url = "bahan acian", Icon = "box" },
                new Category { Id = 3, Name = "Perkakas", Url = "alat tukang", Icon = "home"}
            };
        }
    }
}
