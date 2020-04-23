using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetAvengers.Models
{
    public class Liste_sv_crise
    {
        public int Id { get; set; }
        [ForeignKey("CriseId")]
        public Crise Id_crise { get; set; }

        [ForeignKey("Liste_Super_Vilain_Crise_Id")]
        public ICollection<Super_Vilain> Id_supervilain { get; set; }

    }
}