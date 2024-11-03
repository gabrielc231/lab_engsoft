using Microsoft.EntityFrameworkCore;
using EcoImpacto.Communication.Requests; // Supondo que RequestCalculatorResultJson est� nesta pasta

namespace EcoImpacto.Data
{
    public class EcoImpactoDbContext : DbContext
    {
        public EcoImpactoDbContext(DbContextOptions<EcoImpactoDbContext> options) : base(options) { }

        public DbSet<RequestCalculatorResultJson> CalculatorData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
