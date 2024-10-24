using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PratikMuhasebe.Server.Migrations.MikroDbV16Test2
{
    /// <inheritdoc />
    public partial class newtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BanExternalProgramId",
                table: "SORUMLULUK_MERKEZLERI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanExternalProgramType",
                table: "SORUMLULUK_MERKEZLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanHash",
                table: "SORUMLULUK_MERKEZLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanMainProgramNo",
                table: "SORUMLULUK_MERKEZLERI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanMenuNo",
                table: "SORUMLULUK_MERKEZLERI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial1",
                table: "SORUMLULUK_MERKEZLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial2",
                table: "SORUMLULUK_MERKEZLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial3",
                table: "SORUMLULUK_MERKEZLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanVersionNo",
                table: "SORUMLULUK_MERKEZLERI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanExternalProgramId",
                table: "MUHASEBE_HESAP_PLANI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanExternalProgramType",
                table: "MUHASEBE_HESAP_PLANI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanHash",
                table: "MUHASEBE_HESAP_PLANI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanMainProgramNo",
                table: "MUHASEBE_HESAP_PLANI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanMenuNo",
                table: "MUHASEBE_HESAP_PLANI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial1",
                table: "MUHASEBE_HESAP_PLANI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial2",
                table: "MUHASEBE_HESAP_PLANI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial3",
                table: "MUHASEBE_HESAP_PLANI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanVersionNo",
                table: "MUHASEBE_HESAP_PLANI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanExternalProgramId",
                table: "MASRAF_HESAPLARI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanExternalProgramType",
                table: "MASRAF_HESAPLARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanHash",
                table: "MASRAF_HESAPLARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanMainProgramNo",
                table: "MASRAF_HESAPLARI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanMenuNo",
                table: "MASRAF_HESAPLARI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial1",
                table: "MASRAF_HESAPLARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial2",
                table: "MASRAF_HESAPLARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial3",
                table: "MASRAF_HESAPLARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanVersionNo",
                table: "MASRAF_HESAPLARI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanExternalProgramId",
                table: "HIZMET_HESAPLARI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanExternalProgramType",
                table: "HIZMET_HESAPLARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanHash",
                table: "HIZMET_HESAPLARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanMainProgramNo",
                table: "HIZMET_HESAPLARI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanMenuNo",
                table: "HIZMET_HESAPLARI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial1",
                table: "HIZMET_HESAPLARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial2",
                table: "HIZMET_HESAPLARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial3",
                table: "HIZMET_HESAPLARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanVersionNo",
                table: "HIZMET_HESAPLARI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanExternalProgramId",
                table: "EVRAK_ACIKLAMALARI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanExternalProgramType",
                table: "EVRAK_ACIKLAMALARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanHash",
                table: "EVRAK_ACIKLAMALARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanMainProgramNo",
                table: "EVRAK_ACIKLAMALARI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanMenuNo",
                table: "EVRAK_ACIKLAMALARI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial1",
                table: "EVRAK_ACIKLAMALARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial2",
                table: "EVRAK_ACIKLAMALARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial3",
                table: "EVRAK_ACIKLAMALARI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanVersionNo",
                table: "EVRAK_ACIKLAMALARI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanExternalProgramId",
                table: "CARI_HESAPLAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanExternalProgramType",
                table: "CARI_HESAPLAR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanHash",
                table: "CARI_HESAPLAR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanMainProgramNo",
                table: "CARI_HESAPLAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanMenuNo",
                table: "CARI_HESAPLAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial1",
                table: "CARI_HESAPLAR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial2",
                table: "CARI_HESAPLAR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial3",
                table: "CARI_HESAPLAR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanVersionNo",
                table: "CARI_HESAPLAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanExternalProgramId",
                table: "CARI_HESAP_HAREKETLERI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanExternalProgramType",
                table: "CARI_HESAP_HAREKETLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanHash",
                table: "CARI_HESAP_HAREKETLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanMainProgramNo",
                table: "CARI_HESAP_HAREKETLERI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanMenuNo",
                table: "CARI_HESAP_HAREKETLERI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial1",
                table: "CARI_HESAP_HAREKETLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial2",
                table: "CARI_HESAP_HAREKETLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial3",
                table: "CARI_HESAP_HAREKETLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanVersionNo",
                table: "CARI_HESAP_HAREKETLERI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanExternalProgramId",
                table: "CARI_HESAP_ADRESLERI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanExternalProgramType",
                table: "CARI_HESAP_ADRESLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanHash",
                table: "CARI_HESAP_ADRESLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanMainProgramNo",
                table: "CARI_HESAP_ADRESLERI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanMenuNo",
                table: "CARI_HESAP_ADRESLERI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial1",
                table: "CARI_HESAP_ADRESLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial2",
                table: "CARI_HESAP_ADRESLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial3",
                table: "CARI_HESAP_ADRESLERI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanVersionNo",
                table: "CARI_HESAP_ADRESLERI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanExternalProgramId",
                table: "BANKALAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanExternalProgramType",
                table: "BANKALAR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanHash",
                table: "BANKALAR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanMainProgramNo",
                table: "BANKALAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanMenuNo",
                table: "BANKALAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial1",
                table: "BANKALAR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial2",
                table: "BANKALAR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BanMikroSpecial3",
                table: "BANKALAR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanVersionNo",
                table: "BANKALAR",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BanExternalProgramId",
                table: "SORUMLULUK_MERKEZLERI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramType",
                table: "SORUMLULUK_MERKEZLERI");

            migrationBuilder.DropColumn(
                name: "BanHash",
                table: "SORUMLULUK_MERKEZLERI");

            migrationBuilder.DropColumn(
                name: "BanMainProgramNo",
                table: "SORUMLULUK_MERKEZLERI");

            migrationBuilder.DropColumn(
                name: "BanMenuNo",
                table: "SORUMLULUK_MERKEZLERI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial1",
                table: "SORUMLULUK_MERKEZLERI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial2",
                table: "SORUMLULUK_MERKEZLERI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial3",
                table: "SORUMLULUK_MERKEZLERI");

            migrationBuilder.DropColumn(
                name: "BanVersionNo",
                table: "SORUMLULUK_MERKEZLERI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramId",
                table: "MUHASEBE_HESAP_PLANI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramType",
                table: "MUHASEBE_HESAP_PLANI");

            migrationBuilder.DropColumn(
                name: "BanHash",
                table: "MUHASEBE_HESAP_PLANI");

            migrationBuilder.DropColumn(
                name: "BanMainProgramNo",
                table: "MUHASEBE_HESAP_PLANI");

            migrationBuilder.DropColumn(
                name: "BanMenuNo",
                table: "MUHASEBE_HESAP_PLANI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial1",
                table: "MUHASEBE_HESAP_PLANI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial2",
                table: "MUHASEBE_HESAP_PLANI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial3",
                table: "MUHASEBE_HESAP_PLANI");

            migrationBuilder.DropColumn(
                name: "BanVersionNo",
                table: "MUHASEBE_HESAP_PLANI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramId",
                table: "MASRAF_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramType",
                table: "MASRAF_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanHash",
                table: "MASRAF_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanMainProgramNo",
                table: "MASRAF_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanMenuNo",
                table: "MASRAF_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial1",
                table: "MASRAF_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial2",
                table: "MASRAF_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial3",
                table: "MASRAF_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanVersionNo",
                table: "MASRAF_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramId",
                table: "HIZMET_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramType",
                table: "HIZMET_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanHash",
                table: "HIZMET_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanMainProgramNo",
                table: "HIZMET_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanMenuNo",
                table: "HIZMET_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial1",
                table: "HIZMET_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial2",
                table: "HIZMET_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial3",
                table: "HIZMET_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanVersionNo",
                table: "HIZMET_HESAPLARI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramId",
                table: "EVRAK_ACIKLAMALARI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramType",
                table: "EVRAK_ACIKLAMALARI");

            migrationBuilder.DropColumn(
                name: "BanHash",
                table: "EVRAK_ACIKLAMALARI");

            migrationBuilder.DropColumn(
                name: "BanMainProgramNo",
                table: "EVRAK_ACIKLAMALARI");

            migrationBuilder.DropColumn(
                name: "BanMenuNo",
                table: "EVRAK_ACIKLAMALARI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial1",
                table: "EVRAK_ACIKLAMALARI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial2",
                table: "EVRAK_ACIKLAMALARI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial3",
                table: "EVRAK_ACIKLAMALARI");

            migrationBuilder.DropColumn(
                name: "BanVersionNo",
                table: "EVRAK_ACIKLAMALARI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramId",
                table: "CARI_HESAPLAR");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramType",
                table: "CARI_HESAPLAR");

            migrationBuilder.DropColumn(
                name: "BanHash",
                table: "CARI_HESAPLAR");

            migrationBuilder.DropColumn(
                name: "BanMainProgramNo",
                table: "CARI_HESAPLAR");

            migrationBuilder.DropColumn(
                name: "BanMenuNo",
                table: "CARI_HESAPLAR");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial1",
                table: "CARI_HESAPLAR");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial2",
                table: "CARI_HESAPLAR");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial3",
                table: "CARI_HESAPLAR");

            migrationBuilder.DropColumn(
                name: "BanVersionNo",
                table: "CARI_HESAPLAR");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramId",
                table: "CARI_HESAP_HAREKETLERI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramType",
                table: "CARI_HESAP_HAREKETLERI");

            migrationBuilder.DropColumn(
                name: "BanHash",
                table: "CARI_HESAP_HAREKETLERI");

            migrationBuilder.DropColumn(
                name: "BanMainProgramNo",
                table: "CARI_HESAP_HAREKETLERI");

            migrationBuilder.DropColumn(
                name: "BanMenuNo",
                table: "CARI_HESAP_HAREKETLERI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial1",
                table: "CARI_HESAP_HAREKETLERI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial2",
                table: "CARI_HESAP_HAREKETLERI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial3",
                table: "CARI_HESAP_HAREKETLERI");

            migrationBuilder.DropColumn(
                name: "BanVersionNo",
                table: "CARI_HESAP_HAREKETLERI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramId",
                table: "CARI_HESAP_ADRESLERI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramType",
                table: "CARI_HESAP_ADRESLERI");

            migrationBuilder.DropColumn(
                name: "BanHash",
                table: "CARI_HESAP_ADRESLERI");

            migrationBuilder.DropColumn(
                name: "BanMainProgramNo",
                table: "CARI_HESAP_ADRESLERI");

            migrationBuilder.DropColumn(
                name: "BanMenuNo",
                table: "CARI_HESAP_ADRESLERI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial1",
                table: "CARI_HESAP_ADRESLERI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial2",
                table: "CARI_HESAP_ADRESLERI");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial3",
                table: "CARI_HESAP_ADRESLERI");

            migrationBuilder.DropColumn(
                name: "BanVersionNo",
                table: "CARI_HESAP_ADRESLERI");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramId",
                table: "BANKALAR");

            migrationBuilder.DropColumn(
                name: "BanExternalProgramType",
                table: "BANKALAR");

            migrationBuilder.DropColumn(
                name: "BanHash",
                table: "BANKALAR");

            migrationBuilder.DropColumn(
                name: "BanMainProgramNo",
                table: "BANKALAR");

            migrationBuilder.DropColumn(
                name: "BanMenuNo",
                table: "BANKALAR");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial1",
                table: "BANKALAR");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial2",
                table: "BANKALAR");

            migrationBuilder.DropColumn(
                name: "BanMikroSpecial3",
                table: "BANKALAR");

            migrationBuilder.DropColumn(
                name: "BanVersionNo",
                table: "BANKALAR");
        }
    }
}
