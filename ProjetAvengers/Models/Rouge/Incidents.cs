using ProjetAvengers.Models.Bleu;
using ProjetAvengers.Models.Vert;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetAvengers.Models
{
	public class Incidents
    {
        public int Id { get; set; }
        public string Nature { get; set; }
        public string Lieu { get; set; }
        public string Description { get; set; }
        public Crise Id_crise { get; set; }
        [ForeignKey("UtilisateurId")]
        public Utilisateur Identite_origine_appel { get; set; }
        public Mission Mission { get; set; }
        [ForeignKey("ModuleId")]
        public Modules Modules { get; set; }
        [ForeignKey("CivilsId")]
        public Civils Civils { get; set; }
        [ForeignKey("OrganisationId")]
        public Organisation Organisation { get; set; }


    }
}