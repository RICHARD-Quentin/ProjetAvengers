using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models.Vert
{
    public class Liste_SuperHero_Mission
    {
        public int Id { get; set; }
        public ICollection<Mission> Missions { get; set; }
        public ICollection<Super_Hero> Super_Heros { get; set; }
    }
}
