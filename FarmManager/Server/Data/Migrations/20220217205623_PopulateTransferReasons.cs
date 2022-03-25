using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class PopulateTransferReasons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TransferReasons (Name, Direction) VALUES('Urodzenie', 'Przychód')");
            migrationBuilder.Sql("INSERT INTO TransferReasons (Name, Direction) VALUES('Zakup', 'Przychód')");
            migrationBuilder.Sql("INSERT INTO TransferReasons (Name, Direction) VALUES('Śmierć', 'Rozchód')");
            migrationBuilder.Sql("INSERT INTO TransferReasons (Name, Direction) VALUES('Sprzedaż', 'Rozchód')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
