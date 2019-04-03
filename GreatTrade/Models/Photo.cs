using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }


        public string Route { get; set; }

    }
}
