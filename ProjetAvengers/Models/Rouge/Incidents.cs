using System;

namespace ProjetAnengers.Models
{
	public class Incidents
    {
        public int id { get; set; }
        public int id_crise { get; set; }
        public int id_litige { get; set; }
        public string lieu { get; set; }
        public string identite_origine_appel { get; set; }

    }
}