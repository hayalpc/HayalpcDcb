using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTool.Migrations
{
    public partial class Mig2411 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "message",
                schema: "tracking",
                table: "user_bulletins",
                maxLength: 1024,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "assembly",
                schema: "tracking",
                table: "table_definitions",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "interface",
                schema: "tracking",
                table: "table_definitions",
                maxLength: 256,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "assembly",
                schema: "tracking",
                table: "table_definitions");

            migrationBuilder.DropColumn(
                name: "interface",
                schema: "tracking",
                table: "table_definitions");

            migrationBuilder.AlterColumn<string>(
                name: "message",
                schema: "tracking",
                table: "user_bulletins",
                type: "character varying(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1024);
        }
    }
}
