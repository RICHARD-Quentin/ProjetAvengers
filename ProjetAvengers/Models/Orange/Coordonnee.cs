using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models
{
    public class Coordonnee
    {
        public int Id { get; set; }
        public int Numero_de_voie { get; set; }
        public string Adresse { get; set; }
        public int Code_Postal { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string Telephone_fixe { get; set; }
        public bool Est_Principale { get; set; }
        public Civils Civils_Id { get; set; }
        public Organisation Organisation_Id { get; set; }
    }
}
