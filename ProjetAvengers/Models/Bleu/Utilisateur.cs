using System;
using System.Collections.Generic;
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
    }
}
