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
    }
}
