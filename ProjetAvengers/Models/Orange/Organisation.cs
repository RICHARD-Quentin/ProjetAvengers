using ProjetAvengers.Models.Bleu;
using ProjetAvengers.Models.Vert;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjetAvengers.Models
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Telephone_Portable { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date_de_creation { get; set; }
        [Column(TypeName = "date")]
        public DateTime Derniere_modification { get; set; }
        [ForeignKey("CivilsId")]
        public Civils Civils_Id { get; set; }
        public ICollection<Coordonnee> Coordonnees { get; set; }
        public ICollection<Membre> Membres { get; set; }
        public ICollection<Mission> Missions { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public ICollection<Incidents> Incidents { get; set; }

    }
}
