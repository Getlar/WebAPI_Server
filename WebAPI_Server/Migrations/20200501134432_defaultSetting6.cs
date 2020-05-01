using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_Server.Migrations
{
    public partial class defaultSetting6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "People",
                maxLength: 50,
                nullable: false
                );

            migrationBuilder.AddColumn<string>(
                name: "Complaint",
                table: "People",
                maxLength: 200,
                nullable: false
                );

            migrationBuilder.AddColumn<string>(
                name: "SocialSecurityNumber",
                table: "People",
                maxLength: 11,
                nullable: false
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Complaint",
                table: "People");

            migrationBuilder.DropColumn(
                name: "SocialSecurityNumber",
                table: "People");
        }
    }
}
