using ProjetAvengers.Models.Bleu;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models.Vert
{
    public class Rapport_Mission
    {
        public int Id { get; set; }
        public string Detail_intervention { get; set; }
        public string Vilain_intervention { get; set; }
        public string Nouveau_Civil { get; set; }
        [ForeignKey("Mission_Incident")]
        public Mission Mission { get; set; }
        public Modules Modules { get; set; }

    }
}
