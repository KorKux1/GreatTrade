using GreatTrade.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class City:ObjectBase
    {

        public virtual List<Product> Product { get; set; }
        public TypeCountries Contry { get; set; }
        public string Name { get; set; }
    }
}
