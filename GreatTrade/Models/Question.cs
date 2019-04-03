using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class Question:ObjectBase
	{
		public const int ACTIVE = 1;
		public const int EXPIRED = 2;
		public const int ANSWERED = 3;

        public string Questionn { get; set; }
        public Answer Answere { get; set; }
		public int Status { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
