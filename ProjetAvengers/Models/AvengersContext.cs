using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using ProjetAvengers.Models;
using ProjetAvengers.Models.Bleu;
using ProjetAvengers.Models.Vert;

namespace ProjetAvengers.Models
{ 
    public class AvengersContext : DbContext
    {
        public AvengersContext(DbContextOptions<AvengersContext> options)
            : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Civils> Civils { get; set; }
        public DbSet<Organisation> Organisation { get; set; }
        public DbSet<Coordonnee> Coordonnee { get; set; }
        public DbSet<Membre> Membre { get; set; }
        public DbSet<Super_Hero> Super_Hero { get; set; }
        public DbSet<Super_Vilain> Super_Vilain { get; set; }
        public DbSet<Modules> Modules { get; set; }
        public DbSet<Privileges> Privileges { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }
        public DbSet<Incidents> Incidents { get; set; }
        public DbSet<Crise> Crise { get; set; }
        public DbSet<Litige> Litige { get; set; }
        public DbSet<Liste_sh_crise> Liste_sh_crise { get; set; }
        public DbSet<Liste_sv_crise> Liste_sv_crise { get; set; }
        public DbSet<Mission> Mission { get; set; }
        public DbSet<Rapport_Mission> Rapport_Mission { get; set; }
        public DbSet<Satisfaction> Satisfaction { get; set; }
        public DbSet<Liste_SuperHero_Mission> Liste_SuperHero_Mission { get; set; }
        public DbSet<Liste_SuperVilain_Mission> Liste_SuperVilain_Mission { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Civils>().ToTable("Civils");
            modelBuilder.Entity<Organisation>().ToTable("Organisation");
            modelBuilder.Entity<Coordonnee>().ToTable("Coordonnee");
            modelBuilder.Entity<Membre>().ToTable("Membre");
            modelBuilder.Entity<Super_Hero>().ToTable("Super_Hero");
            modelBuilder.Entity<Super_Vilain>().ToTable("Super_Vilain");
            modelBuilder.Entity<Modules>().ToTable("Modules");
            modelBuilder.Entity<Privileges>().ToTable("Privileges");
            modelBuilder.Entity<Utilisateur>().ToTable("Utilisateur");
            modelBuilder.Entity<Incidents>().ToTable("Incidents");
            modelBuilder.Entity<Crise>().ToTable("Crise");
            modelBuilder.Entity<Litige>().ToTable("Litige");
            modelBuilder.Entity<Liste_sh_crise>().ToTable("Liste_sh_crise");
            modelBuilder.Entity<Liste_sv_crise>().ToTable("Liste_sv_crise");
            modelBuilder.Entity<Mission>().ToTable("Mission");
            modelBuilder.Entity<Rapport_Mission>().ToTable("Rapport_Mission");
            modelBuilder.Entity<Satisfaction>().ToTable("Satisfaction");
            modelBuilder.Entity<Liste_SuperHero_Mission>().ToTable("Liste_SuperHero_Mission");
            modelBuilder.Entity<Liste_SuperVilain_Mission>().ToTable("Liste_SuperVilain_Mission");

            modelBuilder.Entity<Civils>()
                .HasMany(c => c.Coordonnees)
                .WithOne(c => c.Civils)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Civils>()
                .HasMany(c => c.Membres)
                .WithOne(m => m.Civils)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Civils>()
                .HasOne(c => c.Dirigeant)
                .WithOne(o => o.Civils_Id)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Civils>()
                .HasOne(c => c.Super_Hero)
                .WithOne(h => h.Civils_Id)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Civils>()
                .HasOne(c => c.Super_Vilain)
                .WithOne(v => v.Civils_Id)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Mission>()
                .HasOne(m => m.Incidents)
                .WithOne(m => m.Mission)
                .HasForeignKey<Mission>(m => m.IncidentsId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Rapport_Mission>()
                .HasOne(r => r.Mission)
                .WithOne(m => m.Rapport_Mission)
                .HasForeignKey<Rapport_Mission>(r => r.MissionId)
                 .OnDelete(DeleteBehavior.Cascade);
            ;


        }
    }
}
