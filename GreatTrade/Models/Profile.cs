using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Profile : ObjectBase
    {

        /*
         * This is the user to whom the profile belongs 
         */
        public virtual User User { get; set; }

        /*
         * This is the user to whom the profile belongs 
         */
        public int UserId { get; set; }

        /*
         * This is the description of the profile
         */
        public string Description { get; set; }
    }
}
