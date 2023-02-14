using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTool.Migrations
{
    public partial class Mig21110440 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "role   _id",
                schema: "tracking",
                table: "user_bulletins",
                newName: "role_id");

            migrationBuilder.AddColumn<string>(
                name: "user_ip",
                schema: "tracking",
                table: "user_logs",
                maxLength: 32,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "user_ip",
                schema: "tracking",
                table: "user_logs");

            migrationBuilder.RenameColumn(
                name: "role_id",
                schema: "tracking",
                table: "user_bulletins",
                newName: "role   _id");
        }
    }
}
