using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Notification:ObjectBase
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int Type { get; set; }
        public Boolean Checked { get; set; }
        public String Messasge { get; set; }
    }
}
