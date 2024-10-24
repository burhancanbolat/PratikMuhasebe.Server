using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PratikMuhasebe.Server.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Takaslar",
                columns: table => new
                {
                    BelgeNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KaynakMuhasebeKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HedefMuhasebeKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tutar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takaslar", x => x.BelgeNo);
                });

            migrationBuilder.CreateTable(
                name: "Transferler",
                columns: table => new
                {
                    BelgeNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KaynakMuhasebeKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HedefMuhasebeKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tutar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transferler", x => x.BelgeNo);
                });

            migrationBuilder.CreateTable(
                name: "Virmanlar",
                columns: table => new
                {
                    BelgeNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KaynakMuhasebeKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HedefMuhasebeKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tutar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tablo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IslemTarihi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HavaleAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IslemAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Virmanlar", x => x.BelgeNo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Takaslar");

            migrationBuilder.DropTable(
                name: "Transferler");

            migrationBuilder.DropTable(
                name: "Virmanlar");
        }
    }
}
