using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Server.Data.Migrations
{
    public partial class PopulateBydlo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('abondance', 'AB', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('angus czarny', 'AN', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('angus czerwony', 'AR', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('aubrac', 'AU', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('ayrshire', 'AY', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('bawół (Bubalus bubalis)', 'BF', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('beefmaster', 'BM', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('belgian blue', 'BB', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('bizon (Bison bison)', 'BI', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('blonde d`aquitaine', 'BD', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('braford', 'BO', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('brahman', 'BR', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('brangus', 'BN', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('brown swiss', 'BS', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('bydło białogrzbiete', 'BG', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('charolaise', 'CH', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('chianina', 'CA', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('dexter', 'DR', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('europejskie bydło czerwone', 'RE', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('galloway', 'GA', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('gasconne', 'GS', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('gelbvieh', 'GV', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('groninger blaarkop', 'GR', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('guernsey', 'GU', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('hereford', 'HH', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('highland cattle', 'HI', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('inne', 'IN', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('jersey', 'JE', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('krzyżówka bez ras mięsnych', 'MS', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('krzyżówka z rasami mięsnymi', 'MM', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('lakenvelder', 'LV', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('limousine', 'LM', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('longhorn', 'LO', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('luing', 'LU', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('maine-anjou', 'MA', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('marchigiana', 'MR', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('montbeliarde', 'MO', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('murray-grey', 'MG', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('normandy', 'NO', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('norweskie bydło czerwone', 'NR', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('parthenaise', 'PT', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('piemontese (piemont)', 'PI', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('pinzgau', 'PZ', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('polska czarno-biała', 'ZB', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('polska czerwona', 'RP', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('polska czerwono-biała', 'ZR', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('polska holsztyńska-fryzyjska odmiana czerwono biała', 'RW', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('polska holsztyńsko-fryzyjska odmiana czarno-biała', 'HO', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('romagnola', 'RN', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('rubia gallega', 'RG', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('sahiwa', 'SW', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('salers', 'SL', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('santa gertrudis', 'SG', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('shorthorn', 'SH', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('simentaler', 'SM', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('south devon', 'SD', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('speckle park', 'SP', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('szwedzkie bydło czerwono-białe', 'SR', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('tarentaise', 'TA', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('tyrol grey', 'AL', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('uckermärker', 'UK', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('wagyu', 'WA', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('welsh black', 'WB', 1)");
            migrationBuilder.Sql("INSERT INTO Breeds (Name, Symbol, SpeciesId) VALUES('węgierskie bydło stepowe', 'WS', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
