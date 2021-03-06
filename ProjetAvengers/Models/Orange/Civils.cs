﻿using System.Text.Json.Serialization;
using ProjetAvengers.Models.Bleu;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models
{
    public class Civils
    {
        public int Id { get; set; }
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone_portable { get; set; }
        public string Nationalite { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date_de_naissance { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date_de_deces { get; set; }
        [Column(TypeName = "date")]
        public DateTime Derniere_modification { get; set; }
        public ICollection<Coordonnee> Coordonnees { get; set; }
        public ICollection<Membre> Membres { get; set; }
        public Organisation Dirigeant { get; set; }
        public Super_Hero Super_Hero { get; set; }
        public Super_Vilain Super_Vilain { get; set; }
        public ICollection<Incidents> Incidents { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
