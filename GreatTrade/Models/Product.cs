using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class Product
	{
		public const int FINISHED = 1;
		public const int UNAVAILABLE = 2;
		public const int ACTIVE = 3;

		private DateTime date;
		private List<string> tags;
		private int subCategories;
		private int category;
		private double price;
		private string title;
		private string description;
		private int id;
		private int status;
		private int units;
		private string city;
		private string[] photos;
		private List<string> relatedCities;

		private Question questions;

	}
}
