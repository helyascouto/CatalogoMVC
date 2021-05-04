using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalogo.Models;

namespace Catalogo.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CatalogoDb;Trusted_Connection=True;");
        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Catalogo.Models.Produto> Produtos { get; set; }
    }
}
