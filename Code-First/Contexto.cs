using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First
{
    class Contexto : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

       
    }
}
