using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class PopulateGrowths : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Growths (Name) VALUES('W trakcie wzrostu')");
            migrationBuilder.Sql("INSERT INTO Growths (Name) VALUES('Gotowe do zbioru')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
