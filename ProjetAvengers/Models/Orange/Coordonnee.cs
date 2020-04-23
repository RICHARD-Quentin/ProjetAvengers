using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
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
        [JsonIgnore]
        public virtual Civils Civils { get; set; }
        [JsonIgnore]
        public virtual Organisation Organisation { get; set; }

    }
}
