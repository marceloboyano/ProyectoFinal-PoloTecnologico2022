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
        public async Task AddCards(List<int> winningCards)
        {
            var entity = new HistorialCartones
            {
                FechaHora = DateTime.Now
            };

            foreach (var card in winningCards)
            {
                switch (card)
                {
                    case 1:
                        entity.Carton1 = 1;
                        break;
                    case 2:
                        entity.Carton2 = 2;
                        break;
                    case 3:
                        entity.Carton3 = 3;
                        break;
                    case 4:
                        entity.Carton4 = 4;
                        break;
                }
            }

            _context.Add(entity);
            await _context.SaveChangesAsync();
        }
             
    }
}
