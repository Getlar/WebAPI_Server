using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_Server.Migrations
{
    public partial class defaultSetting7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfArrrival",
                table: "People");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfArrival",
                table: "People",
                nullable: false
               );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfArrival",
                table: "People");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfArrrival",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
