using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models.Bleu
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Pseudo { get; set; }
        public string Mail { get; set; }
        public string Mot_de_passe { get; set; }
        [ForeignKey("Civil")]
        public Civils Civils { get; set; }
        [ForeignKey("Orga")]
        public Organisation Organisation { get; set; }
        public Privileges Privileges { get; set; }
        public Incidents Incidents { get; set; }
    }
}
