using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // model , view , controller
using System.ComponentModel.DataAnnotations.Schema; // juste sur la base de donne

namespace MetierSharedMemory.Model
{
    public class Personne
    {
        [Key]
        public int IdPersonne { get; set; }

        [MaxLength(80, ErrorMessage = "Taille maximal : 100"), Required(ErrorMessage ="Ce champs est requis")]
        [Display(Name ="Nom")]
        public string Nom { get; set; }

        [MaxLength(80, ErrorMessage = "Taille maximal : 100"), Required(ErrorMessage = "Ce champs est requis")]
        [Display(Name = "Prenom")]
        public string Prenom { get; set; }


    }
}