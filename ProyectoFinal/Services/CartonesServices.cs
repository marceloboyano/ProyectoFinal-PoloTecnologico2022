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

        public async Task InsertCards(List<int> winningCards)
        {

            await _repo.AddCards(winningCards);
        }
    }
}
