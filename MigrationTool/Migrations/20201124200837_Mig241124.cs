using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTool.Migrations
{
    public partial class Mig241124 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "guid",
                schema: "txn",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "order_id",
                schema: "txn",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "param1",
                schema: "txn",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "param2",
                schema: "txn",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "param3",
                schema: "txn",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "refund_source",
                schema: "txn",
                table: "transactions");

            migrationBuilder.AddColumn<string>(
                name: "merchant_order",
                schema: "txn",
                table: "transactions",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "refund_reason",
                schema: "txn",
                table: "transactions",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "tx_ıd",
                schema: "txn",
                table: "transactions",
                maxLength: 64,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "value1",
                schema: "txn",
                table: "transactions",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "value2",
                schema: "txn",
                table: "transactions",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "value3",
                schema: "txn",
                table: "transactions",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "cancel_date",
                schema: "sub",
                table: "subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cancel_reason",
                schema: "sub",
                table: "subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "carrier_sub_id",
                schema: "sub",
                table: "subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "channel",
                schema: "sub",
                table: "subscriptions",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "item",
                schema: "sub",
                table: "subscriptions",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "merchant_order",
                schema: "sub",
                table: "subscriptions",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "renewal_count",
                schema: "sub",
                table: "subscriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "renewal_date",
                schema: "sub",
                table: "subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "status",
                schema: "sub",
                table: "subscriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "subs_date",
                schema: "sub",
                table: "subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "subs_type",
                schema: "sub",
                table: "subscriptions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "merchant_order",
                schema: "txn",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "refund_reason",
                schema: "txn",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "tx_ıd",
                schema: "txn",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "value1",
                schema: "txn",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "value2",
                schema: "txn",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "value3",
                schema: "txn",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "cancel_date",
                schema: "sub",
                table: "subscriptions");

            migrationBuilder.DropColumn(
                name: "cancel_reason",
                schema: "sub",
                table: "subscriptions");

            migrationBuilder.DropColumn(
                name: "carrier_sub_id",
                schema: "sub",
                table: "subscriptions");

            migrationBuilder.DropColumn(
                name: "channel",
                schema: "sub",
                table: "subscriptions");

            migrationBuilder.DropColumn(
                name: "item",
                schema: "sub",
                table: "subscriptions");

            migrationBuilder.DropColumn(
                name: "merchant_order",
                schema: "sub",
                table: "subscriptions");

            migrationBuilder.DropColumn(
                name: "renewal_count",
                schema: "sub",
                table: "subscriptions");

            migrationBuilder.DropColumn(
                name: "renewal_date",
                schema: "sub",
                table: "subscriptions");

            migrationBuilder.DropColumn(
                name: "status",
                schema: "sub",
                table: "subscriptions");

            migrationBuilder.DropColumn(
                name: "subs_date",
                schema: "sub",
                table: "subscriptions");

            migrationBuilder.DropColumn(
                name: "subs_type",
                schema: "sub",
                table: "subscriptions");

            migrationBuilder.AddColumn<Guid>(
                name: "guid",
                schema: "txn",
                table: "transactions",
                type: "uuid",
                maxLength: 64,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "order_id",
                schema: "txn",
                table: "transactions",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "param1",
                schema: "txn",
                table: "transactions",
                type: "character varying(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "param2",
                schema: "txn",
                table: "transactions",
                type: "character varying(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "param3",
                schema: "txn",
                table: "transactions",
                type: "character varying(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "refund_source",
                schema: "txn",
                table: "transactions",
                type: "character varying(64)",
                maxLength: 64,
                nullable: true);
        }
    }
}
