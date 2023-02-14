using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MigrationTool.Migrations
{
    public partial class _20201212_BlobFile_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blob_files",
                schema: "tracking",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    data_id = table.Column<long>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    token = table.Column<Guid>(nullable: false),
                    file_name = table.Column<string>(maxLength: 256, nullable: false),
                    blob_url = table.Column<string>(maxLength: 256, nullable: false),
                    account_name = table.Column<string>(maxLength: 256, nullable: false),
                    account_key = table.Column<string>(maxLength: 256, nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_blob_files", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blob_files",
                schema: "tracking");
        }
    }
}
