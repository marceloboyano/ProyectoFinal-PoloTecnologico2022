using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Data;

namespace ProyectoFinal.Models.Data.Repositories
{
    public class BolilleroRepository : IBolilleroRepository
    {
        private readonly BingoContext _context;

        public BolilleroRepository(BingoContext context)
        {
            _context = context;
        }

        public async Task AddBall(int ball)
        {

            var entity = new HistorialBolillero
            {
                FechaHora = DateTime.Now,
                NumeroBolilla = ball,
            };

            _context.Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}
