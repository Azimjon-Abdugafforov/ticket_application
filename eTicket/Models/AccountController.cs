using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _dbContext;

        public AccountController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // user is authenticated, redirect to home page
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // invalid login, display error message
                ModelState.AddModelError("", "Invalid username or password");
                return View();
            }
        }
    }

}
