using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class User:ObjectBase { 

        /*
         * This is the role of the user. It can be administrator or Normal User
         */
        public int Role { get; set; }

        /*
         * This is the country of the user
         */
        public string Country { get; set; }

        /*
         * This is the name of the user
         */
        public string Name { get; set; }

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
         *This is the Photo of the user
         */
        public string Photo { get; set; }

    }
}
