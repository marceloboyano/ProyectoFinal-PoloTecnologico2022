using ProyectoFinal.Data;
using System.Security.Cryptography;
using System;
using System.Security.Principal;

namespace ProyectoFinal.Models.Data.Repositories
{
    public class CartonesRepository : ICartonesRepository
    {

        private readonly BingoContext _context;

        public CartonesRepository(BingoContext context)
        {
            _context = context;
        }
        public async Task AddCards(int[] winners)
        {
            var entity = new HistorialCartones
            {
                FechaHora = DateTime.Now
            };

            for (int i = 0; i < winners.Length; i++)
            {
                var propertyName = "Carton" + (i + 1);
                var property = typeof(HistorialCartones).GetProperty(propertyName);
                property.SetValue(entity, winners[i]);
            }

            _context.Add(entity);
            await _context.SaveChangesAsync();
        }
             
    }
}
