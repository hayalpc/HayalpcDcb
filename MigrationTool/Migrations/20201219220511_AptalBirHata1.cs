using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTool.Migrations
{
    public partial class AptalBirHata1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "merchant_ıd",
                schema: "accounting",
                table: "merchant_payments",
                newName: "merchant_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "merchant_id",
                schema: "accounting",
                table: "merchant_payments",
                newName: "merchant_ıd");
        }
    }
}
