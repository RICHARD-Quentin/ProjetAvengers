using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models.Vert
{
    public class Liste_SuperVilain_Mission
    {
        public int Id { get; set; }
        public ICollection<Mission> Missions { get; set; }
        public ICollection<Super_Vilain> Super_Vilains { get; set; }
    }
}
