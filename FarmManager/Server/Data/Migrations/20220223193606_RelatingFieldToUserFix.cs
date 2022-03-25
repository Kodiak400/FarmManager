using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class RelatingFieldToUserFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Fields",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fields_ApplicationUserId",
                table: "Fields",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fields_AspNetUsers_ApplicationUserId",
                table: "Fields",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fields_AspNetUsers_ApplicationUserId",
                table: "Fields");

            migrationBuilder.DropIndex(
                name: "IX_Fields_ApplicationUserId",
                table: "Fields");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Fields",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
