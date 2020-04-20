using ProjetAvengers.Models.Bleu;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models.Vert
{
    public class Mission
    {
        public int Id { get; set; }
        public string Nature { get; set; }
        public string Titre { get; set; }
        public string Itineraire { get; set; }
        public int Gravite { get; set; }
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin { get; set; }
        public Rapport_Mission Rapport_Mission { get; set; }
        public ICollection<Satisfaction> Satisfactions { get; set; }
        public Organisation Organisation { get; set; }
        public Modules Modules { get; set; }
        public Liste_SuperHero_Mission Liste_SuperHero_Mission { get; set; }
        public Liste_SuperVilain_Mission Liste_SuperVilain_Mission { get; set; }
        [ForeignKey("Incident")]
        public Incidents Incidents { get; set; }
    }
}
