using Microsoft.EntityFrameworkCore.Migrations;

namespace CashRegisterWebApi.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Name", "OrderId", "Quantatiy", "Weight" },
                values: new object[] { 1, "Computer", null, 0, 0.0 });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Name", "OrderId", "Quantatiy", "Weight" },
                values: new object[] { 2, "Tablet", null, 0, 0.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
