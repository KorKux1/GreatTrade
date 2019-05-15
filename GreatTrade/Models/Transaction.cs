using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class Transaction
	{
        public int Id { get; set; }

        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public int ProductId { get; set; }


        public int Amount { get; set; }
        public double TotalPurchase { get; set; }
        public string Status { get; set; }
        public User Seller { get; set; }
        public User Buyer { get; set; }
        public Product Product { get; set; }

    }
}
