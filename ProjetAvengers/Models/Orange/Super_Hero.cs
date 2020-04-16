using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models
{
    public class Super_Hero
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string pouvoir { get; set; }
        public string point_faible { get; set; }
        public int score { get; set; }
        [ForeignKey("Identite")]
        public Civils Civils_Id { get; set; }
    }
}
