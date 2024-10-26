using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2024_Week1_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ProductModel model = new ProductModel();
            ListCategories(model);
            ListProducts(model);
            ListProductsWithRestriction(model);
            ListProductsWithRestriction2(model);
            ListProductsWithTotal(model);
            ListProductsInHardware(model);
            ListSuppliersWithParts(model);
        }

        static void ListCategories(ProductModel model)
        {
            IEnumerable<string> query = from c in model.Categories
                                        select c.Description;

            Console.WriteLine("== ALL CATEGORIES ==");
            foreach(string s in query)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");
        }

        static void ListProducts(ProductModel model)
        {
            IEnumerable<string> query = from p in model.Products
                                         select p.Description;

            Console.WriteLine("== ALL PRODUCTS ==");
            foreach(string s in query)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");
        }

        static void ListProductsWithRestriction(ProductModel model)
        {
            IEnumerable<string> query = from p in model.Products
                                        where p.QuantityInStock <= 100
                                        select p.Description;

            Console.WriteLine("== PRODUCTS ON OR UNDER 100 QUANTITY ==");
            foreach(string s in query)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");
        }

        static void ListProductsWithRestriction2(ProductModel model)
        {
            IEnumerable<string> query = from p in model.Products
                                        where p.QuantityInStock > 120
                                        select p.Description;

            Console.WriteLine("== PRODUCTS OVER 120 QUANTITY ==");
            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");
        }

        static void ListProductsWithTotal(ProductModel model)
        {
            var query = from p in model.Products
                        select new
                        {
                            p.Description,
                            p.QuantityInStock,
                            p.UnitPrice
                        };
            Console.WriteLine("== ALL PRODUCTS WITH TOTAL VALUES ==");
            foreach(var s in query)
            {
                Console.WriteLine($"{s.Description} - {s.UnitPrice * s.QuantityInStock:c}");
            }
            Console.WriteLine("\n");
        }

        static void ListProductsInHardware(ProductModel model)
        {
            IEnumerable<string> query = from p in model.Products
                                        join c in model.Categories
                                        on p.CategoryId equals c.CategoryId
                                        where p.CategoryId == 1
                                        select p.Description;
            Console.WriteLine("== ALL HARDWARE PRODUCTS ==");
            foreach(string s in query)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");
        }

        static void ListSuppliersWithParts(ProductModel model)
        {
            var query = from s in model.SuppliersProducts
                        join s2 in model.Suppliers
                        on s.SupplierId equals s2.SupplierId
                        join p in model.Products
                        on s.ProductId equals p.ProductId
                        orderby s2.SupplierName
                        select new
                        {
                            s2.SupplierName,
                            p.Description
                        };
            var query2 = model.SuppliersProducts
                        .Join(model.Suppliers, sp => sp.SupplierId, s => s.SupplierId, (sp, s) => new { sp, s })
                        .Join(model.Products, ssp => ssp.sp.ProductId, p => p.ProductId, (ssp, p) => new { ssp, p })
                        .OrderBy(o => o.ssp.s.SupplierName)
                        .Select(obj => new
                        {
                            obj.ssp.s.SupplierName,
                            obj.p.Description
                        });
            Console.WriteLine("== SUPPLIERS WITH THEIR PRODUCTS ==");
            foreach(var s in query2)
            {
                Console.WriteLine($"{s.SupplierName} - {s.Description}");
            }
            Console.WriteLine("\n");
        }
    }
}
