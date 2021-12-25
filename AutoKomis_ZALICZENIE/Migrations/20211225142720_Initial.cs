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
                    TytOglo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypNadwozia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<int>(type: "int", nullable: false),
                    Cena = table.Column<double>(type: "float", nullable: false),
                    RokProd = table.Column<int>(type: "int", nullable: false),
                    RodzPaliwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Przebieg = table.Column<long>(type: "bigint", nullable: false),
                    Kategoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zdjecie = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
