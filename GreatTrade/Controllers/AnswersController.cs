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
using System.Net;

namespace GreatTrade.Controllers
{
    public class AnswersController : Controller
    {
        private readonly GreatTradeContext _context;

        public AnswersController(GreatTradeContext context)
        {
            _context = context;
        }

        // GET: Answers
        public async Task<IActionResult> Index()
        {
            var greatTradeContext = _context.Answers.Include(a => a.Question);
            return View(await greatTradeContext.ToListAsync());
        }

        // GET: Answers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _context.Answers
                .Include(a => a.Question)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (answer == null)
            {
                return NotFound();
            }

            return View(answer);
        }

        // GET: Answers/Create
        public IActionResult Create()
        {
            ViewData["QuestionId"] = new SelectList(_context.Questions, "Id", "Id");
            return View();
        }

        // POST: Answers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,QuestionId,Id")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(answer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["QuestionId"] = new SelectList(_context.Questions, "Id", "Id", answer.QuestionId);
            return View(answer);
        }

        // GET: Answers/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var sqlQ = from q in _context.Questions
                                                  where q.Id == id
                                                  select q;
            ViewData["QuestionDesc"] = sqlQ.First().Description;
            Answer answer = new Answer
            {
                QuestionId = id
            };
            return View(answer);
        }

        // POST: Answers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,QuestionId,Id")] Answer answer)
        {
            answer.QuestionId = id;
            var sqlProduct = from p in _context.Questions
                       where p.Id == id
                       select p.ProductId;
            if (ModelState.IsValid)
            {
                _context.Add(answer);
                SendEmail(id, answer.Description);
                await _context.SaveChangesAsync();
                
                return RedirectToAction("Index", "Questions" , new { id = sqlProduct });
            }
            
            return View(answer);
        }

        public void SendEmail(int idQuestion, string description)
        {

            //Consultas para llegar del usuario que hizo la pregunta
            var sqlQuestion = from p in _context.Questions
                            where p.Id == idQuestion
                              select p;
            
            var sqlEmail = from e in _context.Users
                           where e.Id == sqlQuestion.First().Id
                           select e;

            MailMessage email = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            MailAddress mailTo = new MailAddress(sqlEmail.First().Email);
            //Cambiar correo para enviarlo desde otro diferente
            MailAddress mailFrom = new MailAddress("proyectointroicesi@gmail.com");

            email.To.Add(mailTo);
            email.From = mailFrom;
            email.Subject = "Notificacion de respuesta";
            email.SubjectEncoding = System.Text.Encoding.UTF8;
            email.Body = "Se ha contestando la siguiente pregunta: " + sqlQuestion.First().Description + "\n Con la respuesta: " + description;
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

        // GET: Answers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _context.Answers
                .Include(a => a.Question)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (answer == null)
            {
                return NotFound();
            }

            return View(answer);
        }

        // POST: Answers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var answer = await _context.Answers.FindAsync(id);
            _context.Answers.Remove(answer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnswerExists(int id)
        {
            return _context.Answers.Any(e => e.Id == id);
        }
    }
}
