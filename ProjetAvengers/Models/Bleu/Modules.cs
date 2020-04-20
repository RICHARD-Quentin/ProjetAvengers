using ProjetAvengers.Models.Vert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models.Bleu
{
    public class Modules
    {
        public int Id { get; set; }
        public string Nom_module { get; set; }

        public ICollection<Privileges> Privileges { get; set; }
        public ICollection<Mission> Missions { get; set; }
        public ICollection<Rapport_Mission> Rapport_Missions { get; set; }
        public ICollection<Satisfaction> Satisfactions { get; set; }
        public ICollection<Litige> Litiges { get; set; }
        public ICollection<Crise> Crises { get; set; }
        public ICollection<Incidents> Incidents { get; set; }

    }
}
