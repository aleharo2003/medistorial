using Microsoft.EntityFrameworkCore.Migrations;

namespace Medistorial.Data.Migrations
{
    public partial class patientName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "mdhPatient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mdhPatient",
                table: "mdhPatient",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_mdhPatient",
                table: "mdhPatient");

            migrationBuilder.RenameTable(
                name: "mdhPatient",
                newName: "Patients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "Id");
        }
    }
}
