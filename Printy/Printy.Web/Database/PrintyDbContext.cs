using Microsoft.EntityFrameworkCore;
using Printy.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Printy.Web.Database {
    public class PrintyDbContext : DbContext {
        public PrintyDbContext(DbContextOptions options) : base(options) {}

        #region DbSets

        public DbSet<Printer> Printers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOrder> Orders { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder builder) {
            InitPrinters(builder);
            InitUsers(builder);
            InitOrders(builder);
        }

        #region InitMethods

        private static void InitPrinters(ModelBuilder modelBuilder) => modelBuilder.Entity<Printer>().HasData(
            new { Id = 1, Name = "First Printer", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer1@test.com", PhoneNumber = "123456789" },
                    new { Id = 2, Name = "Second Printer", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer2@test.com", PhoneNumber = "123456789" },
                    new { Id = 3, Name = "Printer 3", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer3@test.com", PhoneNumber = "123456789" },
                    new { Id = 4, Name = "Printer Printer", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer4@test.com", PhoneNumber = "123456789" },
                    new { Id = 5, Name = "Piąta drukarka", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer5@test.com", PhoneNumber = "123456789" },
                    new { Id = 6, Name = "Printer 6", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer6@test.com", PhoneNumber = "123456789" },
                    new { Id = 7, Name = "Printer 7", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer7@test.com", PhoneNumber = "123456789" },
                    new { Id = 8, Name = "Printer 8", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer8@test.com", PhoneNumber = "852753951" },
                    new { Id = 9, Name = "Printer no. 9", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer9@test.com", PhoneNumber = "025846759" },
                    new { Id = 10, Name = "Test Printer", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer10@test.com", PhoneNumber = "005789111" },
                    new { Id = 11, Name = "Printer #11", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer11@test.com", PhoneNumber = "070030012" },
                    new { Id = 12, Name = "Printero", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer12@test.com", PhoneNumber = "007114500" },
                    new { Id = 13, Name = "Print by this", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", Email = "printer13@test.com", PhoneNumber = "224444444" }
            );

        private static void InitUsers(ModelBuilder modelBuilder) => modelBuilder.Entity<User>().HasData(
                new { Id = 1, Name = "Marek", Surname = "Wiertarka", Email = "marek.wiertarka@test.com", Password = "Test123@" },
                new { Id = 2, Name = "Basia", Surname = "Kania", Email = "printer1@test.com", Password = "Test123@" },
                new { Id = 3, Name = "Wojtek", Surname = "Kapeć", Email = "wkapek@test.com", Password = "Test123@" }
            );

        private static void InitOrders(ModelBuilder modelBuilder) => modelBuilder.Entity<UserOrder>().HasData(
                new { Id = 1, UserId = 2, PrinterId = 2, UserFile = "Systemy zarządzania zadaniami w projekcie", FileCopies = 13 },
                new { Id = 2, UserId = 2, PrinterId = 8, UserFile = "MojeNotatki", FileCopies = 8 }
            );

        #endregion
    }
}
