using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTool.Migrations
{
    public partial class _202012122215_Tariff_Mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "telekom_ref_commission",
                schema: "service",
                table: "tariffs",
                newName: "turk_telekom_ref_commission");

            migrationBuilder.RenameColumn(
                name: "telekom_commission",
                schema: "service",
                table: "tariffs",
                newName: "turk_telekom_commission");

            migrationBuilder.RenameColumn(
                name: "telekom_agg_commission",
                schema: "service",
                table: "tariffs",
                newName: "turk_telekom_agg_commission");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "turk_telekom_ref_commission",
                schema: "service",
                table: "tariffs",
                newName: "telekom_ref_commission");

            migrationBuilder.RenameColumn(
                name: "turk_telekom_commission",
                schema: "service",
                table: "tariffs",
                newName: "telekom_commission");

            migrationBuilder.RenameColumn(
                name: "turk_telekom_agg_commission",
                schema: "service",
                table: "tariffs",
                newName: "telekom_agg_commission");
        }
    }
}
