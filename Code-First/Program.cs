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

            //PostgreSQL no Entity Framework
            //install EntityFramework.Npgsql

            //Voltando o banco de dados em um determinado ponto:
            //Update - DataBase –target “CriacaoBanco”

            //Cadastra os clientes
            var db = new Contexto();
            db.Cliente.Add(new Cliente() { Nome = "Carlos dos Santos" });
            db.Cliente.Add(new Cliente() { Nome = "Jose da Silva" });
            db.Cliente.Add(new Cliente() { Nome = "Antonio das Couves" });
            db.SaveChanges();
        }
    }
}
