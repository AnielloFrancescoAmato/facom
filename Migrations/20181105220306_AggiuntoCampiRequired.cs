using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ArticoliGratis.Migrations
{
    public partial class AggiuntoCampiRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatiAnagraficiUtenti_Lavori_lavoroidLavoro",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.DropForeignKey(
                name: "FK_DatiAnagraficiUtenti_Sessi_sessoidSesso",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.DropForeignKey(
                name: "FK_DatiAnagraficiUtenti_Settori_settoreidSettore",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.DropForeignKey(
                name: "FK_DatiAnagraficiUtenti_TitoliDiStudio_titolodiStudioidTitoloDiStudio",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.AlterColumn<string>(
                name: "NomeSesso",
                table: "Sessi",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeLavoro",
                table: "Lavori",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "titolodiStudioidTitoloDiStudio",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "settoreidSettore",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "sessoidSesso",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "lavoroidLavoro",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoFisso",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoCellulare",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SitoWebPersonale",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Regione",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Provincia",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailPersonale",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comune",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cognome",
                table: "DatiAnagraficiUtenti",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DatiAnagraficiUtenti_Lavori_lavoroidLavoro",
                table: "DatiAnagraficiUtenti",
                column: "lavoroidLavoro",
                principalTable: "Lavori",
                principalColumn: "idLavoro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatiAnagraficiUtenti_Sessi_sessoidSesso",
                table: "DatiAnagraficiUtenti",
                column: "sessoidSesso",
                principalTable: "Sessi",
                principalColumn: "idSesso",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatiAnagraficiUtenti_Settori_settoreidSettore",
                table: "DatiAnagraficiUtenti",
                column: "settoreidSettore",
                principalTable: "Settori",
                principalColumn: "idSettore",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatiAnagraficiUtenti_TitoliDiStudio_titolodiStudioidTitoloDiStudio",
                table: "DatiAnagraficiUtenti",
                column: "titolodiStudioidTitoloDiStudio",
                principalTable: "TitoliDiStudio",
                principalColumn: "idTitoloDiStudio",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatiAnagraficiUtenti_Lavori_lavoroidLavoro",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.DropForeignKey(
                name: "FK_DatiAnagraficiUtenti_Sessi_sessoidSesso",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.DropForeignKey(
                name: "FK_DatiAnagraficiUtenti_Settori_settoreidSettore",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.DropForeignKey(
                name: "FK_DatiAnagraficiUtenti_TitoliDiStudio_titolodiStudioidTitoloDiStudio",
                table: "DatiAnagraficiUtenti");

            migrationBuilder.AlterColumn<string>(
                name: "NomeSesso",
                table: "Sessi",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NomeLavoro",
                table: "Lavori",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "titolodiStudioidTitoloDiStudio",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "settoreidSettore",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "sessoidSesso",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "lavoroidLavoro",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoFisso",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoCellulare",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "SitoWebPersonale",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Regione",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Provincia",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EmailPersonale",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Comune",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Cognome",
                table: "DatiAnagraficiUtenti",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_DatiAnagraficiUtenti_Lavori_lavoroidLavoro",
                table: "DatiAnagraficiUtenti",
                column: "lavoroidLavoro",
                principalTable: "Lavori",
                principalColumn: "idLavoro",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DatiAnagraficiUtenti_Sessi_sessoidSesso",
                table: "DatiAnagraficiUtenti",
                column: "sessoidSesso",
                principalTable: "Sessi",
                principalColumn: "idSesso",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DatiAnagraficiUtenti_Settori_settoreidSettore",
                table: "DatiAnagraficiUtenti",
                column: "settoreidSettore",
                principalTable: "Settori",
                principalColumn: "idSettore",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DatiAnagraficiUtenti_TitoliDiStudio_titolodiStudioidTitoloDiStudio",
                table: "DatiAnagraficiUtenti",
                column: "titolodiStudioidTitoloDiStudio",
                principalTable: "TitoliDiStudio",
                principalColumn: "idTitoloDiStudio",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
