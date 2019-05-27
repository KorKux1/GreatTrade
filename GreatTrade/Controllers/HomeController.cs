using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreatTrade.Models;
using GreatTrade.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace GreatTrade.Controllers
{
	public class HomeController : Controller
	{
        private readonly GreatTradeContext _context;

        public HomeController(GreatTradeContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View(_context);
        }

        public IActionResult Index(string email, string password)
        {


            if (email == null && password == null)
            {
                return View(_context);
            }
            else
            {
                if (_context.Users.First(p => p.Email.Equals(email)) == null)
                {
                    ViewData["ERROR"] = "No existe un usuario con ese correo";
                    return RedirectToAction(nameof(Login));


                }
                else
                {
                    var user = _context.Users.First(p => p.Email.Equals(email));
                    if (user != null && user.Email.Equals(password))
                    {
                        ViewData["Usuario"] = user.FirstName;
                        _context.Users.First(x => x.IsActive).IsActive = false;
                        user.IsActive = true;

                        ViewData["UsuarioAct"] = _context.UserActive().FirstName;
                        _context.SaveChanges();
                        return View(_context);
                    }
                    else

                        return RedirectToAction(nameof(Login));
                }

            }
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



        public IActionResult Search(String words, String RelatedCities, String Tags, String Authors, double PMin, double PMax, DateTime DMin, DateTime DMax)
        {
            ViewData["Words"] = words; /*+" " +RelatedCities +" " +Tags +" " +Authors +" " +PMin +" " +PMax +" " +DMin +" " +DMax ;*/
            ViewData["RelatedCities"] = RelatedCities;
            ViewData["Tags"] = Tags;
            ViewData["Authors"] = Authors;


            var products = _context.Products.Include(p => p.Publication.User).Include(p => p.Photos)
                  .Include(p => p.SubCategory.Category).Include(p => p.City);
            var z = new List<Product>();

            if (!(words == null) || !(RelatedCities == null) || !(Tags == null) || !(Authors == null))
            {
                z = products.ToList();
            }
            if (words != null)
            {
                z = z.Where(x => x.Title.Contains(words) || x.Description.Contains(words)).ToList();

            }
            if (RelatedCities != null)
            {

                z = z.Where(x => x.RelatedCities.Contains(RelatedCities)).ToList();

            }
            if (Tags != null)
            {

                z = z.Where(x => x.Tags.Contains(Tags)).ToList();

            }
            if (Authors != null)
            {

                z = z.Where(x => x.Publication.User.FirstName.Contains(Authors)).ToList();

            }
            if (PMin == 0) { PMin = 40; }
            if (PMax == 0) { PMax = 1000000000; }

            z = z.Where(x => x.Price >= PMin && x.Price <= PMax).ToList();
            ViewData["PMin"] = PMin;
            ViewData["PMax"] = PMax;

            //if (DMin!= new DateTime(11, 01, 2018) && DMax != new DateTime(11, 01, 2020)) {
            //if (DMin == null) { DMin = new DateTime() ; }
            //if (DMax == null) { DMax = DateTime.Now; }
            //z = z.Where(x => x.Date >= DMin && x.Date <= DMax).ToList();
            //ViewData["DMin"] = DMin.ToString("MM/dd/yyyy hh:mm tt",
            //          System.Globalization.CultureInfo.InvariantCulture);
            //ViewData["DMax"] = DMax.ToString("MM/dd/yyyy hh:mm tt",
            //          System.Globalization.CultureInfo.InvariantCulture);


            //}

            if (z.Count>0){
                return View(z);
            }
            else
            {
                return View();
            }
        }



    }
}
