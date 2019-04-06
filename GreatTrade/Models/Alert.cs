using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Alert:ObjectBase {

        public DateTime ExpireDate { get; set; }
        public int Periodicity { get; set; }
        public List<Category> Categories { get; set; }
        public String RelatedCities { get; set; }
        public List<Tag> Tags { get; set; }



    }
}
