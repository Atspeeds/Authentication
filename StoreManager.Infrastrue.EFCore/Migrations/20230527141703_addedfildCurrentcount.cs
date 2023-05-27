using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreManager.Infrastrue.EFCore.Migrations
{
    public partial class addedfildCurrentcount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CourrentCount",
                table: "InventoryOpration",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourrentCount",
                table: "InventoryOpration");
        }
    }
}
