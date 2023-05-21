using Kasirku.Id.Shared;

namespace Kasirku.Id.Client.Services.ProductService
{
    interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
