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
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace GreatTrade.Controllers
{
    public class ProfilesController : Controller
    {
        private readonly GreatTradeContext _context;

        private readonly IHostingEnvironment _environment;


        public ProfilesController(GreatTradeContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;

        }

        // GET: Profiles
        public async Task<IActionResult> Index()
        {
            var greatTradeContext = _context.Profiles.Include(p => p.User);
            return View(await greatTradeContext.ToListAsync());
        }

        // GET: Profiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
           
            var profile = await _context.Profiles.Include(p=> p.User).
                ThenInclude(p=> p.Publications).
                ThenInclude(pr => pr.Product).
                ThenInclude(photo => photo.Photos).
                Include(p=> p.User).ThenInclude(p=> p.Publications).ThenInclude(p=> p.Views).
                Include(p=> p.User).ThenInclude(u => u.PurchaseTransactions).
                Include(p => p.User).ThenInclude(u => u.SalesTransactions).
                Include(p => p.User).ThenInclude(u => u.City).
                FirstOrDefaultAsync(m => m.Id == id);

            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }

        // GET: Profiles/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email");
            return View();
        }

        // POST: Profiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Description,Facebook,Twitter,Instagram,Avatar,Id")] Profile profile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", profile.UserId);
            return View(profile);
        }

        // GET: Profiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _context.Profiles.Include(p=> p.User).FirstOrDefaultAsync(m=> m.Id == id);
            if (profile == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", profile.UserId);
            ViewData["Cities"] = new SelectList(_context.Cities, "Id", "Name", profile.User.City);
            return View(profile);
        }

        // POST: Profiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Description,Interests,Facebook,Twitter,Instagram,Id")] Profile profile, IFormFile image)
        {
            if (id != profile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    if (image != null && image.Length > 0)
                    {
                        var fileName = Path.Combine(_environment.WebRootPath, "avatars", image.FileName);

                        await image.CopyToAsync(new FileStream(fileName, FileMode.Create));
                        profile.Avatar = "/avatars/" + image.FileName;  
                    }
                    _context.Update(profile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfileExists(profile.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", profile.UserId);
            return View(profile);
        }

        // GET: Profiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _context.Profiles
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }

        // POST: Profiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var profile = await _context.Profiles.FindAsync(id);
            _context.Profiles.Remove(profile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfileExists(int id)
        {
            return _context.Profiles.Any(e => e.Id == id);
        }
    }
}
