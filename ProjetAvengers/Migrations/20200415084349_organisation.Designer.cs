﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetAvengers.Models;

namespace ProjetAvengers.Migrations
{
    [DbContext(typeof(AvengersContext))]
    [Migration("20200415084349_organisation")]
    partial class organisation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetAvengers.Models.Civils", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Civilite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_de_deces")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_de_naissance")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Derniere_modification")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nationalite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone_portable")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Civils");
                });

            modelBuilder.Entity("ProjetAvengers.Models.CivilsDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Civilite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CivilsDTO");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Coordonnee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CivilsId")
                        .HasColumnType("int");

                    b.Property<int>("Code_Postal")
                        .HasColumnType("int");

                    b.Property<int>("Numero_de_voie")
                        .HasColumnType("int");

                    b.Property<int?>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<string>("Pays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone_fixe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("est_Principale")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CivilsId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Coordonnee");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Organisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_de_creation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Derniere_modification")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dirigeant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone_Portable")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organisation");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Coordonnee", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Civils", "Civils")
                        .WithMany("Coordonnees")
                        .HasForeignKey("CivilsId");

                    b.HasOne("ProjetAvengers.Models.Organisation", "Organisation")
                        .WithMany("Coordonnees")
                        .HasForeignKey("OrganisationId");
                });
#pragma warning restore 612, 618
        }
    }
}
