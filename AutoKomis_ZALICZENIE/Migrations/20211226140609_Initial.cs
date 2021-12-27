using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoKomis_ZALICZENIE.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pojazdy",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TytOglo = table.Column<string>(type: "varchar(100)", nullable: false),
                    TypNadwozia = table.Column<string>(type: "varchar(20)", nullable: false),
                    Marka = table.Column<string>(type: "varchar(20)", nullable: false),
                    Model = table.Column<string>(type: "varchar(30)", nullable: false),
                    Cena = table.Column<double>(type: "float", nullable: false),
                    RokProd = table.Column<int>(type: "int", nullable: false),
                    RodzPaliwa = table.Column<string>(type: "varchar(20)", nullable: false),
                    Przebieg = table.Column<long>(type: "bigint", nullable: false),
                    PojSil = table.Column<int>(type: "bigint", nullable: false),
                    Kategoria = table.Column<int>(type: "int", nullable: false),
                    Opis = table.Column<string>(type: "varchar(max)", nullable: false),
                    Zdjecie = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pojazdy", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pojazdy");
        }
    }
}
