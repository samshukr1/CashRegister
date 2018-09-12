using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CashRegisterWebApi.Migrations
{
    public partial class OrderedItemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_orders_OrderId",
                table: "items");

            migrationBuilder.DropIndex(
                name: "IX_items_OrderId",
                table: "items");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "items");

            migrationBuilder.DropColumn(
                name: "Quantatiy",
                table: "items");

            migrationBuilder.CreateTable(
                name: "ItemOrdered",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    itemId = table.Column<int>(nullable: true),
                    Quantatiy = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOrdered", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemOrdered_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemOrdered_items_itemId",
                        column: x => x.itemId,
                        principalTable: "items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrdered_OrderId",
                table: "ItemOrdered",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrdered_itemId",
                table: "ItemOrdered",
                column: "itemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemOrdered");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "items",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantatiy",
                table: "items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_items_OrderId",
                table: "items",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_items_orders_OrderId",
                table: "items",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
