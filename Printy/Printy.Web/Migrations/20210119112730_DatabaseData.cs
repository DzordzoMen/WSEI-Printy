using Microsoft.EntityFrameworkCore.Migrations;

namespace Printy.Web.Migrations
{
    public partial class DatabaseData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "FileCopies", "PrinterId", "UserFile", "UserId" },
                values: new object[,]
                {
                    { 2, 8, 8, "MojeNotatki", 2 },
                    { 1, 13, 2, "Systemy zarządzania zadaniami w projekcie", 2 }
                });

            migrationBuilder.InsertData(
                table: "Printers",
                columns: new[] { "Id", "Description", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 13, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer13@test.com", "Print by this", "224444444" },
                    { 12, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer12@test.com", "Printero", "007114500" },
                    { 11, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer11@test.com", "Printer #11", "070030012" },
                    { 10, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer10@test.com", "Test Printer", "005789111" },
                    { 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer8@test.com", "Printer 8", "852753951" },
                    { 9, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer9@test.com", "Printer no. 9", "025846759" },
                    { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer6@test.com", "Printer 6", "123456789" },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer5@test.com", "Piąta drukarka", "123456789" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer4@test.com", "Printer Printer", "123456789" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer3@test.com", "Printer 3", "123456789" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer2@test.com", "Second Printer", "123456789" },
                    { 7, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer7@test.com", "Printer 7", "123456789" },
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo nisi at sapien luctus, a ornare est consequat.", "printer1@test.com", "First Printer", "123456789" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { 1, "marek.wiertarka@test.com", "Marek", "Test123@", "Wiertarka" },
                    { 2, "printer1@test.com", "Basia", "Test123@", "Kania" },
                    { 3, "wkapek@test.com", "Wojtek", "Test123@", "Kapeć" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
