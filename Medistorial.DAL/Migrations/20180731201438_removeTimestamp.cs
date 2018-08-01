using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medistorial.DAL.Migrations
{
    public partial class removeTimestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Specialities");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Medics");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Contact");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                table: "Specialities",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Genre",
                table: "Patients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                table: "Patients",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                table: "Medics",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                table: "Contact",
                rowVersion: true,
                nullable: true);
        }
    }
}
