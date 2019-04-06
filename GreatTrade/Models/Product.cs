using GreatTrade.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class Product:ObjectBase
	{
        public DateTime Date { get; set; }
        public TypeInsignias Insignia { get; set; }
        public ProductStatus Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }   
        public int Units { get; set; }
        public List<Photo> Photos { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
        public List<Question> Questions { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
