using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GreatTrade.Models;
using GreatTrade.Models.Context;

using System.Net.Mail;
using System.Net.Mime;
using System.Net;

namespace GreatTrade.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly GreatTradeContext _context;

        public QuestionsController(GreatTradeContext context)
        {
            _context = context;
        }

        // GET: Questions
        //[HttpGet("/Questions/{id}")]
        public async Task<IActionResult> Index(int id)
        {    

            var sqlQ = from q in _context.Questions
                       where q.ProductId == id
                       select q;
            var sqlA = from a in _context.Answers
                       where a.Question.ProductId == id
                       select a;

            Dictionary<int, string[]> myDict = new Dictionary<int, string[]>();
            ViewData["idProduct"] = id;
            
            //ViewData["email"] = sqlEmail.First().Email;
            foreach (var s in sqlQ)
            {

                string[] arr = new string[2];
                arr[0] = s.Description;
                arr[1] = " ";
                //arr[2] = id+"";
                Console.WriteLine();
                myDict.Add(s.Id, arr);
            }
            foreach (var a in sqlA)
            {

                string[] arr = myDict[a.QuestionId];
                arr[1] = a.Description;
            }
            
            return View(myDict);
        }

        public void SendEmail(int productId, string description)
        {
            var sqlPublic = from p in _context.Products
                            where p.Id == productId
                            select p;
            var sqlUs = from u in _context.Publication
                        where u.Id == sqlPublic.First().PublicationId
                        select u;
            var sqlEmail = from e in _context.Users
                           where e.Id == sqlUs.First().Id
                           select e;
            //var sql = _context.Users.Select(u => u.Email).Where(a=>a.)Products.First(p => p.Id == productId).
            MailMessage email = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            MailAddress mailTo = new MailAddress(sqlEmail.First().Email);
            MailAddress mailFrom = new MailAddress("proyectointroicesi@gmail.com");

            email.To.Add(mailTo);
            email.From = mailFrom;
            email.Subject = "Notificacion de pregunta";
            email.SubjectEncoding = System.Text.Encoding.UTF8;
            email.Body = "Se ha realizado la siguiente pregunta: "+description+"\n En el producto: "+sqlPublic.First().Title;
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25;
            smtp.Timeout = 50;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("proyectointroicesi@gmail.com", "proyectoicesi1234");


            string output = "";
            try
            {
                smtp.Send(email);
                email.Dispose();
                output = "Correo electrónico fue enviado satisfactoriamente.";
            }
            catch (SmtpException exm)
            {
                //throw exm.Message.ToString();
            }
            catch (Exception ex)
            {
                output = "Error enviando correo electrónico: " + ex.Message;
            }

            
        }
    
        // GET: Questions/MakeQuestions
        public IActionResult MakeQuestions(int id)
        {
            //var applicationDbContext = _context.Question.Include(q => q.Product);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MakeQuestions([Bind("Description,Status,ProductId,Id")] Question question)
        {
            //Product p = _context.Products.Select(r => r).Where(a => a.Id)
            if (_context.Questions.First() == null)
            {
                question.Id = 1;
            }
            else
            {
                question.Id = _context.Questions.Last().Id + 1;
            }

            //question.Answer = new Answer
            //{
            //    Description = "Yes",

            //};
            question.Status = 1;
            //question.ProductId = 1;
            if (ModelState.IsValid)
            {
                SendEmail(question.ProductId, question.Description);
                _context.Add(question);
                await _context.SaveChangesAsync();
                //return View(Index(question.ProductId));

                return RedirectToAction("Index", "Questions" , new { id = question.ProductId });
            }

            //ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", question.ProductId);
            return View(Index(question.ProductId));

            //_context.Add(question);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));

            return View();
        }

        public async Task<IActionResult> AddAnswer(int id)
        {

            AnswersController a = new AnswersController(_context);
            return View(a.Edit(id));

        }

        // GET: Questions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions
                .Include(q => q.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        // GET: Questions/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Status,ProductId,Id")] Question question)
        {
            if (ModelState.IsValid)
            {
                _context.Add(question);
                Notification n = new Notification { Messasge = "Te han hecho una pregunta acerca del artículo: " + question.ProductId, Checked = false, UserId = _context.Users.First(x => x.Publications.Any(y=> y.Product.Id==question.ProductId)).Id };
                _context.Notifications.Add(n);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", question.ProductId);
            return View(question);
        }

        // GET: Questions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", question.ProductId);
            return View(question);
        }

        // POST: Questions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Status,ProductId,Id")] Question question)
        {
            if (id != question.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(question);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionExists(question.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", question.ProductId);
            return View(question);
        }

        // GET: Questions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions
                .Include(q => q.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        // POST: Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(e => e.Id == id);
        }
    }
}
