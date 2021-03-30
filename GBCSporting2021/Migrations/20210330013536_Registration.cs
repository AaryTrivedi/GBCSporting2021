using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GBCSporting2021.Migrations
{
    public partial class Registration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2021, 3, 29, 21, 35, 36, 40, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2021, 3, 29, 21, 35, 36, 40, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 29, 21, 35, 36, 37, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 29, 21, 35, 36, 40, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 29, 21, 35, 36, 40, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 29, 21, 35, 36, 40, DateTimeKind.Local).AddTicks(4104));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2021, 2, 25, 17, 4, 3, 395, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2021, 2, 25, 17, 4, 3, 395, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 25, 17, 4, 3, 392, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 25, 17, 4, 3, 395, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 25, 17, 4, 3, 395, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 25, 17, 4, 3, 395, DateTimeKind.Local).AddTicks(4063));
        }
    }
}
