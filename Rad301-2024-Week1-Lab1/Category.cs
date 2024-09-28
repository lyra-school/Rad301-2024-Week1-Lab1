using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2024_Week1_Lab1
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string Description { get; set; }

        public Category(int id, string desc)
        {
            CategoryId = id;
            Description = desc;
        }
    }
}
