using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Tag:ObjectBase
    {
        public string Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AlertId { get; set; }
        public Alert Alert { get; set; }
    }
}
