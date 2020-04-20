using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models.Vert
{
    public class Liste_SuperHero_Mission
    {
        public int Id { get; set; }
        [ForeignKey("MissionId")]
        public Mission Missions { get; set; }
        [ForeignKey("Liste_Super_Hero_Mission_Id")]
        public ICollection<Super_Hero> Super_Heros { get; set; }
    }
}
