using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Profile {

        /*
         * This is the user to whom the profile belongs 
         */
        public User User { get; set; }

        /*
         * This is the description of the profile
         */
        public string Description { get; set; }
    }
}
