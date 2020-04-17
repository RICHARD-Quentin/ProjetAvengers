using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models.Vert
{
    public class Mission
    {
        public int Id { get; set; }
        public ICollection<Rapport_Mission> Rapport_Missions{ get; set; }
        public ICollection<Satisfaction> Satisfactions { get; set; }
        public string Nature { get; set; }
        public string Titre { get; set; }
        public string Itineraire { get; set; }
        public int Gravite { get; set; }
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin { get; set; }
    }
}
