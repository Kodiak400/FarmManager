using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class UpdateAnimalModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_TransferReasons_OutcomeReasonId",
                table: "Animals",
                column: "OutcomeReasonId",
                principalTable: "TransferReasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_TransferReasons_OutcomeReasonId",
                table: "Animals",
                column: "OutcomeReasonId",
                principalTable: "TransferReasons",
                principalColumn: "Id");
        }
    }
}
