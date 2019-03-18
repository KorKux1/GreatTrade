using GreatTrade.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class User:ObjectBase {

        /*
         * This is the first name of the user
         */
        [Required]
        public string FirstName { get; set; }

        /*
         * This is the first name of the user
         */
        public string LastName { get; set; }

        /*
         * This is the Email of the user
         */
        [Required]
        public EmailAddressAttribute Email { get; set; }

        /*
         * This is the role of the user. It can be administrator or Normal User
         */
        public TypeRoles Role { get; set; }

        /*
         * This is the country of the user
         */
        public TypeCountries Country { get; set; }

        /*
         * Indicate if the user is active
         */
        public bool IsActive { get; set; }

        /*
         * This is the products for sale by the user
         */
        public List<Product> ProductsOnSale { get; set; }

        /*
         * This is the sold products of the user
         */
        public List<Product> SoldProducts { get; set; }

        /*
         * This is the Purchases of the user 
         */
        public List<Product> Purchases { get; set; }

        /*
         * This is the profile of the user
         */
        public Profile Profile { get; set; }
    }
}
