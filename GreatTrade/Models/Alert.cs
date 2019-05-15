using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Alert:ObjectBase {

        public DateTime ExpireDate { get; set; }
        public int Periodicity { get; set; }
        public String RelatedCities { get; set; }
        public String Tags { get; set; }
        public int UserId { get; set; }


    }
}
