using System.Threading.Tasks;
using EcoImpacto.Communication.Responses;

namespace EcoImpacto.Application.Services
{
    public class PostgreSQLService
    {
        private readonly CalculatorDbContext _context;

        public PostgreSQLService(CalculatorDbContext context)
        {
            _context = context;
        }

        public async Task SaveCalculatorResultAsync(ResponseCalculatorResultJson result)
        {
            _context.CalculatorResults.Add(result);
            await _context.SaveChangesAsync();
        }
    }
}
