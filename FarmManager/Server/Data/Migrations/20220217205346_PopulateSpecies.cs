using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class PopulateSpecies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Species (Name) VALUES ('Bydło')");
            migrationBuilder.Sql("INSERT INTO Species (Name) VALUES ('Koza')");
            migrationBuilder.Sql("INSERT INTO Species (Name) VALUES ('Owca')");
            migrationBuilder.Sql("INSERT INTO Species (Name) VALUES ('Koń')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
