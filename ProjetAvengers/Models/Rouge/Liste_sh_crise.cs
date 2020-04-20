using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetAvengers.Models
{
    public class Liste_sh_crise
    {
        public int Id { get; set; }
        [ForeignKey("Crise")]
        public Crise Id_crise { get; set; }
        public ICollection<Super_Hero> Id_superhero { get; set; }
    }
}
