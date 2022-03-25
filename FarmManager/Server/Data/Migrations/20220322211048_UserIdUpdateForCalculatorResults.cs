using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class UserIdUpdateForCalculatorResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "CropsCalculatorResults",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CropName",
                table: "CropsCalculatorResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AnimalsCalculatorResults",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "CropsCalculatorResults");

            migrationBuilder.DropColumn(
                name: "CropName",
                table: "CropsCalculatorResults");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AnimalsCalculatorResults");
        }
    }
}
