using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetAvengers.Models
{
    public class Liste_sh_crise
    {
        public int Id { get; set; }
        [ForeignKey("CriseId")]
        public Crise Id_crise { get; set; }

        [ForeignKey("Liste_Super_Hero_Crise_Id")]
        public ICollection<Super_Hero> Id_superhero { get; set; }
    }
}
