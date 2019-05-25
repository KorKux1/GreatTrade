using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
         [Display(Name ="Descripción")]
        public string Description { get; set; }

        /*
         * This is the interests of the user
         */
        public string Interests { get; set; }

        /**
         * Url of User's Facebook Profile 
         */
        [Url]
        public string Facebook { get; set; }

        /**
         * Url of User's Twitter Profile 
         */
        [Url]
        public string Twitter { get; set; }

        /**
         * Url of User's Instagram Profile 
         */
        [Url]
        public string Instagram { get; set; }

        /*
         * Avatar of the user
         */
        public string Avatar { get; set; }
    }
}
