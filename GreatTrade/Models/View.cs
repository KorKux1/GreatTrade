using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class View:ObjectBase {
        public int PublicationId { get; set; }
        public Publication Publication { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
