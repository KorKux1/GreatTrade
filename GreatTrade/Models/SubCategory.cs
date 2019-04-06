using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class SubCategory:ObjectBase
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
    }
}
