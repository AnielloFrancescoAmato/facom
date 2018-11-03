using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ArticoliGratis.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autore",
                columns: table => new
                {
                    idUtente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cognome = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autore", x => x.idUtente);
                });

            migrationBuilder.CreateTable(
                name: "Articolo",
                columns: table => new
                {
                    idArticolo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    autoreidUtente = table.Column<int>(nullable: true),
                    testo = table.Column<string>(nullable: true),
                    titolo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articolo", x => x.idArticolo);
                    table.ForeignKey(
                        name: "FK_Articolo_Autore_autoreidUtente",
                        column: x => x.autoreidUtente,
                        principalTable: "Autore",
                        principalColumn: "idUtente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articolo_autoreidUtente",
                table: "Articolo",
                column: "autoreidUtente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articolo");

            migrationBuilder.DropTable(
                name: "Autore");
        }
    }
}
