using ProjetAvengers.Models.Bleu;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetAvengers.Models
{
    public class Litige
    {
        public int Id { get; set; }
        public string Objet { get; set; }
        public string Type_litige { get; set; }
        [ForeignKey("Crises")]
        public Crise Crise { get; set; }
        public Modules Modules { get; set; }
    }
}
