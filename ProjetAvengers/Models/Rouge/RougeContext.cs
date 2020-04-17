using Microsoft.EntityFrameworkCore;
using ProjetAnengers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models.Rouge
{
        public class RougeContext : DbContext
        {

    
            public RougeContext(DbContextOptions<RougeContext> options)
                : base(options)
            {

            }

            public DbSet<Incidents> Incidents { get; set; }
            public DbSet<Crise> Crise { get; set; }
            public DbSet<Litige> Litige { get; set; }
            public DbSet<Liste_sh_crise> Liste_sh_crise  { get; set; }
            public DbSet<Liste_sv_crise> Liste_sv_crise { get; set; }
    }
}