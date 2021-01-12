using Microsoft.AspNetCore.Mvc;
using Printy.Web.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Printy.Web.Controllers {
    public class UserController : Controller {
        private readonly PrintyDbContext _dbContext;
        public UserController(PrintyDbContext dbContext) {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult UserAccount() {
            var userId = Convert.ToInt32(Request.Cookies["UserID"]);

            if (!Convert.ToBoolean(userId)) {
                return LocalRedirect("/Authorization/Login");
            }

            var result = _dbContext.Users
                .Where(u => u.Id == userId)
                .FirstOrDefault();

            return View(result);
        }
        [HttpGet]
        public IActionResult Orders() {
            var userId = Convert.ToInt32(Request.Cookies["UserID"]);

            if (!Convert.ToBoolean(userId)) {
                return LocalRedirect("/Authorization/Login");
            }

            var result = _dbContext.Orders
                .Where(o => o.UserId == userId)
                .ToList();

            return View(result);
        }
    }
}
