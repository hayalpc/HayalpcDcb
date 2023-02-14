using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTool.Migrations
{
    public partial class Mig241123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "interface",
                schema: "tracking",
                table: "table_definitions");

            migrationBuilder.AddColumn<string>(
                name: "namespace",
                schema: "tracking",
                table: "table_definitions",
                maxLength: 256,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "namespace",
                schema: "tracking",
                table: "table_definitions");

            migrationBuilder.AddColumn<string>(
                name: "interface",
                schema: "tracking",
                table: "table_definitions",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");
        }
    }
}
