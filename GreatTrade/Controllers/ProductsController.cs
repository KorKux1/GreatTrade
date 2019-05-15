using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GreatTrade.Models;
using GreatTrade.Models.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Collections.Generic;

namespace GreatTrade.Controllers
{
    public class ProductsController : Controller
    {
        private readonly GreatTradeContext _context;
        private readonly IHostingEnvironment _environment;


        public ProductsController(GreatTradeContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;



        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var greatTradeContext = _context.Products.Include(p => p.City).Include(p => p.Publication.User.Profile).Include(p => p.SubCategory).Include(p =>p.Photos);
            return View(await greatTradeContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.City)
                .Include(p => p.Publication)
                .Include(p => p.SubCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name");
            ViewData["PublicationId"] = new SelectList(_context.Set<Publication>(), "Id", "Id");
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["SubCategoryId"] = new SelectList(_context.SubCategories, "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Description,Tags,RelatedCities,Price,Units,CategoryId,SubCategoryId,IsExpress,ExpiryDate,Id")] Product product, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                product.Id = 11;

                while (_context.Products.Select(x => x.Id).Contains(product.Id)) {
                    Random a = new Random();
                    product.Id = (int)a.Next(12, 10000);
                }

                User s = _context.UserActive();
                Publication p = new Publication() { Id = product.Id, Status = Models.Enum.ProductStatus.Active,
                    UserId =  s.Id, User = s};
                _context.Publication.Add(p);
                product.PublicationId = p.Id;
                product.CityId = _context.UserActive().CityId;
                product.Insignia = Models.Enum.TypeInsignias.New;
                product.Date = (DateTime.Now);
                product.Status = Models.Enum.ProductStatus.Active;

                if (image != null && image.Length > 0)
                {
                    var fileName = Path.Combine(_environment.WebRootPath, "users", image.FileName);

                    await image.CopyToAsync(new FileStream(fileName, FileMode.Create));

                    int PId = 11;
                    while (_context.Photos.Select(x => x.Id).Contains(PId))
                    {
                        Random b = new Random();
                        PId = (int)b.Next(12, 10000);
                    }

                    Photo  a = new Photo() { Id=PId, ProductId = product.Id, Route = "/users/" + image.FileName };
                    _context.Photos.Add(a);
                }

                if (product.IsExpress == false)
                {
                    product.ExpiryDate = null;
                }
                else {
                    product.Insignia = Models.Enum.TypeInsignias.VentaExpress;
                }
                _context.Products.Add(product);
                Notification n = new Notification { UserId = _context.UserActive().Id, Checked = false, Messasge = "Se ha añadido un producto: " + product.Title };
                _context.Notifications.Add(n);
                 await  _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name", product.CityId);
            ViewData["PublicationId"] = new SelectList(_context.Set<Publication>(), "Id", "Id", product.PublicationId);
            ViewData["SubCategoryId"] = new SelectList(_context.SubCategories, "Id", "Name", product.SubCategoryId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Date,Insignia,Status,Title,Description,Price,Units,CityId,PublicationId,SubCategoryId,Id")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", product.CityId);
            ViewData["PublicationId"] = new SelectList(_context.Set<Publication>(), "Id", "Id", product.PublicationId);
            ViewData["SubCategoryId"] = new SelectList(_context.SubCategories, "Id", "Id", product.SubCategoryId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.City)
                .Include(p => p.Publication)
                .Include(p => p.SubCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }


        public IActionResult ShowProduct(int id)
        {

            var product2 = _context.Products.Include(p => p.Publication.User).Include(p => p.Photos)
                .Include(p => p.SubCategory.Category).Include(p => p.City).First(i => i.Id == id);

            var product = _context.Products.Include(p => p.City).Include(p => p.Publication.User.Profile)
                .Include(p => p.SubCategory).Include(p => p.Photos).First(i => i.Id == id);


            ViewData["Photos"] = _context.Photos.Where(m => m.ProductId == id);
            ViewData["Tags"] = _context.Tags.Where(m => m.ProductId == id);
            ViewData["Cities"] = product.City;
          
            //// ViewData["Name"] = _context.Product.First(m => m.Id == id).User.Name;
            return View(product);
            // return View(product);
        }
        public IActionResult Filter(string category, string subcategory, string city)
        {

            ViewData["Subcategories"] = _context.Categories.Include(p => p.SubCategories).First(n => n.Name.Equals(category)).SubCategories.ToList();

            var products = _context.Products.Include(p => p.City).Include(p => p.Publication.User.Profile)
              .Include(p => p.SubCategory).Include(p => p.Photos).Include(p => p.SubCategory.Category);

            var filtrados = new List<Product>();
            if (category != null)
            {
                filtrados = products.Where(x => x.SubCategory.Category.Name.Equals(category)).ToList();

            }
            if (subcategory != null)
            {
                filtrados = products.Where(x => x.SubCategory.Name.Equals(subcategory)).ToList();
            }
            if (city != null)
            {
                filtrados = products.Where(x => x.City.Name.Equals(city)).ToList();
            }





            return View(filtrados);

        }
        public IActionResult FilterDate(string rango)
        {
            List<Product> filtrados = null;
            var products = _context.Products.Include(p => p.City).Include(p => p.Publication.User.Profile)
             .Include(p => p.SubCategory).Include(p => p.Photos).Include(p => p.SubCategory.Category);



            switch (rango)
            {
                case "Un Dia":
                    filtrados = products.Where(x => (DateTime.Today - x.Date).Days == 1).ToList();
                    break;
                case "Una Semana":
                    filtrados = products.Where(x => (DateTime.Today - x.Date).Days == 7).ToList();
                    break;
                case "Dos Semanas":
                    filtrados = products.Where(x => (DateTime.Today - x.Date).Days == 14).ToList();
                    break;
                case "Un Mes":
                    filtrados = products.Where(x => (DateTime.Today - x.Date).Days == 30).ToList();
                    break;
                case "Dos Meses":
                    filtrados = products.Where(x => (DateTime.Today - x.Date).Days == 60).ToList();
                    break;
            }

            return View(filtrados);
        }
    }
}
