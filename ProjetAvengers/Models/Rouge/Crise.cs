using ProjetAvengers.Models.Bleu;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace ProjetAvengers.Models
{
    public class Crise
    {
        public int Id { get; set; }
        public string Incident_majeur { get; set; }
        public bool Declanche_Litige { get; set; }
        [ForeignKey("IncidentId")]
        public Incidents Incidents { get; set; }
        public Litige Litige { get; set; }
        public Liste_sh_crise Liste_Sh_Crise { get; set; }
        public Liste_sv_crise Liste_Sv_Crise { get; set; }
        [ForeignKey("ModuleId")]
        public Modules Modules { get; set; }

    }
}
