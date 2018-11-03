using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ArticoliGratis.Migrations
{
    public partial class ModificoNomeTabelle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articolo_Autore_autoreidUtente",
                table: "Articolo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autore",
                table: "Autore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articolo",
                table: "Articolo");

            migrationBuilder.RenameTable(
                name: "Autore",
                newName: "Autori");

            migrationBuilder.RenameTable(
                name: "Articolo",
                newName: "Articoli");

            migrationBuilder.RenameIndex(
                name: "IX_Articolo_autoreidUtente",
                table: "Articoli",
                newName: "IX_Articoli_autoreidUtente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autori",
                table: "Autori",
                column: "idUtente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articoli",
                table: "Articoli",
                column: "idArticolo");

            migrationBuilder.AddForeignKey(
                name: "FK_Articoli_Autori_autoreidUtente",
                table: "Articoli",
                column: "autoreidUtente",
                principalTable: "Autori",
                principalColumn: "idUtente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articoli_Autori_autoreidUtente",
                table: "Articoli");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autori",
                table: "Autori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articoli",
                table: "Articoli");

            migrationBuilder.RenameTable(
                name: "Autori",
                newName: "Autore");

            migrationBuilder.RenameTable(
                name: "Articoli",
                newName: "Articolo");

            migrationBuilder.RenameIndex(
                name: "IX_Articoli_autoreidUtente",
                table: "Articolo",
                newName: "IX_Articolo_autoreidUtente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autore",
                table: "Autore",
                column: "idUtente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articolo",
                table: "Articolo",
                column: "idArticolo");

            migrationBuilder.AddForeignKey(
                name: "FK_Articolo_Autore_autoreidUtente",
                table: "Articolo",
                column: "autoreidUtente",
                principalTable: "Autore",
                principalColumn: "idUtente",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
