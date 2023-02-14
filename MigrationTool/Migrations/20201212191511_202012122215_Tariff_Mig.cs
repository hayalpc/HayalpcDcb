using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MigrationTool.Migrations
{
    public partial class _202012122215_Tariff_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "business_desc",
                schema: "service",
                table: "services",
                maxLength: 512,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "referral_id",
                schema: "service",
                table: "services",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "tariff_id",
                schema: "service",
                table: "services",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "turk_telekom_active",
                schema: "service",
                table: "services",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "turkcell_active",
                schema: "service",
                table: "services",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "vodafone_active",
                schema: "service",
                table: "services",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "tariffs",
                schema: "service",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    merchant_id = table.Column<long>(nullable: false),
                    name = table.Column<string>(maxLength: 64, nullable: false),
                    description = table.Column<string>(maxLength: 256, nullable: false),
                    turkcell_commission = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    vodafone_commission = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    telekom_commission = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    turkcell_agg_commission = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    vodafone_agg_commission = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    telekom_agg_commission = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    referral_active = table.Column<bool>(nullable: false),
                    turkcell_ref_commission = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    vodafone_ref_commission = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    telekom_ref_commission = table.Column<decimal>(type: "decimal(4,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tariffs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tariffs",
                schema: "service");

            migrationBuilder.DropColumn(
                name: "business_desc",
                schema: "service",
                table: "services");

            migrationBuilder.DropColumn(
                name: "referral_id",
                schema: "service",
                table: "services");

            migrationBuilder.DropColumn(
                name: "tariff_id",
                schema: "service",
                table: "services");

            migrationBuilder.DropColumn(
                name: "turk_telekom_active",
                schema: "service",
                table: "services");

            migrationBuilder.DropColumn(
                name: "turkcell_active",
                schema: "service",
                table: "services");

            migrationBuilder.DropColumn(
                name: "vodafone_active",
                schema: "service",
                table: "services");
        }
    }
}
