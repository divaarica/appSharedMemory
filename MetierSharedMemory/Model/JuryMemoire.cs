﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MetierSharedMemory.Model
{
    //Classe d'association entre jury et memeoire
    public class JuryMemoire
    {
        [Key]
        [Column(Order = 1)]

        public int? IdMemoire { get; set; }
        [ForeignKey("IdMemoire")]

    public virtual Memoire memoire { get; set; }

        [Key]
        [Column(Order = 2)]

        public int? IdJury { get; set; }
        [ForeignKey("IdJury")]

        public virtual Jury jury{ get; set; }

    }
}