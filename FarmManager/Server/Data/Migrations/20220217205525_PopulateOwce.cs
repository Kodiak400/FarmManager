using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class PopulateOwce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('kent', 'KENT', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('krzyżówki z rasami mięsnymi', 'MM', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('krzyżówki z rasami plennymi', 'MS', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('lacaune', 'LAC', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('leine', 'LEINE', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('lincoln', 'LINC', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('linia  BWP/75', 'BWP/75', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('linia BCP', 'BCP', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('linia marynocharolaise', 'MPCH', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('Linia mięsna w typie dorset', 'LM.DOR', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('linia SCP', 'SCP', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('merynofin Mf-40', 'Mf-40', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('merynos boorola', 'BOOR', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('merynos niemiecki', 'MN', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('merynos polski', 'MP', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('merynos polski barwny', 'MPB', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('merynos polski barwny', 'MPB', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('merynos polski w starym typie', 'MST', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('odmiana owcy berrichon', 'LMBER', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('olkuska', 'OLK', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('owca  żelaźnieńska', 'ŻEL', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('owca fińska', 'FIN', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('owca fryzyjska', 'FRYZ', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('owca mleczna 05', 'LM05', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('owca plenna mięsna 08', 'LPM08', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('owca plenna 09', 'LP09', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('owca plenno - wełnista 04', 'LPW04', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('owca romanowska', 'ROM', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('owca uhruska', 'UHR', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('polska owca górska', 'POG', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('polska owca górska barwna', 'POGB', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('polska owca nizinna', 'PON', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('polska owca pogórza', 'PPG', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('pomorska', 'POM', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('pozostałe polskie owce długowełniste', 'POD-IN', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('roztoczańska', 'ROZT', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('shropshire', 'SHROP', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('skudde', 'SKUD', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('suffolk', 'SUF', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('świniarka', 'SWIN', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('teksel', 'TX', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('valaška', 'VAL', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('wielkopolska', 'WLKP', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('wrober', 'WROBER', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('wrzosówka', 'WRZOS', 3)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('żelaźnieńska mięsna', 'ŻOM', 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
