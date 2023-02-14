using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MigrationTool.Migrations
{
    public partial class First124 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "txn");

            migrationBuilder.EnsureSchema(
                name: "merchant");

            migrationBuilder.EnsureSchema(
                name: "panel");

            migrationBuilder.EnsureSchema(
                name: "service");

            migrationBuilder.EnsureSchema(
                name: "sms");

            migrationBuilder.EnsureSchema(
                name: "sub");

            migrationBuilder.EnsureSchema(
                name: "tracking");

            migrationBuilder.CreateTable(
                name: "merchants",
                schema: "merchant",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    name = table.Column<string>(maxLength: 64, nullable: false),
                    type = table.Column<int>(nullable: false),
                    address = table.Column<string>(maxLength: 128, nullable: false),
                    email = table.Column<string>(maxLength: 128, nullable: false),
                    country_id = table.Column<long>(nullable: false),
                    city_id = table.Column<long>(nullable: false),
                    district_id = table.Column<long>(nullable: true),
                    tax_no = table.Column<string>(maxLength: 64, nullable: false),
                    tax_office = table.Column<string>(maxLength: 64, nullable: false),
                    iban = table.Column<string>(maxLength: 64, nullable: false),
                    account_name = table.Column<string>(maxLength: 64, nullable: false),
                    activity_area = table.Column<string>(maxLength: 64, nullable: false),
                    authorized_person_name = table.Column<string>(maxLength: 64, nullable: false),
                    authorized_person_phone = table.Column<string>(maxLength: 64, nullable: false),
                    authorized_person_email = table.Column<string>(maxLength: 64, nullable: false),
                    authorized_person_tckn = table.Column<string>(maxLength: 64, nullable: false),
                    private_key = table.Column<string>(maxLength: 64, nullable: false),
                    commercial_title = table.Column<string>(maxLength: 128, nullable: false),
                    commercial_registry_no = table.Column<string>(maxLength: 64, nullable: true),
                    web_site = table.Column<string>(maxLength: 64, nullable: false),
                    business_desc = table.Column<string>(maxLength: 256, nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_merchants", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "reset_passwords",
                schema: "panel",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    token = table.Column<Guid>(nullable: false),
                    user_id = table.Column<long>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_reset_passwords", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role_permissions",
                schema: "panel",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    role_id = table.Column<long>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    icon = table.Column<string>(nullable: true),
                    role_permission_id = table.Column<long>(nullable: false),
                    order = table.Column<int>(nullable: false),
                    controller = table.Column<string>(nullable: true),
                    action = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    is_menu = table.Column<bool>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_role_permissions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                schema: "panel",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    type = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 64, nullable: false),
                    description = table.Column<string>(maxLength: 64, nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "panel",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    type_id = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    merchant_id = table.Column<long>(nullable: true),
                    name = table.Column<string>(maxLength: 64, nullable: false),
                    surname = table.Column<string>(maxLength: 64, nullable: false),
                    image_path = table.Column<string>(nullable: true),
                    email = table.Column<string>(maxLength: 64, nullable: false),
                    title = table.Column<string>(maxLength: 64, nullable: false),
                    password = table.Column<string>(maxLength: 128, nullable: true),
                    phone = table.Column<string>(maxLength: 64, nullable: false),
                    last_session_id = table.Column<string>(maxLength: 128, nullable: true),
                    last_login_date = table.Column<DateTime>(nullable: true),
                    last_password_change_date = table.Column<DateTime>(nullable: true),
                    wrong_login_try_count = table.Column<int>(nullable: false),
                    last_wrong_login_try_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "services",
                schema: "service",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    name = table.Column<string>(maxLength: 64, nullable: false),
                    merchant_id = table.Column<long>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    sub_type = table.Column<string>(maxLength: 64, nullable: true),
                    platform_type = table.Column<string>(maxLength: 64, nullable: false),
                    private_key = table.Column<string>(maxLength: 64, nullable: false),
                    credential_url = table.Column<string>(maxLength: 64, nullable: true),
                    notification_url = table.Column<string>(maxLength: 64, nullable: true),
                    sms_keyword = table.Column<string>(maxLength: 16, nullable: true),
                    web_site = table.Column<string>(maxLength: 64, nullable: false),
                    status = table.Column<int>(nullable: false),
                    is_refundable = table.Column<bool>(nullable: false),
                    refundable_time = table.Column<int>(nullable: true),
                    limit_profile_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_services", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "smses",
                schema: "sms",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    title = table.Column<string>(maxLength: 16, nullable: false),
                    short_code = table.Column<string>(maxLength: 16, nullable: false),
                    merchant_id = table.Column<long>(nullable: true),
                    service_id = table.Column<long>(nullable: true),
                    operator_id = table.Column<long>(nullable: false),
                    msisdn = table.Column<string>(maxLength: 16, nullable: false),
                    message = table.Column<string>(maxLength: 256, nullable: false),
                    type = table.Column<string>(maxLength: 8, nullable: false),
                    operator_sms_id = table.Column<string>(maxLength: 128, nullable: true),
                    trycount = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    send_date = table.Column<DateTime>(nullable: true),
                    expire_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_smses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "subscriptions",
                schema: "sub",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    merchant_id = table.Column<long>(nullable: false),
                    service_id = table.Column<long>(nullable: false),
                    carrier_id = table.Column<long>(nullable: false),
                    msisdn = table.Column<string>(maxLength: 16, nullable: false),
                    hire_amount = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_subscriptions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "table_definitions",
                schema: "tracking",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    action_type = table.Column<int>(nullable: false),
                    model_name = table.Column<string>(maxLength: 256, nullable: false),
                    role_id1 = table.Column<long>(nullable: true),
                    role_id2 = table.Column<long>(nullable: true),
                    description = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_definitions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "table_histories",
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
                    table_definition_id = table.Column<long>(nullable: false),
                    action_type = table.Column<int>(nullable: false),
                    action_detail = table.Column<string>(maxLength: 64, nullable: false),
                    note = table.Column<string>(maxLength: 256, nullable: true),
                    model_name = table.Column<string>(maxLength: 64, nullable: false),
                    data_id = table.Column<long>(nullable: true),
                    old_data = table.Column<string>(nullable: true),
                    new_data = table.Column<string>(nullable: true),
                    role_id1 = table.Column<long>(nullable: true),
                    role_id2 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_histories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "carriers",
                schema: "txn",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    code = table.Column<string>(maxLength: 64, nullable: false),
                    name = table.Column<string>(maxLength: 64, nullable: false),
                    title = table.Column<string>(maxLength: 64, nullable: false),
                    phone1 = table.Column<string>(maxLength: 16, nullable: true),
                    phone2 = table.Column<string>(maxLength: 16, nullable: true),
                    address = table.Column<string>(maxLength: 256, nullable: true),
                    authorized_person = table.Column<string>(maxLength: 64, nullable: true),
                    authorized_person_phone = table.Column<string>(maxLength: 64, nullable: true),
                    authorized_person_email = table.Column<string>(maxLength: 64, nullable: true),
                    logo = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_carriers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "transactions",
                schema: "txn",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    merchant_id = table.Column<long>(nullable: false),
                    service_id = table.Column<long>(nullable: false),
                    carrier_id = table.Column<long>(nullable: false),
                    msisdn = table.Column<string>(maxLength: 16, nullable: false),
                    amount = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    status = table.Column<int>(nullable: false),
                    charge_date = table.Column<DateTime>(nullable: true),
                    ıtem = table.Column<string>(maxLength: 64, nullable: false),
                    refund_date = table.Column<DateTime>(nullable: true),
                    refund_source = table.Column<string>(maxLength: 64, nullable: true),
                    operator_trans_id = table.Column<string>(maxLength: 128, nullable: true),
                    order_id = table.Column<string>(maxLength: 128, nullable: false),
                    user_ip = table.Column<string>(maxLength: 64, nullable: false),
                    channel = table.Column<string>(maxLength: 16, nullable: false),
                    error = table.Column<string>(maxLength: 64, nullable: true),
                    err_desc = table.Column<string>(maxLength: 256, nullable: true),
                    error_id = table.Column<long>(nullable: true),
                    sub_id = table.Column<long>(nullable: true),
                    guid = table.Column<Guid>(maxLength: 64, nullable: false),
                    param1 = table.Column<string>(maxLength: 128, nullable: true),
                    param2 = table.Column<string>(maxLength: 128, nullable: true),
                    param3 = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_transactions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_roles",
                schema: "panel",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    create_user_id = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<long>(nullable: true),
                    user_id = table.Column<long>(nullable: false),
                    role_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_roles", x => x.id);
                    table.ForeignKey(
                        name: "fk_user_roles_roles_role_id",
                        column: x => x.role_id,
                        principalSchema: "panel",
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ıx_user_roles_role_id",
                schema: "panel",
                table: "user_roles",
                column: "role_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "merchants",
                schema: "merchant");

            migrationBuilder.DropTable(
                name: "reset_passwords",
                schema: "panel");

            migrationBuilder.DropTable(
                name: "role_permissions",
                schema: "panel");

            migrationBuilder.DropTable(
                name: "user_roles",
                schema: "panel");

            migrationBuilder.DropTable(
                name: "users",
                schema: "panel");

            migrationBuilder.DropTable(
                name: "services",
                schema: "service");

            migrationBuilder.DropTable(
                name: "smses",
                schema: "sms");

            migrationBuilder.DropTable(
                name: "subscriptions",
                schema: "sub");

            migrationBuilder.DropTable(
                name: "table_definitions",
                schema: "tracking");

            migrationBuilder.DropTable(
                name: "table_histories",
                schema: "tracking");

            migrationBuilder.DropTable(
                name: "carriers",
                schema: "txn");

            migrationBuilder.DropTable(
                name: "transactions",
                schema: "txn");

            migrationBuilder.DropTable(
                name: "roles",
                schema: "panel");
        }
    }
}
