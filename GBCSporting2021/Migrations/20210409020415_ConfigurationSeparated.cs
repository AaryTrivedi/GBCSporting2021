using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GBCSporting2021.Migrations
{
    public partial class ConfigurationSeparated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2021, 4, 8, 22, 4, 14, 766, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2021, 4, 8, 22, 4, 14, 769, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 8, 22, 4, 14, 769, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 8, 22, 4, 14, 769, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 8, 22, 4, 14, 769, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 8, 22, 4, 14, 769, DateTimeKind.Local).AddTicks(6331));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2021, 3, 29, 21, 44, 18, 534, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2021, 3, 29, 21, 44, 18, 535, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 29, 21, 44, 18, 531, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 29, 21, 44, 18, 534, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 29, 21, 44, 18, 534, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 29, 21, 44, 18, 534, DateTimeKind.Local).AddTicks(5919));
        }
    }
}
