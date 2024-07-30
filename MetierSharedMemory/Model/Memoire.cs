using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetierSharedMemory.Model
{
    public class Memoire
    {
        [Key]
        public int IdMemoire {  get; set; }

        [MaxLength(300, ErrorMessage = "Taille maximal : 300"), Required(ErrorMessage = "Ce champs est requis")]
        [Display(Name = "Titre")]
        public string Titre{ get; set; }

        [Required(ErrorMessage = "*")]
        public int Annee { get; set; }

        [MaxLength(10, ErrorMessage = "Taille maximal : 10")]
        [Display(Name = "Statut")]
        public string Satut{ get; set; }

        [MaxLength(80, ErrorMessage = "Taille maximal : 80"), Required(ErrorMessage = "Ce champs est requis")]
        [Display(Name = "Auteur")]
        public string Auteur { get; set; }

        [MaxLength(30, ErrorMessage = "Taille maximal : 30"), Required(ErrorMessage = "Ce champs est requis")]
        [Display(Name = "Fichier")]
        public string FileName{ get; set; }

        [MaxLength(10, ErrorMessage = "Taille maximal : 10"), Required(ErrorMessage = "Ce champs est requis")]
        [Display(Name = " Extension ")]
        public string Extension { get; set; }

        [DataType(DataType.Date), Required(ErrorMessage = "Ce champs est requis")]
        [Display(Name = "Date de publication")]
        public DateTime? DatePublication { get; set; }

        //1 memoir epeut avoir plusieurs jury
        //public virtual ICollection<Jury> Jury { get; set; }

    }
}