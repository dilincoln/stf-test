using Microsoft.EntityFrameworkCore;

namespace STFTest.Data
{
    public class STFTestDBContext : DbContext 
    {
        public STFTestDBContext(DbContextOptions<STFTestDBContext> options) : base(options) 
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}