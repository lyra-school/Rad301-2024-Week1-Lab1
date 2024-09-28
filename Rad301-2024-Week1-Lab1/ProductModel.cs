using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2024_Week1_Lab1
{
    internal class ProductModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<SupplierProduct> SuppliersProducts { get; set; }

        public ProductModel() {
            Categories = new List<Category>
            {
                new Category(1, "Hardware"),
                new Category(2, "Electrical Appliances")
            };

            Products = new List<Product>
            {
                new Product(1, "9 Inch Nails", 200, 0.1f, 1),
                new Product(2, "9 Inch Bolts", 120, 0.2f, 1),
                new Product(3, "Chimney Hoover", 10, 100.30f, 2),
                new Product(4, "Washing Machine", 7, 399.50f, 2)
            };

            Suppliers = new List<Supplier>
            {
                new Supplier(1, "ACME", "Collooney", "Sligo"),
                new Supplier(2, "Swift Electric", "Finglas", "Dublin")
            };

            SuppliersProducts = new List<SupplierProduct>
            {
                new SupplierProduct(1, 1, new DateTime(2012, 12, 12)),
                new SupplierProduct(1, 2, new DateTime(2017, 8, 13)),
                new SupplierProduct(2, 3, new DateTime(2022, 9, 9)),
                new SupplierProduct(2, 4, new DateTime(2024, 4, 11))
            };
        }
    }
}
