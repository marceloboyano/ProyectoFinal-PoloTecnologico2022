using ProyectoFinal.Models.Data.Repositories;

namespace ProyectoFinal.Services
{
    public class CartonesServices : ICartonesServices
    {

        private readonly ICartonesRepository _repo;

        public CartonesServices(ICartonesRepository repo)
        {
            _repo = repo;
        }

        public async Task InsertCards(int[] winners)
        {

            await _repo.AddCards(winners);
        }
    }
}
