using GreatTrade.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int SellerId { get; set; }
        public int BuyerId { get; set; }

        public virtual User Seller { get; set; }
        public virtual User Buyer { get; set; }

        public SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }

    }
}
