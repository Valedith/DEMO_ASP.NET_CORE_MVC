using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DEMO_ASP.NET_CORE_MVC.Migrations
{
    public partial class RecipeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "ID", "Quantity", "RecipeName", "RegisterDate", "isAvailable" },
                values: new object[,]
                {
                    { 1, 41, "French fries", new DateTime(2018, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 31, "Spaghetti", new DateTime(2016, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 0, "Pizza", new DateTime(2017, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 4, 50, "Curry", new DateTime(2012, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 60, "Baguette", new DateTime(2013, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 6, 57, "Mashed potato", new DateTime(2015, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 7, 0, "Lasagna", new DateTime(2011, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 8, 88, "Ravioli", new DateTime(2018, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "ID",
                keyValue: 8);
        }
    }
}
