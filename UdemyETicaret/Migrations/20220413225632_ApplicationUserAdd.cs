using Microsoft.EntityFrameworkCore.Migrations;

namespace UdemyETicaret.Migrations
{
    public partial class ApplicationUserAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserCity",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserDistrict",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserPostCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserSurname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserCity",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserDistrict",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserPostCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserSurname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
