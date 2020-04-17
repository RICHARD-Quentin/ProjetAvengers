using System;

namespace ProjetAvengers.Models
{
	public class Incidents
    {
        public int Id { get; set; }
        public int Id_crise { get; set; }
        public int Id_litige { get; set; }
        public string Lieu { get; set; }
        public string Identite_origine_appel { get; set; }

    }
}