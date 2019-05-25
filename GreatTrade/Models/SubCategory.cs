using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class SubCategory:ObjectBase
    {
        [Display(Name="Categoria")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Display(Name="Nombre")]
        public string Name { get; set; }
    }
}
