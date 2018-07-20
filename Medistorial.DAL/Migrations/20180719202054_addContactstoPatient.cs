using Microsoft.EntityFrameworkCore.Migrations;

namespace Medistorial.DAL.Migrations
{
    public partial class addContactstoPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Contact",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PatientId",
                table: "Contact",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Patients_PatientId",
                table: "Contact",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Patients_PatientId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_PatientId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Contact");
        }
    }
}
