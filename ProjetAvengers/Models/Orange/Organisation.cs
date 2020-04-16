﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAvengers.Models
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Telephone_Portable { get; set; }
        public DateTime Date_de_creation { get; set; }
        public DateTime Derniere_modification { get; set; }
        [ForeignKey("Dirigeant")]
        public Civils Civils_Id { get; set; }
        public ICollection<Coordonnee> Coordonnees { get; set; }
        public ICollection<Membre> Membres { get; set; }

    }
}