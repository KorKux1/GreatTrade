using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Photo
    {
        private int Id { get; set; }
        private int ProductId { get; set; }
        public virtual Product Product { get; set; }


        private string Route { get; set; }

    }
}
