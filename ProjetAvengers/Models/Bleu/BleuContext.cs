using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetAvengers.Models;
using ProjetAvengers.Models.Bleu;

namespace ProjetAvengers.Models.Bleu
{
    public class BleuContext : DbContext
    {
        public BleuContext(DbContextOptions<BleuContext> options)
            : base(options)
        {
        }

        public DbSet<Modules> Modules { get; set; }
        public DbSet<Privileges> Privileges { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }



    }
}
