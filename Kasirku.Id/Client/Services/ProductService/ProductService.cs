using Kasirku.Id.Shared;

namespace Kasirku.Id.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product> {
                new Product
                {
                  Id = 1,
                  SubCategoryId = 1,
                  CategoryId = 1,
                  Title = "Semen TigaRoda 50KG",
                  Description = "Kokoh Terpercaya",
                  Image = "https://s0.bukalapak.com/img/515810057/w-1000/Semen_Tiga_Roda_50Kg_1_DO_160zak.png",
                  SKU = "SKU14052023/TR5",
                  Barcode = "ashdb3h4uhsdja8a",
                  Varian = "Semen Abu",
                  Satuan = "Zak",
                  Berat = "50",
                  Dimensi = "50x100x20",
                  Price = 75.000m,
                },
                new Product
                {
                  Id = 2,
                  SubCategoryId = 3,
                  CategoryId = 2,
                  Title = "Semen Putih 40KG",
                  Description = "Kokoh Terpercaya",
                  Image = "https://tse4.mm.bing.net/th?id=OIP.S-o2HEv9UPRN9aC_I09OAAHaHa&pid=Api&P=0",
                  SKU = "SKU14052023/TR4",
                  Barcode = "jjhsdjhqw8912ijewq9",
                  Varian = "Semen Acian",
                  Satuan = "Zak",
                  Berat = "40",
                  Dimensi = "50x100x20",
                  Price = 98.000m,
                },
                new Product
                {
                  Id = 3,
                  SubCategoryId = 1,
                  CategoryId = 1,
                  Title = "Semen Rajawali 50KG",
                  Description = "Kokoh Terpercaya",
                  Image = "https://tse2.mm.bing.net/th?id=OIP.kA3ovG7NlHPYXCgkdoSG3wAAAA&pid=Api&P=0",
                  SKU = "SKU14052023/TR5",
                  Barcode = "nasbdkausddajsa",
                  Varian = "Semen Abu",
                  Satuan = "Zak",
                  Berat = "50",
                  Dimensi = "50x100x20",
                  Price = 65.000m,
                },
                new Product
                {
                  Id = 4,
                  SubCategoryId = 2,
                  CategoryId = 2,
                  Title = "Semen Putih 30KG",
                  Description = "Semen Acian Putih MU",
                  Image = "https://tse2.mm.bing.net/th?id=OIP.uhIC5GnHy56DlXXGmmslqgAAAA&pid=Api&P=0",
                  SKU = "SKU14052023/TR3",
                  Barcode = "jhdkahdlakwkwad334qwa",
                  Varian = "Semen Acian",
                  Satuan = "Zak",
                  Berat = "30",
                  Dimensi = "50x100x20",
                  Price = 98.000m,
                },
            };
        }
    }
}
