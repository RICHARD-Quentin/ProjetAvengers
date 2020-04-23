﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetAvengers.Models;

namespace ProjetAvengers.Migrations
{
    [DbContext(typeof(AvengersContext))]
    partial class AvengersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetAvengers.Models.Bleu.Modules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom_module")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Bleu.Privileges", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ecriture")
                        .HasColumnType("bit");

                    b.Property<bool>("Lecture")
                        .HasColumnType("bit");

                    b.Property<bool>("Modification")
                        .HasColumnType("bit");

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Suppression")
                        .HasColumnType("bit");

                    b.Property<int?>("UtilisateurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.HasIndex("UtilisateurId")
                        .IsUnique()
                        .HasFilter("[UtilisateurId] IS NOT NULL");

                    b.ToTable("Privileges");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Bleu.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CivilsId")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mot_de_passe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<string>("Pseudo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CivilsId")
                        .IsUnique()
                        .HasFilter("[CivilsId] IS NOT NULL");

                    b.HasIndex("OrganisationId")
                        .IsUnique()
                        .HasFilter("[OrganisationId] IS NOT NULL");

                    b.ToTable("Utilisateur");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Civils", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Civilite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date_de_deces")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date_de_naissance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Derniere_modification")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<bool>("Est_Principale")
                        .HasColumnType("bit");

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

                    b.HasKey("Id");

                    b.HasIndex("CivilsId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Coordonnee");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Crise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Declanche_Litige")
                        .HasColumnType("bit");

                    b.Property<int?>("IncidentId")
                        .HasColumnType("int");

                    b.Property<string>("Incident_majeur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IncidentId")
                        .IsUnique()
                        .HasFilter("[IncidentId] IS NOT NULL");

                    b.HasIndex("ModuleId");

                    b.ToTable("Crise");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Incidents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CivilsId")
                        .HasColumnType("int");

                    b.Property<string>("Lieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int?>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<int?>("UtilisateurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CivilsId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("OrganisationId");

                    b.HasIndex("UtilisateurId")
                        .IsUnique()
                        .HasFilter("[UtilisateurId] IS NOT NULL");

                    b.ToTable("Incidents");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Liste_sh_crise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CriseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CriseId")
                        .IsUnique()
                        .HasFilter("[CriseId] IS NOT NULL");

                    b.ToTable("Liste_sh_crise");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Liste_sv_crise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CriseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CriseId")
                        .IsUnique()
                        .HasFilter("[CriseId] IS NOT NULL");

                    b.ToTable("Liste_sv_crise");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Litige", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CriseId")
                        .HasColumnType("int");

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Objet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type_litige")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CriseId")
                        .IsUnique()
                        .HasFilter("[CriseId] IS NOT NULL");

                    b.HasIndex("ModuleId");

                    b.ToTable("Litige");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Membre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CivilsId")
                        .HasColumnType("int");

                    b.Property<int?>("OrganisationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CivilsId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Membre");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Organisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CivilsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_de_creation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Derniere_modification")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone_Portable")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CivilsId")
                        .IsUnique()
                        .HasFilter("[CivilsId] IS NOT NULL");

                    b.ToTable("Organisation");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Super_Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CivilsId")
                        .HasColumnType("int");

                    b.Property<int?>("Liste_Super_Hero_Crise_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Liste_Super_Hero_Mission_Id")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Point_faible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pouvoir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CivilsId")
                        .IsUnique()
                        .HasFilter("[CivilsId] IS NOT NULL");

                    b.HasIndex("Liste_Super_Hero_Crise_Id");

                    b.HasIndex("Liste_Super_Hero_Mission_Id");

                    b.ToTable("Super_Hero");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Super_Vilain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CivilsId")
                        .HasColumnType("int");

                    b.Property<int?>("Liste_Super_Vilain_Crise_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Liste_Super_Vilain_Mission_Id")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Point_faible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pouvoir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CivilsId")
                        .IsUnique()
                        .HasFilter("[CivilsId] IS NOT NULL");

                    b.HasIndex("Liste_Super_Vilain_Crise_Id");

                    b.HasIndex("Liste_Super_Vilain_Mission_Id");

                    b.ToTable("Super_Vilain");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Vert.Liste_SuperHero_Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MissionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MissionId")
                        .IsUnique()
                        .HasFilter("[MissionId] IS NOT NULL");

                    b.ToTable("Liste_SuperHero_Mission");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Vert.Liste_SuperVilain_Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MissionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MissionId")
                        .IsUnique()
                        .HasFilter("[MissionId] IS NOT NULL");

                    b.ToTable("Liste_SuperVilain_Mission");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Vert.Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_debut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_fin")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gravite")
                        .HasColumnType("int");

                    b.Property<int?>("IncidentsId")
                        .HasColumnType("int");

                    b.Property<string>("Itineraire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Nature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IncidentsId")
                        .IsUnique()
                        .HasFilter("[IncidentsId] IS NOT NULL");

                    b.HasIndex("ModuleId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Mission");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Vert.Rapport_Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detail_intervention")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MissionId")
                        .HasColumnType("int");

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Nouveau_Civil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vilain_intervention")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MissionId")
                        .IsUnique()
                        .HasFilter("[MissionId] IS NOT NULL");

                    b.HasIndex("ModuleId");

                    b.ToTable("Rapport_Mission");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Vert.Satisfaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cible")
                        .HasColumnType("int");

                    b.Property<string>("Commentaire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fichiers")
                        .HasColumnType("int");

                    b.Property<int>("Format")
                        .HasColumnType("int");

                    b.Property<int?>("MissionId")
                        .HasColumnType("int");

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int>("Note")
                        .HasColumnType("int");

                    b.Property<int>("Type_litige")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MissionId");

                    b.HasIndex("ModuleId");

                    b.ToTable("Satisfaction");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Bleu.Privileges", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Bleu.Modules", "Modules")
                        .WithMany("Privileges")
                        .HasForeignKey("ModuleId");

                    b.HasOne("ProjetAvengers.Models.Bleu.Utilisateur", "Utilisateur")
                        .WithOne("Privileges")
                        .HasForeignKey("ProjetAvengers.Models.Bleu.Privileges", "UtilisateurId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Bleu.Utilisateur", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Civils", "Civils")
                        .WithOne("Utilisateur")
                        .HasForeignKey("ProjetAvengers.Models.Bleu.Utilisateur", "CivilsId");

                    b.HasOne("ProjetAvengers.Models.Organisation", "Organisation")
                        .WithOne("Utilisateur")
                        .HasForeignKey("ProjetAvengers.Models.Bleu.Utilisateur", "OrganisationId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Coordonnee", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Civils", "Civils_Id")
                        .WithMany("Coordonnees")
                        .HasForeignKey("CivilsId");

                    b.HasOne("ProjetAvengers.Models.Organisation", "Organisation_Id")
                        .WithMany("Coordonnees")
                        .HasForeignKey("OrganisationId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Crise", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Incidents", "Incidents")
                        .WithOne("Id_crise")
                        .HasForeignKey("ProjetAvengers.Models.Crise", "IncidentId");

                    b.HasOne("ProjetAvengers.Models.Bleu.Modules", "Modules")
                        .WithMany("Crises")
                        .HasForeignKey("ModuleId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Incidents", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Civils", "Civils")
                        .WithMany("Incidents")
                        .HasForeignKey("CivilsId");

                    b.HasOne("ProjetAvengers.Models.Bleu.Modules", "Modules")
                        .WithMany("Incidents")
                        .HasForeignKey("ModuleId");

                    b.HasOne("ProjetAvengers.Models.Organisation", "Organisation")
                        .WithMany("Incidents")
                        .HasForeignKey("OrganisationId");

                    b.HasOne("ProjetAvengers.Models.Bleu.Utilisateur", "Identite_origine_appel")
                        .WithOne("Incidents")
                        .HasForeignKey("ProjetAvengers.Models.Incidents", "UtilisateurId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Liste_sh_crise", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Crise", "Id_crise")
                        .WithOne("Liste_Sh_Crise")
                        .HasForeignKey("ProjetAvengers.Models.Liste_sh_crise", "CriseId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Liste_sv_crise", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Crise", "Id_crise")
                        .WithOne("Liste_Sv_Crise")
                        .HasForeignKey("ProjetAvengers.Models.Liste_sv_crise", "CriseId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Litige", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Crise", "Crise")
                        .WithOne("Litige")
                        .HasForeignKey("ProjetAvengers.Models.Litige", "CriseId");

                    b.HasOne("ProjetAvengers.Models.Bleu.Modules", "Modules")
                        .WithMany("Litiges")
                        .HasForeignKey("ModuleId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Membre", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Civils", "Civils")
                        .WithMany("Membres")
                        .HasForeignKey("CivilsId");

                    b.HasOne("ProjetAvengers.Models.Organisation", "Organisation")
                        .WithMany("Membres")
                        .HasForeignKey("OrganisationId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Organisation", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Civils", "Civils_Id")
                        .WithOne("Dirigeant")
                        .HasForeignKey("ProjetAvengers.Models.Organisation", "CivilsId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Super_Hero", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Civils", "Civils_Id")
                        .WithOne("Super_Hero")
                        .HasForeignKey("ProjetAvengers.Models.Super_Hero", "CivilsId");

                    b.HasOne("ProjetAvengers.Models.Liste_sh_crise", "Liste_SuperVilain_Crise")
                        .WithMany("Id_superhero")
                        .HasForeignKey("Liste_Super_Hero_Crise_Id");

                    b.HasOne("ProjetAvengers.Models.Vert.Liste_SuperHero_Mission", "Liste_SuperHero_Missions")
                        .WithMany("Super_Heros")
                        .HasForeignKey("Liste_Super_Hero_Mission_Id");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Super_Vilain", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Civils", "Civils_Id")
                        .WithOne("Super_Vilain")
                        .HasForeignKey("ProjetAvengers.Models.Super_Vilain", "CivilsId");

                    b.HasOne("ProjetAvengers.Models.Liste_sv_crise", "Liste_SuperVilain_Crise")
                        .WithMany("Id_supervilain")
                        .HasForeignKey("Liste_Super_Vilain_Crise_Id");

                    b.HasOne("ProjetAvengers.Models.Vert.Liste_SuperVilain_Mission", "Liste_SuperVilain_Missions")
                        .WithMany("Super_Vilains")
                        .HasForeignKey("Liste_Super_Vilain_Mission_Id");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Vert.Liste_SuperHero_Mission", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Vert.Mission", "Missions")
                        .WithOne("Liste_SuperHero_Mission")
                        .HasForeignKey("ProjetAvengers.Models.Vert.Liste_SuperHero_Mission", "MissionId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Vert.Liste_SuperVilain_Mission", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Vert.Mission", "Missions")
                        .WithOne("Liste_SuperVilain_Mission")
                        .HasForeignKey("ProjetAvengers.Models.Vert.Liste_SuperVilain_Mission", "MissionId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Vert.Mission", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Incidents", "Incidents")
                        .WithOne("Mission")
                        .HasForeignKey("ProjetAvengers.Models.Vert.Mission", "IncidentsId");

                    b.HasOne("ProjetAvengers.Models.Bleu.Modules", "Modules")
                        .WithMany("Missions")
                        .HasForeignKey("ModuleId");

                    b.HasOne("ProjetAvengers.Models.Organisation", "Organisation")
                        .WithMany("Missions")
                        .HasForeignKey("OrganisationId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Vert.Rapport_Mission", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Vert.Mission", "Mission")
                        .WithOne("Rapport_Mission")
                        .HasForeignKey("ProjetAvengers.Models.Vert.Rapport_Mission", "MissionId");

                    b.HasOne("ProjetAvengers.Models.Bleu.Modules", "Modules")
                        .WithMany("Rapport_Missions")
                        .HasForeignKey("ModuleId");
                });

            modelBuilder.Entity("ProjetAvengers.Models.Vert.Satisfaction", b =>
                {
                    b.HasOne("ProjetAvengers.Models.Vert.Mission", "Mission")
                        .WithMany("Satisfactions")
                        .HasForeignKey("MissionId");

                    b.HasOne("ProjetAvengers.Models.Bleu.Modules", "Modules")
                        .WithMany("Satisfactions")
                        .HasForeignKey("ModuleId");
                });
#pragma warning restore 612, 618
        }
    }
}
