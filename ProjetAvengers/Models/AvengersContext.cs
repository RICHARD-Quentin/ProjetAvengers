using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<Membre>().ToTable("Membre");

        }
    }
}
