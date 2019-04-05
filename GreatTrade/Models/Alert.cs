using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Alert
    {

        public DateTime ExpireDate { get; set; }
        public int periodicity { get; set; }
        public String SubCategories { get; set; }
        public String Categories { get; set; }
        public String RelatedCities { get; set; }
        public String Tags { get; set; }



    }
}
