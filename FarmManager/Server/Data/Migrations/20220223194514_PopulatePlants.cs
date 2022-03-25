using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class PopulatePlants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Jęczmień')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Trawy')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Owies')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Ziemniaki')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Rośliny strżaczkowe')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Kukurydza')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Rzepak')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Żyto')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Gorczyca')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Buraki')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Pszenżyto')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Przenica')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Warzywa')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Winorośl')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
