using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ArticoliGratis.Migrations
{
    public partial class tipoodifioDataDiNascita1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comune",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.DropColumn(
                name: "Regione",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.AddColumn<int>(
                name: "comuneidComune",
                table: "DatiAnagraficiUtenti",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Regioni",
                columns: table => new
                {
                    idRegione = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescrizioneRegione = table.Column<string>(nullable: true),
                    NomeRegione = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regioni", x => x.idRegione);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    idProvincia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescrizioneProvincia = table.Column<string>(nullable: true),
                    NomeProvincia = table.Column<string>(nullable: false),
                    RegioneidRegione = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.idProvincia);
                    table.ForeignKey(
                        name: "FK_Province_Regioni_RegioneidRegione",
                        column: x => x.RegioneidRegione,
                        principalTable: "Regioni",
                        principalColumn: "idRegione",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comuni",
                columns: table => new
                {
                    idComune = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescrizioneComune = table.Column<string>(nullable: true),
                    NomeComune = table.Column<string>(nullable: false),
                    ProvinciaidProvincia = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comuni", x => x.idComune);
                    table.ForeignKey(
                        name: "FK_Comuni_Province_ProvinciaidProvincia",
                        column: x => x.ProvinciaidProvincia,
                        principalTable: "Province",
                        principalColumn: "idProvincia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatiAnagraficiUtenti_comuneidComune",
                table: "DatiAnagraficiUtenti",
                column: "comuneidComune");

            migrationBuilder.CreateIndex(
                name: "IX_Comuni_ProvinciaidProvincia",
                table: "Comuni",
                column: "ProvinciaidProvincia");

            migrationBuilder.CreateIndex(
                name: "IX_Province_RegioneidRegione",
                table: "Province",
                column: "RegioneidRegione");

            migrationBuilder.AddForeignKey(
                name: "FK_DatiAnagraficiUtenti_Comuni_comuneidComune",
                table: "DatiAnagraficiUtenti",
                column: "comuneidComune",
                principalTable: "Comuni",
                principalColumn: "idComune",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatiAnagraficiUtenti_Comuni_comuneidComune",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.DropTable(
                name: "Comuni");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Regioni");

            migrationBuilder.DropIndex(
                name: "IX_DatiAnagraficiUtenti_comuneidComune",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.DropColumn(
                name: "comuneidComune",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.AddColumn<string>(
                name: "Comune",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Provincia",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Regione",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                defaultValue: "");
        }
    }
}
