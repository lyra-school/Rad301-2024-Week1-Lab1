using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2024_Week1_Lab1
{
    internal class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName {  get; set; }
        public string SupplierAddressLine1 { get; set; }
        public string SupplierAddressLine2 { get; set; }

        public Supplier(int supplierId, string supplierName, string supplierAddressLine1, string supplierAddressLine2)
        {
            SupplierId = supplierId;
            SupplierName = supplierName;
            SupplierAddressLine1 = supplierAddressLine1;
            SupplierAddressLine2 = supplierAddressLine2;
        }
    }
}
