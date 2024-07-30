using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetierSharedMemory.Model
{
    public class Jury : Personne
    {

        [MaxLength(20, ErrorMessage = "Taille maximal : 20"), Required(ErrorMessage = "Ce champs est requis")]
        [Display(Name = "Grade Professeur")]
        public string Grade { get; set; }


        [MaxLength(50, ErrorMessage = "Taille maximal : 50"), Required(ErrorMessage = "Ce champs est requis")]
        [Display(Name = "Specialite mendre jury")]
        public string Specialite{ get; set;}

        //Un jury peut avoir plusieurs memoire
        //public virtual ICollection<Memoire> Memoires { get; set; }

    }
}