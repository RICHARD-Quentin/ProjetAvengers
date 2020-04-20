using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetAvengers.Models
{
    public class Liste_sv_crise
    {
        public int Id { get; set; }
        [ForeignKey("Crise")]
        public Crise Id_crise { get; set; }
        public ICollection<Super_Vilain> Id_supervilain { get; set; }

    }
}