using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesSystem.Sales.Data.Migrations
{
    public partial class NewClassClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Client_ClientId",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "Pk_Car",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "cars");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "clients");

            migrationBuilder.RenameColumn(
                name: "Year_of_Manufacture",
                table: "cars",
                newName: "year_of_manufacture");

            migrationBuilder.RenameColumn(
                name: "Registrtion_Date",
                table: "cars",
                newName: "registrtion_date");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_ClientId",
                table: "cars",
                newName: "IX_cars_ClientId");

            migrationBuilder.RenameColumn(
                name: "RegistrationDate",
                table: "clients",
                newName: "registration_date");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "clients",
                newName: "birth_date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "clients",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "clients",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Document",
                table: "clients",
                type: "varchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "registration_date",
                table: "clients",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "birth_date",
                table: "clients",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "pk_car",
                table: "cars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_client",
                table: "clients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_clients_ClientId",
                table: "cars",
                column: "ClientId",
                principalTable: "clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_clients_ClientId",
                table: "cars");

            migrationBuilder.DropPrimaryKey(
                name: "pk_car",
                table: "cars");

            migrationBuilder.DropPrimaryKey(
                name: "pk_client",
                table: "clients");

            migrationBuilder.RenameTable(
                name: "cars",
                newName: "Cars");

            migrationBuilder.RenameTable(
                name: "clients",
                newName: "Client");

            migrationBuilder.RenameColumn(
                name: "year_of_manufacture",
                table: "Cars",
                newName: "Year_of_Manufacture");

            migrationBuilder.RenameColumn(
                name: "registrtion_date",
                table: "Cars",
                newName: "Registrtion_Date");

            migrationBuilder.RenameIndex(
                name: "IX_cars_ClientId",
                table: "Cars",
                newName: "IX_Cars_ClientId");

            migrationBuilder.RenameColumn(
                name: "registration_date",
                table: "Client",
                newName: "RegistrationDate");

            migrationBuilder.RenameColumn(
                name: "birth_date",
                table: "Client",
                newName: "BirthDate");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Document",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "Client",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Client",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddPrimaryKey(
                name: "Pk_Car",
                table: "Cars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Client_ClientId",
                table: "Cars",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
