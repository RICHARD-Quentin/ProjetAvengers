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
        public string Titre { get; set; }
        public string Detail_intervention { get; set; }
        public string Vilain_intervention { get; set; }
        public string Nouveau_Civil { get; set; }
        public int MissionId { get; set; }
        [ForeignKey("MissionId")]
        public Mission Mission { get; set; }
        [ForeignKey("ModuleId")]
        public Modules Modules { get; set; }

    }
}
