using Microsoft.EntityFrameworkCore.Migrations;

namespace Medistorial.DAL.Migrations
{
    public partial class addContacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medics_Contact_ContactId",
                table: "Medics");

            migrationBuilder.DropIndex(
                name: "IX_Medics_ContactId",
                table: "Medics");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Medics");

            migrationBuilder.AddColumn<int>(
                name: "MedicId",
                table: "Contact",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_MedicId",
                table: "Contact",
                column: "MedicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Medics_MedicId",
                table: "Contact",
                column: "MedicId",
                principalTable: "Medics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Medics_MedicId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_MedicId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "MedicId",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Medics",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medics_ContactId",
                table: "Medics",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medics_Contact_ContactId",
                table: "Medics",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
