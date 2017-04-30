namespace WebApplication1.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.WebApplication1Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.WebApplication1Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(
                p => p.Id,
                new Product { Id = 1, nome = "produto 1", codigo = "COD1", descricao = "descrição produto 1", preco = 10, estocado = 20, minimo = 20 },
                new Product { Id = 2, nome = "produto 2", codigo = "COD2", descricao = "descrição produto 2", preco = 20, estocado = 20, minimo = 20 },
                new Product { Id = 3, nome = "produto 3", codigo = "COD3", descricao = "descrição produto 3", preco = 30, estocado = 20, minimo = 20 },
                new Product { Id = 4, nome = "produto 4", codigo = "COD4", descricao = "descrição produto 4", preco = 40, estocado = 20, minimo = 20 },
                new Product { Id = 5, nome = "produto 5", codigo = "COD5", descricao = "descrição produto 5", preco = 50, estocado = 20, minimo = 20 },
                new Product { Id = 6, nome = "produto 6", codigo = "COD6", descricao = "descrição produto 6", preco = 60, estocado = 20, minimo = 20 },
                new Product { Id = 7, nome = "produto 7", codigo = "COD7", descricao = "descrição produto 7", preco = 70, estocado = 20, minimo = 20 },
                new Product { Id = 8, nome = "produto 8", codigo = "COD8", descricao = "descrição produto 8", preco = 80, estocado = 20, minimo = 20 },
                new Product { Id = 9, nome = "produto 9", codigo = "COD9", descricao = "descrição produto 9", preco = 90, estocado = 20, minimo = 20 }
                );
        }
    }
}
