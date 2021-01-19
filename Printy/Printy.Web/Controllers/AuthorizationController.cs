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

            Response.Cookies.Append("LoggedIn", "true");
            Response.Cookies.Append("UserID", Convert.ToString(result.Id));
            return LocalRedirect("/Home/Index");
        }
        [HttpGet]
        public IActionResult Register() {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user) {
            if (user.Email == null || user.Password == null) {
                ViewData["WrongFormData"] = "True";
                return View();
            }

            var userExist = _dbContext.Users.Where(u => u.Email == user.Email).FirstOrDefault();

            if (userExist != null) {
                ViewData["AccountAlreadyExist"] = "True";
                return View();
            }

            var result = _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            Response.Cookies.Append("LoggedIn", "true");
            Response.Cookies.Append("UserID", Convert.ToString(result.Entity.Id));
            return LocalRedirect("/Home/Index");
        }
        [HttpGet]
        public IActionResult Logout() {
            Response.Cookies.Delete("LoggedIn");
            Response.Cookies.Delete("UserID");

            return LocalRedirect("/Home/Index");
        }
    }
}
