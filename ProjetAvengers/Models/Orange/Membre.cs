using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models
{
    public class Membre
    {
        public int Id { get; set; }
        public Civils Civils { get; set; }
        public Organisation Organisation { get; set; }
    }
}
