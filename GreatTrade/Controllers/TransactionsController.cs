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
    public class TransactionsController : Controller
    {
        private readonly GreatTradeContext _context;

        public TransactionsController(GreatTradeContext context)
        {
            _context = context;
        }

        // GET: Transactions
        public IActionResult Index([Bind("")] int id)
        {
            var product = _context.Products.Include(x => x.Publication.User.SalesTransactions).First(i => i.Id == id);

            return View(product);
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .Include(t => t.Buyer)
                .Include(t => t.Product)
                .Include(t => t.Seller)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            ViewData["BuyerId"] = new SelectList(_context.Users, "Id", "Email");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            ViewData["SellerId"] = new SelectList(_context.Users, "Id", "Email");
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SellerId,BuyerId,ProductId")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BuyerId"] = new SelectList(_context.Users, "Id", "Email", transaction.BuyerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", transaction.ProductId);
            ViewData["SellerId"] = new SelectList(_context.Users, "Id", "Email", transaction.SellerId);
            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            ViewData["BuyerId"] = new SelectList(_context.Users, "Id", "Email", transaction.BuyerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", transaction.ProductId);
            ViewData["SellerId"] = new SelectList(_context.Users, "Id", "Email", transaction.SellerId);
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SellerId,BuyerId,ProductId")] Transaction transaction)
        {
            if (id != transaction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.Id))
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
            ViewData["BuyerId"] = new SelectList(_context.Users, "Id", "Email", transaction.BuyerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", transaction.ProductId);
            ViewData["SellerId"] = new SelectList(_context.Users, "Id", "Email", transaction.SellerId);
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .Include(t => t.Buyer)
                .Include(t => t.Product)
                .Include(t => t.Seller)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transaction = await _context.Transaction.FindAsync(id);
            _context.Transaction.Remove(transaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(int id)
        {
            return _context.Transaction.Any(e => e.Id == id);
        }
        public IActionResult contact_user(int id, int Raiting, double put)
        {
            var product = _context.Products.Include(x => x.Publication.User.Profile.User.SalesTransactions).Include(p => p.Publication.User).First(i => i.Id == id);

            if (product.Publication.UserId != _context.UserActive().Id)
            {

                var trans = new Transaction();
                trans.Id = 1;
                var noti = new Notification();
                noti.Id = 1;


                while (_context.Transaction.Select(a => a.Id).ToList().Contains(trans.Id))
                {
                    Random a = new Random();
                    trans.Id = (int)a.Next(3, 10000);

                }

                while (_context.Notifications.Select(a => a.Id).ToList().Contains(noti.Id))
                {
                    Random a = new Random();
                    noti.Id = (int)a.Next(3, 10000);
                }


                trans.Seller = product.Publication.User;
                trans.Product = product;
                trans.ProductId = id;
                trans.SellerId = product.Publication.UserId;
                trans.Status = "Pendiente";
                trans.BuyerId = _context.UserActive().Id;
                trans.Buyer = _context.UserActive();
                trans.Amount = Raiting;
                trans.TotalPurchase = put;

                noti.Messasge = trans.Buyer.FirstName + " " + "está interesado en tu producto";
                noti.Type = 1;
                noti.UserId = trans.SellerId;
                noti.Checked = false;



                if (ModelState.IsValid)
                {
                    _context.Add(noti);
                    _context.Add(trans);
                    _context.SaveChanges();

                }
                return View(trans);
            }
            else
            {
                ViewData["ERROR"] = "No puedes comprar tus productos";
                return RedirectToAction("Error", "Transactions");
            }


        }

        public async Task<IActionResult> tablas()
        {
            var greatTradeContext = _context.Transactions.Include(u => u.Buyer).Include(a => a.Product);
            return View(await greatTradeContext.ToListAsync());
        }
        public IActionResult sales_user(bool wasAccepted, bool wasRejected, int idT, int id, int amount)
        {
            if (wasAccepted)
            {
                var tE = _context.Transaction.First(a => a.Id == idT);
                _context.Products.Include(t => t.Publication.User).First(t => t.Id == id).Units = (_context.Products.Include(t => t.Publication.User).First(t => t.Id == id).Units - amount);

                if (_context.Products.Include(t => t.Publication.User).First(t => t.Id == id).Units <= 0)
                {

                    var product = _context.Products.Include(t => t.Publication.User).First(t => t.Id == id);
                    _context.Products.Include(t => t.Publication.User).First(t => t.Id == id).Status = Models.Enum.ProductStatus.Finished;
                    _context.Products.Remove(product);
                }

                _context.Transaction.First(a => a.Id == idT).Status = "Vendido";
                _context.SaveChanges();
            }

            if (wasRejected)
            {
                var tE = _context.Transaction.First(a => a.Id == idT);
                _context.Transaction.First(a => a.Id == idT).Status = "Rechazado";
                _context.SaveChanges();

            }

            var user = _context.UserActive();
            var pend = _context.Transaction.Include(a => a.Product.Photos).Include(b => b.Buyer).
                Where(t => t.SellerId == user.Id && t.Status.Equals("Pendiente")).ToList();

            return View(pend);
        }
        public IActionResult Error()
        {
            return View();

        }
    }
}
