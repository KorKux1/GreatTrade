using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class Transaction
	{
		private int id;
		private int idSeller;
		private int idBuyer;
		private int idProduct;


		private User buyer;
		private User seller;
		private Product product;

	}
}
