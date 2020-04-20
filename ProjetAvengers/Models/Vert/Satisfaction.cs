using ProjetAvengers.Models.Bleu;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models.Vert
{
    public class Satisfaction
    {
        public int Id { get; set; }
        public int Cible { get; set; }
        public int Format { get; set; }
        public int Note { get; set; }
        public int Fichiers { get; set; }
        public int Type_litige { get; set; }
        public string Commentaire { get; set; }
        public Mission Mission { get; set; }
        public Modules Modules { get; set; }

    }
}
