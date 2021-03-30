using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GBCSporting2021.Migrations
{
    public partial class RegistrationTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registration_Customers_CustomerId",
                table: "Registration");

            migrationBuilder.DropForeignKey(
                name: "FK_Registration_Products_ProductId",
                table: "Registration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registration",
                table: "Registration");

            migrationBuilder.RenameTable(
                name: "Registration",
                newName: "Registrations");

            migrationBuilder.RenameIndex(
                name: "IX_Registration_ProductId",
                table: "Registrations",
                newName: "IX_Registrations_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Registration_CustomerId",
                table: "Registrations",
                newName: "IX_Registrations_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registrations",
                table: "Registrations",
                column: "RegistrationId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Customers_CustomerId",
                table: "Registrations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Products_ProductId",
                table: "Registrations",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Customers_CustomerId",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Products_ProductId",
                table: "Registrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registrations",
                table: "Registrations");

            migrationBuilder.RenameTable(
                name: "Registrations",
                newName: "Registration");

            migrationBuilder.RenameIndex(
                name: "IX_Registrations_ProductId",
                table: "Registration",
                newName: "IX_Registration_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Registrations_CustomerId",
                table: "Registration",
                newName: "IX_Registration_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registration",
                table: "Registration",
                column: "RegistrationId");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2021, 3, 29, 21, 37, 50, 155, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2021, 3, 29, 21, 37, 50, 156, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 29, 21, 37, 50, 153, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 29, 21, 37, 50, 155, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 29, 21, 37, 50, 155, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 29, 21, 37, 50, 155, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_Customers_CustomerId",
                table: "Registration",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_Products_ProductId",
                table: "Registration",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
