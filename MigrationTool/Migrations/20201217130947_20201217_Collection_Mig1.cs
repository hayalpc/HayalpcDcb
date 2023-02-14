using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MigrationTool.Migrations
{
    public partial class _20201217_Collection_Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "accounting");

            migrationBuilder.CreateTable(
                name: "carrier_collection_items",
                schema: "accounting",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    carrier_collection_id = table.Column<long>(nullable: false),
                    merchant_payment_id = table.Column<long>(nullable: false),
                    transaction_id = table.Column<long>(nullable: false),
                    merchant_id = table.Column<long>(nullable: false),
                    service_id = table.Column<long>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    amount = table.Column<decimal>(nullable: false),
                    operator_amount = table.Column<decimal>(nullable: false),
                    aggregator_amount = table.Column<decimal>(nullable: false),
                    merchant_amount = table.Column<decimal>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    payment_date = table.Column<DateTime>(nullable: true),
                    charge_date = table.Column<DateTime>(nullable: true),
                    report_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_carrier_collection_items", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "carrier_collections",
                schema: "accounting",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    name = table.Column<string>(nullable: false),
                    file_name = table.Column<string>(maxLength: 256, nullable: false),
                    note = table.Column<string>(maxLength: 256, nullable: true),
                    carrier_id = table.Column<long>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    total_amount = table.Column<decimal>(nullable: false),
                    operator_amount = table.Column<decimal>(nullable: false),
                    agg_amount = table.Column<decimal>(nullable: false),
                    share_amount = table.Column<decimal>(nullable: false),
                    sended_amount = table.Column<decimal>(nullable: false),
                    residuary_amount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_carrier_collections", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "merchant_payments",
                schema: "accounting",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    merchant_ıd = table.Column<long>(nullable: false),
                    total_amount = table.Column<decimal>(nullable: false),
                    operator_amount = table.Column<decimal>(nullable: false),
                    aggregator_amount = table.Column<decimal>(nullable: false),
                    refund_amount = table.Column<decimal>(nullable: false),
                    extra_fee = table.Column<decimal>(nullable: false),
                    share_amount = table.Column<decimal>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_merchant_payments", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carrier_collection_items",
                schema: "accounting");

            migrationBuilder.DropTable(
                name: "carrier_collections",
                schema: "accounting");

            migrationBuilder.DropTable(
                name: "merchant_payments",
                schema: "accounting");
        }
    }
}
