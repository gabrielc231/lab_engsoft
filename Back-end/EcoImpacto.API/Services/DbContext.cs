using Microsoft.EntityFrameworkCore;
using EcoImpacto.Communication.Responses;

namespace EcoImpacto.Application.Services
{
    public class CalculatorDbContext : DbContext
    {
        public CalculatorDbContext(DbContextOptions<CalculatorDbContext> options)
            : base(options)
        {
        }

        public DbSet<ResponseCalculatorResultJson> CalculatorResults { get; set; }
    }
}
