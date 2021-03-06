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
    [Migration("20181103160706_ModificoNomeTabelle")]
    partial class ModificoNomeTabelle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArticoliGratis.Models.Modelli+Articolo", b =>
                {
                    b.Property<int>("idArticolo")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("autoreidUtente");

                    b.Property<string>("testo");

                    b.Property<string>("titolo");

                    b.HasKey("idArticolo");

                    b.HasIndex("autoreidUtente");

                    b.ToTable("Articoli");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Modelli+Utente", b =>
                {
                    b.Property<int>("idUtente")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cognome");

                    b.Property<string>("Nome");

                    b.HasKey("idUtente");

                    b.ToTable("Autori");
                });

            modelBuilder.Entity("ArticoliGratis.Models.Modelli+Articolo", b =>
                {
                    b.HasOne("ArticoliGratis.Models.Modelli+Utente", "autore")
                        .WithMany()
                        .HasForeignKey("autoreidUtente");
                });
#pragma warning restore 612, 618
        }
    }
}
