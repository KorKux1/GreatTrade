using GreatTrade.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class User:ObjectBase {

        /*
         * This is the first name of the user
         */
        [Required]
        [Display(Name ="Nombres")]
        public string FirstName { get; set; }

        /*
         * This is the first name of the user
         */
         [Display(Name ="Apellidos")]
        public string LastName { get; set; }

        /*
         * This is the Email of the user
         */
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /*
         * This is the role of the user. It can be administrator or Normal User
         */
         [Display(Name ="Rol")]
        public TypeRoles Role { get; set; }

        /*
         * This is the country of the user
         */
         [Display(Name ="País")]
        public TypeCountries Country { get; set; }

        /*
         * Indicate if the user is active
         */
        [Display(Name ="Activo")]
        public bool IsActive { get; set; }

        /*
         * This is the profile of the user
         */
        public virtual Profile Profile { get; set; }
        [Display(Name ="Ciudad")]
        public City City { get; set; }
        [Display( Name ="Ciudad")]
        public int CityId { get; set; }

        [InverseProperty("Seller")]
        public virtual List<Transaction> PurchaseTransactions { get; set; }
        [InverseProperty("Buyer")]
        public virtual List<Transaction> SalesTransactions { get; set; }

        public List<Publication> Publications { get; set; }

        public List<Notification> Notifications { get; set; }

        public List<Alert> Alerts { get; set; }


        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        
    }
}
