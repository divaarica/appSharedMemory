using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace MetierSharedMemory.Model
{
    //pour specifier les types mysql
    [DbConfigurationType(typeof(MySqlEFConfiguration)) ]
    public class BdSharedMemoryContext:DbContext
    {
        //constructeur
        public BdSharedMemoryContext(): base("connSharedMemory") { }


        public DbSet<Personne> Personnes { get; set; }

        public DbSet<Memoire> memoires { get; set; }

        public DbSet<Jury> Jurys { get; set; }

        public DbSet<JuryMemoire> juryMemoires { get; set; }


    }
}