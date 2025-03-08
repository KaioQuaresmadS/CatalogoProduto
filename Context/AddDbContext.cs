using Microsoft.EntityFrameworkCore;
using CatalogoProdutos.Models;

namespace CatalogoProdutos.Context
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options ) : base(options) { }

        public DbSet<Produtos> Produto { get; set; }

    }
}
