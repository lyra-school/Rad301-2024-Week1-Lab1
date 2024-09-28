using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2024_Week1_Lab1
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public int QuantityInStock { get; set; }
        public float UnitPrice { get; set; }
        public int CategoryId { get; set; }

        public Product(int productId, string description, int quantityInStock, float unitPrice, int categoryId)
        {
            ProductId = productId;
            Description = description;
            QuantityInStock = quantityInStock;
            UnitPrice = unitPrice;
            CategoryId = categoryId;
        }
    }
}
