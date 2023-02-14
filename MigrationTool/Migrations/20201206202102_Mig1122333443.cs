using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTool.Migrations
{
    public partial class Mig1122333443 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "panel_fee",
                schema: "service",
                table: "services",
                type: "decimal(4,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "postal_code",
                schema: "merchant",
                table: "merchants",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "panel_fee",
                schema: "service",
                table: "services");

            migrationBuilder.DropColumn(
                name: "postal_code",
                schema: "merchant",
                table: "merchants");
        }
    }
}
