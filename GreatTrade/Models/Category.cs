using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Category:ObjectBase
    {
        public string Name { get; set; }
        public List<Category> SubCategory { get; set; }
        public List<Product> Products { get; set; }
    }
}
