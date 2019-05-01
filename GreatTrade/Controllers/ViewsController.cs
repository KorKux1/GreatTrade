using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GreatTrade.Models;
using GreatTrade.Models.Context;

namespace GreatTrade.Controllers
{
    public class ViewsController : Controller
    {
        private readonly GreatTradeContext _context;

        public ViewsController(GreatTradeContext context)
        {
            _context = context;
        }

        // GET: Views
        public async Task<IActionResult> Index()
        {
            var greatTradeContext = _context.Views.Include(v => v.Publication).Include(v => v.User);
            return View(await greatTradeContext.ToListAsync());
        }

        // GET: Views/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var view = await _context.Views
                .Include(v => v.Publication)
                .Include(v => v.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (view == null)
            {
                return NotFound();
            }

            return View(view);
        }

        // GET: Views/Create
        public IActionResult Create()
        {
            ViewData["PublicationId"] = new SelectList(_context.Publication, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email");
            return View();
        }

        // POST: Views/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PublicationId,UserId,Id")] View view)
        {
            if (ModelState.IsValid)
            {
                _context.Add(view);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PublicationId"] = new SelectList(_context.Publication, "Id", "Id", view.PublicationId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", view.UserId);
            return View(view);
        }

        // GET: Views/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var view = await _context.Views.FindAsync(id);
            if (view == null)
            {
                return NotFound();
            }
            ViewData["PublicationId"] = new SelectList(_context.Publication, "Id", "Id", view.PublicationId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", view.UserId);
            return View(view);
        }

        // POST: Views/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PublicationId,UserId,Id")] View view)
        {
            if (id != view.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(view);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ViewExists(view.Id))
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
            ViewData["PublicationId"] = new SelectList(_context.Publication, "Id", "Id", view.PublicationId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", view.UserId);
            return View(view);
        }

        // GET: Views/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var view = await _context.Views
                .Include(v => v.Publication)
                .Include(v => v.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (view == null)
            {
                return NotFound();
            }

            return View(view);
        }

        // POST: Views/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var view = await _context.Views.FindAsync(id);
            _context.Views.Remove(view);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ViewExists(int id)
        {
            return _context.Views.Any(e => e.Id == id);
        }
    }
}
