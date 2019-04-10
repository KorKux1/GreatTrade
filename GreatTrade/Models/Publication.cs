using GreatTrade.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Publication:ObjectBase {
        public int UserId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public ProductStatus Status { get; set; }
        public List<View> Views { get; set; }

    }
}
