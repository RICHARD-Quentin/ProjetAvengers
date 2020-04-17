using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetAvengers.Models.Vert;
using ProjetAvengers.Models;

namespace ProjetAvengers.Data
{
    public class VertContext : DbContext
    {
        public VertContext (DbContextOptions<VertContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetAvengers.Models.Vert.Mission> Mission { get; set; }

        public DbSet<ProjetAvengers.Models.Vert.Rapport_Mission> Rapport_Mission { get; set; }

        public DbSet<ProjetAvengers.Models.Vert.Satisfaction> Satisfaction { get; set; }

        public DbSet<ProjetAvengers.Models.Vert.Liste_SuperHero_Mission> Liste_SuperHero_Mission { get; set; }

        public DbSet<ProjetAvengers.Models.Super_Vilain> Super_Vilain { get; set; }

        public DbSet<ProjetAvengers.Models.Vert.Liste_SuperVilain_Mission> Liste_SuperVilain_Mission { get; set; }
    }
}
