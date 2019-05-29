using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreatTrade.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GreatTrade.Controllers
{
    public class RankingController : Controller
    {
        private readonly GreatTradeContext _context;

        public RankingController(GreatTradeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var greatTradeContext = from u in _context.Users.Include(x=> x.SalesTransactions)
                                    orderby u.SalesTransactions.Count() descending
                                    group u by u.Country;
            ViewData["count"] = 1;
            
            return View(greatTradeContext);
        }
    }
}