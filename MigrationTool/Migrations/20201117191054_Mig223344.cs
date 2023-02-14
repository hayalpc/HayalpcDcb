using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MigrationTool.Migrations
{
    public partial class Mig223344 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "operator_id",
                schema: "sms",
                table: "smses");

            migrationBuilder.AddColumn<long>(
                name: "carrier_id",
                schema: "sms",
                table: "smses",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "user_bulletins",
                schema: "tracking",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    merchant_id = table.Column<long>(nullable: true),
                    role_id = table.Column<long>(name: "role   _id", nullable: true),
                    user_id = table.Column<long>(nullable: false),
                    action_type = table.Column<string>(maxLength: 64, nullable: false),
                    message = table.Column<string>(maxLength: 1024, nullable: true),
                    type = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    start_date = table.Column<DateTime>(nullable: false),
                    expire_date = table.Column<DateTime>(nullable: false),
                    read_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_bulletins", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_logs",
                schema: "tracking",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    merchant_id = table.Column<long>(nullable: true),
                    user_id = table.Column<long>(nullable: false),
                    action_type = table.Column<string>(maxLength: 64, nullable: false),
                    note = table.Column<string>(maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_logs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_bulletins",
                schema: "tracking");

            migrationBuilder.DropTable(
                name: "user_logs",
                schema: "tracking");

            migrationBuilder.DropColumn(
                name: "carrier_id",
                schema: "sms",
                table: "smses");

            migrationBuilder.AddColumn<long>(
                name: "operator_id",
                schema: "sms",
                table: "smses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
