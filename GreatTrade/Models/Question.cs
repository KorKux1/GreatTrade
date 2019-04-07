using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class Question:ObjectBase
	{
		

        public string Description { get; set; }

        public Answer Answer { get; set; }

		public int Status { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
