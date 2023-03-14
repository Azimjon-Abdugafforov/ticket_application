using eTicket.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class ETicketController : Controller
    {

        private readonly TicketRepository repo;

        public ETicketController()
        {
            this.repo = new TicketRepository();
        }
        // GET: ETicketController
        [Route("/tickets")]
        public ActionResult Index()
        {
            return View(this.repo.GetETickets());
        }
     
      

        // GET: ETicketController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ETicketController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ETicketController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ETicketController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ETicketController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ETicketController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ETicketController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
