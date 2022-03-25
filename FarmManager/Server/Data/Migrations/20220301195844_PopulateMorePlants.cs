using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class PopulateMorePlants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Przenica ozima,4700')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Przenica jara,3900')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Żyto,3247')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Jęczmień ozimy,4333')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Jeczmień jary,3087')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Owies,3070')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Przenżyto ozime,3813')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Przenżyto jare,3087')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Kukurydza,7153')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Gryka,1353')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Ziemniaki,26100')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Ziemniaki na chipsy,37750')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Ziemniaki skrobiowe,30000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Buraki cukrowe,58090')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Marchew pastewna,40000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Rzepak,2597')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Gorczyca,1577')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Konopia nasiona,723')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Len włóknisty,4223')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Słonecznik,2177')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Tytoń,2077')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Chmiel,1187')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Bób,9467')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Brokuł,18000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Brukselka,15000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Buraki ćwikłowe,33867')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Cebula,24000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Czosnek,5250')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Dynia,41000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Dynia pastewna,55000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Fasola szparagowa,9333')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Groszek zielony,5333')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Kalfior,25367')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Kalarepa,14567')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Kapusta,41667')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Koper,35000000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Marchew,38300')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Ogórki,17000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Pasternak,35000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Papryka czerowan, 14500')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Patison,20000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Pietruszka,16067')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Por,16167')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Pomidor,17233')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Rzodkiewka,15000000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Seler,18222')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Szpinak,12500')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Szparagi,6500')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Łąki trwałe,31725')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Pastiwska trwałe,45343')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Siano łąkowe,4763')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Brzoskwinie,6420')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Morel,4907')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Czereśnie,5517')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Gruszki,4260')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Jabłka,9247')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Śliwski,4817')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Wiśnie,5880')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Orzech włoski,1780')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Agrest,6220')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Aronia,5313')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Borówka,4347')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Maliny,2950')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Porzeczki czarne,5500')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Porzeczki kolorowe,7467')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Rabarbar,35000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Truskawki2913')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Bobik,2200')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Łupin na nasiona,1363')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Wyka na nasiona,1517')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Proso,2250')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Lucerna na zielonkę,42000')");
            migrationBuilder.Sql("INSERT INTO Plants (Name) VALUES('Koniczyna,32000')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Plants");
        }
    }
}
