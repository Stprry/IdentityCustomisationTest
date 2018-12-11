using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityCustomisationTest.Data.Migrations
{
    public partial class ModifiedPropertyWithImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "Property");

            migrationBuilder.AddColumn<string>(
                name: "MainImagePath",
                table: "Property",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImagePath",
                table: "Property");

            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "Property",
                nullable: true);
        }
    }
}
