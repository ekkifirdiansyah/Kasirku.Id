using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasirku.Id.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        public string SKU { get; set; } = string.Empty;
        public string Varian { get; set; } = string.Empty;
        public string Satuan { get; set; } = string.Empty;
        public string Berat { get; set; } = string.Empty;
        public string Dimensi { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }
        public string Barcode { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; }

    }
}
