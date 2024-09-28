using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2024_Week1_Lab1
{
    internal class SupplierProduct
    {
        public int SupplierId { get; set; }
        public int ProductId { get; set; }
        public DateTime DateFirstSupplied { get; set; }

        public SupplierProduct(int id, int productId, DateTime dateFirstSupplied)
        {
            SupplierId = id;
            ProductId = productId;
            DateFirstSupplied = dateFirstSupplied;
        }
    }
}
