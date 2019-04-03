using GreatTrade.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class Product:ObjectBase
	{
		public const int FINISHED = 1;
		public const int UNAVAILABLE = 2;
		public const int ACTIVE = 3;


        public DateTime Date { get; set; }
        public TypeTags Tags { get; set; }
        public int SubCategories { get; set; }
        public int Category { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int Units { get; set; }
       
        public List<Photo> Photos;
        public List<City> RelatedCities { get; set; }

        public Question questions;

	}
}
