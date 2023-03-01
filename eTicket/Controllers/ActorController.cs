using eTicket.Data;
using eTicket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class ActorController : Controller
    {
        private ActorRepository repo;

        public ActorController()
        {
            this.repo = new ActorRepository();
        }
        [Route("/actors/list")]
        public ActionResult Index()
        {
            return View(this.repo.GetActors());
        }

        // GET: ActorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ActorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Actor Actor)
        {

            if(!ModelState.IsValid)
            {
                return View(Actor);
            }
            this.repo.InsertActor(Actor);
            return RedirectToAction(nameof(Index));
        }

        // GET: ActorController/Edit/5
        public ActionResult Edit(int id)
        {
            Actor Actor = this.repo.GetActorById(id);
            return View(Actor);
        }

        // POST: ActorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                Actor Actor = repo.GetActorById(id);
                Actor.FullName = collection["FullName"];
                Actor.Bio = collection["Bio"];
                Actor.ProfilePictureURL = collection["ProfilePictureURL"];
                repo.UpdateActor(Actor);

                return RedirectToAction(nameof(Index));
                
            }
            catch
            {
                return View();
            }
        }

        // GET: ActorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ActorController/Delete/5
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
