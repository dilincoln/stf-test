using Microsoft.EntityFrameworkCore;
using STFTest.Models;

namespace STFTest.Data
{
    public class STFTestDBContext : DbContext 
    {
        public STFTestDBContext(DbContextOptions<STFTestDBContext> options) : base(options) 
        {
        }

        public DbSet<Models.Produto> Produtos { get; set; }
        public DbSet<Models.ItemPedido> ItensPedido { get; set; }
        public DbSet<Models.Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).DataAtualizacao = DateTime.UtcNow;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).DataCriacao = DateTime.UtcNow;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}