using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTool.Migrations
{
    public partial class Mig241125 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tx_ıd",
                schema: "txn",
                table: "transactions",
                newName: "tx_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tx_id",
                schema: "txn",
                table: "transactions",
                newName: "tx_ıd");
        }
    }
}
