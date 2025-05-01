using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AracKiralamaSatisOtomasyonu.Core.Migrations
{
    /// <inheritdoc />
    public partial class initProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yil = table.Column<int>(type: "int", nullable: false),
                    Kilometre = table.Column<int>(type: "int", nullable: false),
                    YakitTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanzimanTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MevcutDurum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arac_Kategori_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kiralama",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracId = table.Column<int>(type: "int", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GunlukUcret = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kiralama", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kiralama_Arac_AracId",
                        column: x => x.AracId,
                        principalTable: "Arac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kiralama_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Satis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracId = table.Column<int>(type: "int", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    SatisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SatisFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OdemeTipi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Satis_Arac_AracId",
                        column: x => x.AracId,
                        principalTable: "Arac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Satis_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "Id", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "Sedan" },
                    { 2, "SUV" },
                    { 3, "Hatchback" },
                    { 4, "Minivan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arac_KategoriId",
                table: "Arac",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Kiralama_AracId",
                table: "Kiralama",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_Kiralama_MusteriId",
                table: "Kiralama",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Satis_AracId",
                table: "Satis",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_Satis_MusteriId",
                table: "Satis",
                column: "MusteriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kiralama");

            migrationBuilder.DropTable(
                name: "Satis");

            migrationBuilder.DropTable(
                name: "Arac");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "Kategori");
        }
    }
}
