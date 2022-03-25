using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class PopulateSexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Sexes (Name) VALUES('Samiec')");
            migrationBuilder.Sql("INSERT INTO Sexes (Name) VALUES('Samica')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
