using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class User
	{
		public const int NORMAL_USER = 1;
		public const int ADMIN_USER = 2;

		private int rol;
		private int id;
		private string country;
		private string name;
		private string email;
		private string description;
		private string photo;
		private bool active;
		private int currency;

		private Product productsOnSale;

	}
}
