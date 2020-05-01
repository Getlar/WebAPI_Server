using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_Server.Migrations
{
    public partial class UpperCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "People",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "People",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "dateOfBirth",
                table: "People",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "People",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "People",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "People",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "People",
                newName: "dateOfBirth");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "People",
                newName: "id");
        }
    }
}
