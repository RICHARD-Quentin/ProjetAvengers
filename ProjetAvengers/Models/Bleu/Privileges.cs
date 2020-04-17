using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models.Bleu
{
    public class Privileges
    {
        public int Id { get; set; }
        public bool Lecture { get; set; }
        public bool Ecriture { get; set; }
        public bool Modification { get; set; }
        public bool Suppression { get; set; }
        public string Role { get; set; }


    }
}
