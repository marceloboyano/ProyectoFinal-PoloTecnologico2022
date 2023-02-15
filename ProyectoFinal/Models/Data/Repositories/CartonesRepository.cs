using ProyectoFinal.Data;


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

            switch (winners.Length)
            {
                case 1:
                    entity.Carton1 = winners[0];
                    break;
                case 2:
                    entity.Carton1 = winners[0];
                    entity.Carton2 = winners[1];
                    break;
                case 3:
                    entity.Carton1 = winners[0];
                    entity.Carton2 = winners[1];
                    entity.Carton3 = winners[2];
                    break;
                case 4:
                    entity.Carton1 = winners[0];
                    entity.Carton2 = winners[1];
                    entity.Carton3 = winners[2];
                    entity.Carton4 = winners[3];
                    break;
                default:
                    break;
            }           

            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

    }
}

