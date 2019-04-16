using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreatTrade.Models;
using GreatTrade.Models.Context;

namespace GreatTrade.Controllers
{
	public class HomeController : Controller
	{
        private readonly GreatTradeContext _context;

        public HomeController(GreatTradeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context);
        }

        public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
