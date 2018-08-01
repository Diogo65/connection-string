namespace Code_First.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed  class Configuration : DbMigrationsConfiguration<Code_First.Contexto>
    {
        public Configuration()
        {
            //Executando as atualizações automaticamente
            //mudar a classe para poublic
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Code_First.Contexto context)
        {
            //This method will be called after migrating to the latest version.

            //      You can use the DbSet<T>.AddOrUpdate() helper extension method
            //      to avoid creating duplicate seed data.
        }
    }
}
