using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Category:ObjectBase
    {
        [Display(Name="Nombre")]
        public string Name { get; set; }
        public List<SubCategory> SubCategories { get; set; }
        public List<Product> Products { get; set; }
    }
}
