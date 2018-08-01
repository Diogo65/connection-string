using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
            //intall EntityFramework

            //Cadastra os clientes
            var db = new Contexto();
            db.Cliente.Add(new Cliente() { Nome = "Carlos dos Santos" });
            db.Cliente.Add(new Cliente() { Nome = "Jose da Silva" });
            db.Cliente.Add(new Cliente() { Nome = "Antonio das Couves" });
            db.SaveChanges();
        }
    }
}
