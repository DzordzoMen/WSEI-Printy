using Microsoft.AspNetCore.Mvc;
using Printy.Web.Database;
using Printy.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Printy.Web.Controllers {
    public class PrintersController : Controller {
        private readonly PrintyDbContext _dbContext;
        public PrintersController(PrintyDbContext dbContext) {
            _dbContext = dbContext;
        }
        public IActionResult Index() {
            var printers = _dbContext.Printers.ToList();
            ViewData["Printers"] = printers;
            return View();
        }
        [HttpGet]
        public IActionResult AddPrinter() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPrinter(Printer printer) {
            await _dbContext.Printers.AddAsync(printer);
            _dbContext.SaveChanges();

            return LocalRedirect("/Printers/Index");
        }
        [HttpGet]
        public IActionResult PrinterDetails(int printerId) {
            var printer = _dbContext.Printers.Where(p => p.Id == printerId).FirstOrDefault();
            return View(printer);
        }
        [HttpGet]
        public IActionResult OrderPrinter(int printerId) {
            var userId = Convert.ToInt32(Request.Cookies["UserID"]);
            if (userId == 0) return LocalRedirect("/Authorization/Login");
            var printer = _dbContext.Printers.Where(p => p.Id == printerId).FirstOrDefault();
            return View(printer);
        }
        [HttpPost]
        public IActionResult OrderPrinter(int printerId, string userFile, int fileCopies) {
            var userId = Convert.ToInt32(Request.Cookies["UserID"]);
            UserOrder userOrder = new UserOrder {
                UserId = userId,
                PrinterId = printerId,
                UserFile = userFile,
                FileCopies = fileCopies
            };
            _dbContext.Orders.Add(userOrder);
            // TODO redirect to user orders
            return View();
        }
    }
}
