using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class OutcomeReasonIdAllowNullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AspNetUsers_ApplicationUserId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_TransferReasons_OutcomeReasonId",
                table: "Animals");

            migrationBuilder.AlterColumn<int>(
                name: "OutcomeReasonId",
                table: "Animals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Animals",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AspNetUsers_ApplicationUserId",
                table: "Animals",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_TransferReasons_OutcomeReasonId",
                table: "Animals",
                column: "OutcomeReasonId",
                principalTable: "TransferReasons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AspNetUsers_ApplicationUserId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_TransferReasons_OutcomeReasonId",
                table: "Animals");

            migrationBuilder.AlterColumn<int>(
                name: "OutcomeReasonId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Animals",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AspNetUsers_ApplicationUserId",
                table: "Animals",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_TransferReasons_OutcomeReasonId",
                table: "Animals",
                column: "OutcomeReasonId",
                principalTable: "TransferReasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
