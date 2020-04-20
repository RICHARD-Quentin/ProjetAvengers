using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models
{
    public class Membre
    {
        public int Id { get; set; }
        [ForeignKey("CivilsId")]
        public Civils Civils { get; set; }
        [ForeignKey("OrganisationId")]
        public Organisation Organisation { get; set; }
    }
}
