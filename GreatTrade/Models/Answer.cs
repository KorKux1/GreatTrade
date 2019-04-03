using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public class Answer : ObjectBase
    {

        public string Description { get; set; }
        public string QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
