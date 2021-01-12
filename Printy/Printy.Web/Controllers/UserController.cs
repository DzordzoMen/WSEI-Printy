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
            var UserId = Convert.ToInt32(Request.Cookies["UserID"]);

            if (!Convert.ToBoolean(UserId)) {
                return LocalRedirect("/Authorization/Login");
            }

            var result = _dbContext.Users
                .Where(u => u.Id == UserId)
                .FirstOrDefault();

            return View(result);
        }
    }
}
