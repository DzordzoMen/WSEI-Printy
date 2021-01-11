using Microsoft.EntityFrameworkCore;
using Printy.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Printy.Web.Database {
    public class PrintyDbContext : DbContext {
        public PrintyDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Printer> Printers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOrder> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {}

        }
}
