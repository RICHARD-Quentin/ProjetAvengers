using ProjetAvengers.Models.Vert;
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
        public string Pouvoir { get; set; }
        public string Point_faible { get; set; }
        public int? Score { get; set; }
        [ForeignKey("CivilsId")]
        public Civils Civils_Id { get; set; }
        public Liste_SuperHero_Mission Liste_SuperHero_Missions { get; set; }
        public Liste_sh_crise Liste_SuperVilain_Crise { get; set; }


    }
}
