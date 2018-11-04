using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ArticoliGratis.Migrations
{
    public partial class AggiuntoUtenteArticolo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articoli_Autori_autoreidUtente",
                table: "Articoli");

            migrationBuilder.DropTable(
                name: "Autori");

            migrationBuilder.AddColumn<int>(
                name: "categoriaidCategoria",
                table: "Articoli",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "metaTagidMetaTag",
                table: "Articoli",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategorieAziende",
                columns: table => new
                {
                    idCategoriaAzienda = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescrizioneCategoria = table.Column<string>(nullable: true),
                    NomeCategoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieAziende", x => x.idCategoriaAzienda);
                });

            migrationBuilder.CreateTable(
                name: "Lavori",
                columns: table => new
                {
                    idLavoro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescrizioneLavoro = table.Column<string>(nullable: true),
                    NomeLavoro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lavori", x => x.idLavoro);
                });

            migrationBuilder.CreateTable(
                name: "MetaTag",
                columns: table => new
                {
                    idMetaTag = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(nullable: true),
                    keywords = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaTag", x => x.idMetaTag);
                });

            migrationBuilder.CreateTable(
                name: "Sessi",
                columns: table => new
                {
                    idSesso = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescrizioneSesso = table.Column<string>(nullable: true),
                    NomeSesso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessi", x => x.idSesso);
                });

            migrationBuilder.CreateTable(
                name: "Settori",
                columns: table => new
                {
                    idSettore = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescrizioneSettore = table.Column<string>(nullable: true),
                    NomeSettore = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settori", x => x.idSettore);
                });

            migrationBuilder.CreateTable(
                name: "TitoliDiStudio",
                columns: table => new
                {
                    idTitoloDiStudio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescrizioneTitolodiStudio = table.Column<string>(nullable: true),
                    NomeTitolodiStudio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitoliDiStudio", x => x.idTitoloDiStudio);
                });

            migrationBuilder.CreateTable(
                name: "DatiAziende",
                columns: table => new
                {
                    idDatiAziendali = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Azienda = table.Column<bool>(nullable: false),
                    CategoriaAziendaidCategoriaAzienda = table.Column<int>(nullable: true),
                    DescrizioneAzienda = table.Column<string>(nullable: true),
                    EmailAzienda = table.Column<string>(nullable: true),
                    NomeAzienda = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatiAziende", x => x.idDatiAziendali);
                    table.ForeignKey(
                        name: "FK_DatiAziende_CategorieAziende_CategoriaAziendaidCategoriaAzienda",
                        column: x => x.CategoriaAziendaidCategoriaAzienda,
                        principalTable: "CategorieAziende",
                        principalColumn: "idCategoriaAzienda",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sezioni",
                columns: table => new
                {
                    idSezione = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    descrizione = table.Column<string>(nullable: true),
                    metaTagidMetaTag = table.Column<int>(nullable: true),
                    nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sezioni", x => x.idSezione);
                    table.ForeignKey(
                        name: "FK_Sezioni_MetaTag_metaTagidMetaTag",
                        column: x => x.metaTagidMetaTag,
                        principalTable: "MetaTag",
                        principalColumn: "idMetaTag",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DatiAnagraficiUtenti",
                columns: table => new
                {
                    idAnagraficiUtente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cognome = table.Column<string>(nullable: true),
                    Comune = table.Column<string>(nullable: true),
                    DataDiNascita = table.Column<int>(nullable: false),
                    EmailPersonale = table.Column<string>(nullable: true),
                    LiberoProfessionista = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Provincia = table.Column<string>(nullable: true),
                    Regione = table.Column<string>(nullable: true),
                    SitoWebPersonale = table.Column<string>(nullable: true),
                    TelefonoCellulare = table.Column<string>(nullable: true),
                    TelefonoFisso = table.Column<string>(nullable: true),
                    lavoroidLavoro = table.Column<int>(nullable: true),
                    sessoidSesso = table.Column<int>(nullable: true),
                    settoreidSettore = table.Column<int>(nullable: true),
                    titolodiStudioidTitoloDiStudio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatiAnagraficiUtenti", x => x.idAnagraficiUtente);
                    table.ForeignKey(
                        name: "FK_DatiAnagraficiUtenti_Lavori_lavoroidLavoro",
                        column: x => x.lavoroidLavoro,
                        principalTable: "Lavori",
                        principalColumn: "idLavoro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DatiAnagraficiUtenti_Sessi_sessoidSesso",
                        column: x => x.sessoidSesso,
                        principalTable: "Sessi",
                        principalColumn: "idSesso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DatiAnagraficiUtenti_Settori_settoreidSettore",
                        column: x => x.settoreidSettore,
                        principalTable: "Settori",
                        principalColumn: "idSettore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DatiAnagraficiUtenti_TitoliDiStudio_titolodiStudioidTitoloDiStudio",
                        column: x => x.titolodiStudioidTitoloDiStudio,
                        principalTable: "TitoliDiStudio",
                        principalColumn: "idTitoloDiStudio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    idCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoriaPadreidCategoria = table.Column<int>(nullable: true),
                    descrizione = table.Column<string>(nullable: true),
                    metaTagidMetaTag = table.Column<int>(nullable: true),
                    nome = table.Column<string>(nullable: true),
                    sezioneidSezione = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.idCategoria);
                    table.ForeignKey(
                        name: "FK_Categorie_Categorie_categoriaPadreidCategoria",
                        column: x => x.categoriaPadreidCategoria,
                        principalTable: "Categorie",
                        principalColumn: "idCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categorie_MetaTag_metaTagidMetaTag",
                        column: x => x.metaTagidMetaTag,
                        principalTable: "MetaTag",
                        principalColumn: "idMetaTag",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categorie_Sezioni_sezioneidSezione",
                        column: x => x.sezioneidSezione,
                        principalTable: "Sezioni",
                        principalColumn: "idSezione",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Utenti",
                columns: table => new
                {
                    idUtente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatiAnagraficiUtnteidAnagraficiUtente = table.Column<int>(nullable: true),
                    DatiAziendaliidDatiAziendali = table.Column<int>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utenti", x => x.idUtente);
                    table.ForeignKey(
                        name: "FK_Utenti_DatiAnagraficiUtenti_DatiAnagraficiUtnteidAnagraficiUtente",
                        column: x => x.DatiAnagraficiUtnteidAnagraficiUtente,
                        principalTable: "DatiAnagraficiUtenti",
                        principalColumn: "idAnagraficiUtente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utenti_DatiAziende_DatiAziendaliidDatiAziendali",
                        column: x => x.DatiAziendaliidDatiAziendali,
                        principalTable: "DatiAziende",
                        principalColumn: "idDatiAziendali",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articoli_categoriaidCategoria",
                table: "Articoli",
                column: "categoriaidCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Articoli_metaTagidMetaTag",
                table: "Articoli",
                column: "metaTagidMetaTag");

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_categoriaPadreidCategoria",
                table: "Categorie",
                column: "categoriaPadreidCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_metaTagidMetaTag",
                table: "Categorie",
                column: "metaTagidMetaTag");

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_sezioneidSezione",
                table: "Categorie",
                column: "sezioneidSezione");

            migrationBuilder.CreateIndex(
                name: "IX_DatiAnagraficiUtenti_lavoroidLavoro",
                table: "DatiAnagraficiUtenti",
                column: "lavoroidLavoro");

            migrationBuilder.CreateIndex(
                name: "IX_DatiAnagraficiUtenti_sessoidSesso",
                table: "DatiAnagraficiUtenti",
                column: "sessoidSesso");

            migrationBuilder.CreateIndex(
                name: "IX_DatiAnagraficiUtenti_settoreidSettore",
                table: "DatiAnagraficiUtenti",
                column: "settoreidSettore");

            migrationBuilder.CreateIndex(
                name: "IX_DatiAnagraficiUtenti_titolodiStudioidTitoloDiStudio",
                table: "DatiAnagraficiUtenti",
                column: "titolodiStudioidTitoloDiStudio");

            migrationBuilder.CreateIndex(
                name: "IX_DatiAziende_CategoriaAziendaidCategoriaAzienda",
                table: "DatiAziende",
                column: "CategoriaAziendaidCategoriaAzienda");

            migrationBuilder.CreateIndex(
                name: "IX_Sezioni_metaTagidMetaTag",
                table: "Sezioni",
                column: "metaTagidMetaTag");

            migrationBuilder.CreateIndex(
                name: "IX_Utenti_DatiAnagraficiUtnteidAnagraficiUtente",
                table: "Utenti",
                column: "DatiAnagraficiUtnteidAnagraficiUtente");

            migrationBuilder.CreateIndex(
                name: "IX_Utenti_DatiAziendaliidDatiAziendali",
                table: "Utenti",
                column: "DatiAziendaliidDatiAziendali");

            migrationBuilder.AddForeignKey(
                name: "FK_Articoli_Utenti_autoreidUtente",
                table: "Articoli",
                column: "autoreidUtente",
                principalTable: "Utenti",
                principalColumn: "idUtente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Articoli_Categorie_categoriaidCategoria",
                table: "Articoli",
                column: "categoriaidCategoria",
                principalTable: "Categorie",
                principalColumn: "idCategoria",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Articoli_MetaTag_metaTagidMetaTag",
                table: "Articoli",
                column: "metaTagidMetaTag",
                principalTable: "MetaTag",
                principalColumn: "idMetaTag",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articoli_Utenti_autoreidUtente",
                table: "Articoli");

            migrationBuilder.DropForeignKey(
                name: "FK_Articoli_Categorie_categoriaidCategoria",
                table: "Articoli");

            migrationBuilder.DropForeignKey(
                name: "FK_Articoli_MetaTag_metaTagidMetaTag",
                table: "Articoli");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Utenti");

            migrationBuilder.DropTable(
                name: "Sezioni");

            migrationBuilder.DropTable(
                name: "DatiAnagraficiUtenti");

            migrationBuilder.DropTable(
                name: "DatiAziende");

            migrationBuilder.DropTable(
                name: "MetaTag");

            migrationBuilder.DropTable(
                name: "Lavori");

            migrationBuilder.DropTable(
                name: "Sessi");

            migrationBuilder.DropTable(
                name: "Settori");

            migrationBuilder.DropTable(
                name: "TitoliDiStudio");

            migrationBuilder.DropTable(
                name: "CategorieAziende");

            migrationBuilder.DropIndex(
                name: "IX_Articoli_categoriaidCategoria",
                table: "Articoli");

            migrationBuilder.DropIndex(
                name: "IX_Articoli_metaTagidMetaTag",
                table: "Articoli");

            migrationBuilder.DropColumn(
                name: "categoriaidCategoria",
                table: "Articoli");

            migrationBuilder.DropColumn(
                name: "metaTagidMetaTag",
                table: "Articoli");

            migrationBuilder.CreateTable(
                name: "Autori",
                columns: table => new
                {
                    idUtente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cognome = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autori", x => x.idUtente);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Articoli_Autori_autoreidUtente",
                table: "Articoli",
                column: "autoreidUtente",
                principalTable: "Autori",
                principalColumn: "idUtente",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
