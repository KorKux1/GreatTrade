using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class Question
	{
		public const int ACTIVE = 1;
		public const int EXPIRED = 2;
		public const int ANSWERED = 3;

		private string question;
		private string answer;
		private User questioner;
		private int status;
		private int id;
	}
}
