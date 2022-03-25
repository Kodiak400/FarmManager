using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class PopulateKozy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('alpejska', 'ALP', 2)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('anglonubijska', 'ANGL-NUB', 2)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('barwna uszlachetniona', 'BARWNA USZL', 2)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('biała uszlachetniona', 'BIAŁA USZL.', 2)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('burska', 'BURSKA', 2)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('gemsfarbige gebirgsziege', 'GEMS', 2)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('inne', 'IN', 2)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('karpacka', 'KRP', 2)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('kazimierzowska', 'KAZ', 2)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('krzyżówki ras kóz', 'MK', 2)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('saaneńska', 'SAAN', 2)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('sandomierska', 'SAND', 2)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('toggenburska', 'TOGG', 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
