using System;
using System.Collections.Generic;
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
            var greatTradeContext = _context.Products.Include(p => p.City).Include(p => p.Publication).Include(p => p.SubCategory);
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
                product.PublicationId = 1;
                product.CityId = 1;
                product.Insignia = Models.Enum.TypeInsignias.New;
                product.Date = new DateTime();
                product.Status = Models.Enum.ProductStatus.Active;

                if (image != null && image.Length > 0)
                {
                    var fileName = Path.Combine(_environment.WebRootPath, "users", image.FileName);

                    await image.CopyToAsync(new FileStream(fileName, FileMode.Create));
                    product.Photo = "/users/" + image.FileName;
                }

                if (product.IsExpress == false)
                {
                    product.ExpiryDate = null;
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
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", product.CityId);
            ViewData["PublicationId"] = new SelectList(_context.Set<Publication>(), "Id", "Id", product.PublicationId);
            ViewData["SubCategoryId"] = new SelectList(_context.SubCategories, "Id", "Id", product.SubCategoryId);
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
    }
}
