using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetAvengers.Models;

namespace ProjetAvengers.Models.Orange
{
    public class AvengersContext : DbContext
    {
        public AvengersContext(DbContextOptions<AvengersContext> options)
            : base(options)
        {
        }

        public DbSet<Civils> Civils { get; set; }
        public DbSet<ProjetAvengers.Models.CivilsDTO> CivilsDTO { get; set; }
        public DbSet<Organisation> Organisation { get; set; }
        public DbSet<Coordonnee> Coordonnee { get; set; }
        public DbSet<Membre> Membre { get; set; }
        public DbSet<Super_Hero> Super_Hero { get; set; }
        public DbSet<Super_Vilain> Super_Vilain { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Civils>().ToTable("Civils");
            modelBuilder.Entity<Organisation>().ToTable("Organisation");
            modelBuilder.Entity<Membre>().ToTable("Membre");

        }
    }
}
