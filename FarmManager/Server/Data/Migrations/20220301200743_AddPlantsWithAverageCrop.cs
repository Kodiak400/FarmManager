using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class AddPlantsWithAverageCrop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Przenica ozima', 4700)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Przenica jara', 3900)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Żyto', 3247)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Jęczmień ozimy', 4333)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Jeczmień jary', 3087)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Owies', 3070)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Przenżyto ozime', 3813)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Przenżyto jare', 3087)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Kukurydza', 7153)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Gryka', 1353)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Ziemniaki', 26100)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Ziemniaki na chipsy', 37750)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Ziemniaki skrobiowe', 30000)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Buraki cukrowe', 58090)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Marchew pastewna', 40000)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Rzepak', 2597)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Gorczyca', 1577)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Konopia nasiona', 723)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Len włóknisty', 4223)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Słonecznik', 2177)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Tytoń', 2077)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Chmiel', 1187)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Bób', 9467)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Brokuł', 18000)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Brukselka', 15000)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Buraki ćwikłowe', 33867)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Cebula', 24000)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Czosnek', 5250)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Dynia', 41000)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Dynia pastewna', 55000)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Fasola szparagowa', 9333)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Groszek zielony', 5333)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Kalfior', 25367)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Kalarepa', 14567)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Kapusta', 41667)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Koper', 35000000)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Marchew', 38300)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Ogórki', 17000)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Pasternak', 35000)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Papryka czerowan',  14500)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Patison', 20000)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Pietruszka', 16067)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Por', 16167)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Pomidor', 17233)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Rzodkiewka', 15000000)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Seler', 18222)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Szpinak', 12500)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Szparagi', 6500)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Łąki trwałe', 31725)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Pastiwska trwałe', 45343)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Siano łąkowe', 4763)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Brzoskwinie', 6420)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Morel', 4907)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Czereśnie', 5517)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Gruszki', 4260)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Jabłka', 9247)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Śliwski', 4817)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Wiśnie', 5880)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Orzech włoski', 1780)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Agrest', 6220)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Aronia', 5313)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Borówka', 4347)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Maliny', 2950)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Porzeczki czarne', 5500)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Porzeczki kolorowe', 7467)");
            migrationBuilder.Sql("INSERT INTO Plants (Name, AverageCrop) VALUES('Rabarbar', 35000)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
