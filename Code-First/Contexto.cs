using Code_First.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First
{
    public class Contexto : DbContext
    {   
        //Executando as atualizações no Db automaticamente
        //public Contexto()
        //{
        //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<Contexto, Configuration>());
        //}

        public Contexto() : base("name=LocalContexto")
        {
        }

        public DbSet<Cliente> Cliente { get; set; }

        

    }
}
