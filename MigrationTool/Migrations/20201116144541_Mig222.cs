using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTool.Migrations
{
    public partial class Mig222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type_id",
                schema: "panel",
                table: "users");

            migrationBuilder.AddColumn<int>(
                name: "status",
                schema: "tracking",
                table: "table_definitions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "type",
                schema: "panel",
                table: "users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                schema: "tracking",
                table: "table_definitions");

            migrationBuilder.DropColumn(
                name: "type",
                schema: "panel",
                table: "users");

            migrationBuilder.AddColumn<int>(
                name: "type_id",
                schema: "panel",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
