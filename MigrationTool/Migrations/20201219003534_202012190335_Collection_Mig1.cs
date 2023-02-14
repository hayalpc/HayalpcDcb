using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTool.Migrations
{
    public partial class _202012190335_Collection_Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "approve_date",
                schema: "accounting",
                table: "carrier_collections",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "closed_date",
                schema: "accounting",
                table: "carrier_collections",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "refund_amount",
                schema: "accounting",
                table: "carrier_collections",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "report_date",
                schema: "accounting",
                table: "carrier_collections",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "approve_date",
                schema: "accounting",
                table: "carrier_collections");

            migrationBuilder.DropColumn(
                name: "closed_date",
                schema: "accounting",
                table: "carrier_collections");

            migrationBuilder.DropColumn(
                name: "refund_amount",
                schema: "accounting",
                table: "carrier_collections");

            migrationBuilder.DropColumn(
                name: "report_date",
                schema: "accounting",
                table: "carrier_collections");
        }
    }
}
