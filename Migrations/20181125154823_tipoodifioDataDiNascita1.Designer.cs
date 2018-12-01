﻿// <auto-generated />
using ArticoliGratis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ArticoliGratis.Migrations
{
    [DbContext(typeof(ArticoliGratisContext))]
    [Migration("20181125154823_tipoodifioDataDiNascita1")]
    partial class tipoodifioDataDiNascita1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArticoliGratis.Models.Articolo", b =>
                {
                    b.Property<int>("idArticolo")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("autoreidUtente");

                    b.Property<int?>("categoriaidCategoria");

                    b.Property<int?>("metaTagidMetaTag");

                    b.Property<string>("testo");

                    b.Property<string>("titolo");

                    b.HasKey("idArticolo");

                    b.HasIndex("autoreidUtente");

                    b.HasIndex("categoriaidCategoria");

                    b.HasIndex("metaTagidMetaTag");

                    b.ToTable("Articoli");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Categoria", b =>
                {
                    b.Property<int>("idCategoria")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("categoriaPadreidCategoria");

                    b.Property<string>("descrizione");

                    b.Property<int?>("metaTagidMetaTag");

                    b.Property<string>("nome");

                    b.Property<int?>("sezioneidSezione");

                    b.HasKey("idCategoria");

                    b.HasIndex("categoriaPadreidCategoria");

                    b.HasIndex("metaTagidMetaTag");

                    b.HasIndex("sezioneidSezione");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("ArticoliGratis.Models.CategoriaAzienda", b =>
                {
                    b.Property<int>("idCategoriaAzienda")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescrizioneCategoria");

                    b.Property<string>("NomeCategoria")
                        .IsRequired();

                    b.HasKey("idCategoriaAzienda");

                    b.ToTable("CategorieAziende");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Comune", b =>
                {
                    b.Property<int>("idComune")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescrizioneComune");

                    b.Property<string>("NomeComune")
                        .IsRequired();

                    b.Property<int?>("ProvinciaidProvincia");

                    b.HasKey("idComune");

                    b.HasIndex("ProvinciaidProvincia");

                    b.ToTable("Comuni");
                });

            modelBuilder.Entity("ArticoliGratis.Models.DatiAnagraficiUtente", b =>
                {
                    b.Property<int>("idAnagraficiUtente")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cognome")
                        .IsRequired();

                    b.Property<DateTime>("DataDiNascita");

                    b.Property<string>("EmailPersonale")
                        .IsRequired();

                    b.Property<bool>("LiberoProfessionista");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("SitoWebPersonale")
                        .IsRequired();

                    b.Property<string>("TelefonoCellulare")
                        .IsRequired();

                    b.Property<string>("TelefonoFisso")
                        .IsRequired();

                    b.Property<int?>("comuneidComune");

                    b.Property<int?>("lavoroidLavoro");

                    b.Property<int?>("sessoidSesso");

                    b.Property<int?>("settoreidSettore");

                    b.Property<int?>("titolodiStudioidTitoloDiStudio");

                    b.HasKey("idAnagraficiUtente");

                    b.HasIndex("comuneidComune");

                    b.HasIndex("lavoroidLavoro");

                    b.HasIndex("sessoidSesso");

                    b.HasIndex("settoreidSettore");

                    b.HasIndex("titolodiStudioidTitoloDiStudio");

                    b.ToTable("DatiAnagraficiUtenti");
                });

            modelBuilder.Entity("ArticoliGratis.Models.DatiAziendali", b =>
                {
                    b.Property<int>("idDatiAziendali")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Azienda");

                    b.Property<int?>("CategoriaAziendaidCategoriaAzienda");

                    b.Property<string>("DescrizioneAzienda");

                    b.Property<string>("EmailAzienda");

                    b.Property<string>("NomeAzienda");

                    b.HasKey("idDatiAziendali");

                    b.HasIndex("CategoriaAziendaidCategoriaAzienda");

                    b.ToTable("DatiAziende");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Lavoro", b =>
                {
                    b.Property<int>("idLavoro")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescrizioneLavoro");

                    b.Property<string>("NomeLavoro")
                        .IsRequired();

                    b.HasKey("idLavoro");

                    b.ToTable("Lavori");
                });

            modelBuilder.Entity("ArticoliGratis.Models.MetaTag", b =>
                {
                    b.Property<int>("idMetaTag")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<string>("keywords");

                    b.Property<string>("title");

                    b.HasKey("idMetaTag");

                    b.ToTable("MetaTag");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Provincia", b =>
                {
                    b.Property<int>("idProvincia")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescrizioneProvincia");

                    b.Property<string>("NomeProvincia")
                        .IsRequired();

                    b.Property<int?>("RegioneidRegione");

                    b.HasKey("idProvincia");

                    b.HasIndex("RegioneidRegione");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Regione", b =>
                {
                    b.Property<int>("idRegione")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescrizioneRegione");

                    b.Property<string>("NomeRegione")
                        .IsRequired();

                    b.HasKey("idRegione");

                    b.ToTable("Regioni");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Sesso", b =>
                {
                    b.Property<int>("idSesso")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescrizioneSesso");

                    b.Property<string>("NomeSesso")
                        .IsRequired();

                    b.HasKey("idSesso");

                    b.ToTable("Sessi");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Settore", b =>
                {
                    b.Property<int>("idSettore")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescrizioneSettore");

                    b.Property<string>("NomeSettore")
                        .IsRequired();

                    b.HasKey("idSettore");

                    b.ToTable("Settori");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Sezione", b =>
                {
                    b.Property<int>("idSezione")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descrizione");

                    b.Property<int?>("metaTagidMetaTag");

                    b.Property<string>("nome");

                    b.HasKey("idSezione");

                    b.HasIndex("metaTagidMetaTag");

                    b.ToTable("Sezioni");
                });

            modelBuilder.Entity("ArticoliGratis.Models.TitoloDiStudio", b =>
                {
                    b.Property<int>("idTitoloDiStudio")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescrizioneTitolodiStudio");

                    b.Property<string>("NomeTitolodiStudio")
                        .IsRequired();

                    b.HasKey("idTitoloDiStudio");

                    b.ToTable("TitoliDiStudio");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Utente", b =>
                {
                    b.Property<int>("idUtente")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DatiAnagraficiUtnteidAnagraficiUtente");

                    b.Property<int?>("DatiAziendaliidDatiAziendali");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("idUtente");

                    b.HasIndex("DatiAnagraficiUtnteidAnagraficiUtente");

                    b.HasIndex("DatiAziendaliidDatiAziendali");

                    b.ToTable("Utenti");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Articolo", b =>
                {
                    b.HasOne("ArticoliGratis.Models.Utente", "autore")
                        .WithMany()
                        .HasForeignKey("autoreidUtente");

                    b.HasOne("ArticoliGratis.Models.Categoria", "categoria")
                        .WithMany()
                        .HasForeignKey("categoriaidCategoria");

                    b.HasOne("ArticoliGratis.Models.MetaTag", "metaTag")
                        .WithMany()
                        .HasForeignKey("metaTagidMetaTag");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Categoria", b =>
                {
                    b.HasOne("ArticoliGratis.Models.Categoria", "categoriaPadre")
                        .WithMany()
                        .HasForeignKey("categoriaPadreidCategoria");

                    b.HasOne("ArticoliGratis.Models.MetaTag", "metaTag")
                        .WithMany()
                        .HasForeignKey("metaTagidMetaTag");

                    b.HasOne("ArticoliGratis.Models.Sezione", "sezione")
                        .WithMany()
                        .HasForeignKey("sezioneidSezione");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Comune", b =>
                {
                    b.HasOne("ArticoliGratis.Models.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaidProvincia");
                });

            modelBuilder.Entity("ArticoliGratis.Models.DatiAnagraficiUtente", b =>
                {
                    b.HasOne("ArticoliGratis.Models.Comune", "comune")
                        .WithMany()
                        .HasForeignKey("comuneidComune");

                    b.HasOne("ArticoliGratis.Models.Lavoro", "lavoro")
                        .WithMany()
                        .HasForeignKey("lavoroidLavoro");

                    b.HasOne("ArticoliGratis.Models.Sesso", "sesso")
                        .WithMany()
                        .HasForeignKey("sessoidSesso");

                    b.HasOne("ArticoliGratis.Models.Settore", "settore")
                        .WithMany()
                        .HasForeignKey("settoreidSettore");

                    b.HasOne("ArticoliGratis.Models.TitoloDiStudio", "titolodiStudio")
                        .WithMany()
                        .HasForeignKey("titolodiStudioidTitoloDiStudio");
                });

            modelBuilder.Entity("ArticoliGratis.Models.DatiAziendali", b =>
                {
                    b.HasOne("ArticoliGratis.Models.CategoriaAzienda", "CategoriaAzienda")
                        .WithMany()
                        .HasForeignKey("CategoriaAziendaidCategoriaAzienda");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Provincia", b =>
                {
                    b.HasOne("ArticoliGratis.Models.Regione", "Regione")
                        .WithMany()
                        .HasForeignKey("RegioneidRegione");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Sezione", b =>
                {
                    b.HasOne("ArticoliGratis.Models.MetaTag", "metaTag")
                        .WithMany()
                        .HasForeignKey("metaTagidMetaTag");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Utente", b =>
                {
                    b.HasOne("ArticoliGratis.Models.DatiAnagraficiUtente", "DatiAnagraficiUtnte")
                        .WithMany()
                        .HasForeignKey("DatiAnagraficiUtnteidAnagraficiUtente");

                    b.HasOne("ArticoliGratis.Models.DatiAziendali", "DatiAziendali")
                        .WithMany()
                        .HasForeignKey("DatiAziendaliidDatiAziendali");
                });
#pragma warning restore 612, 618
        }
    }
}
