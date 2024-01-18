using Microsoft.EntityFrameworkCore;

namespace STFTest.Data
{
    public class STFTestDBContext : DbContext 
    {
        public STFTestDBContext(DbContextOptions<STFTestDBContext> options) : base(options) 
        {
        }

        public DbSet<Models.Produto> Produtos { get; set; }
        public DbSet<Models.ItemPedido> ItensPedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}