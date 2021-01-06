using Microsoft.AspNetCore.Mvc;
using Printy.Web.Database;
using Printy.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Printy.Web.Controllers {
    public class AuthorizationController : Controller {
        private readonly PrintyDbContext _dbContext;
        public AuthorizationController(PrintyDbContext dbContext) {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Login() {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user) {
            var result = _dbContext.Users
                .Where(u => u.Email == user.Email && u.Password == user.Password)
                .FirstOrDefault();

            if (result == null) {
                ViewData["WrongEmailOrPassword"] = "True";
                return View();
            }
            // sprawdz czy jest taki w bazie
            // jak nie ma to blad i ten sam controller
            // jak jest to dajesz go dalej i oznaczasz, ze zalogowany
            return View("Views/Home/Index.cshtml");
        }
        public IActionResult Register() {
            return View();
        }
    }
}
