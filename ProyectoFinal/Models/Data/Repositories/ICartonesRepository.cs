namespace ProyectoFinal.Models.Data.Repositories
{
    public interface ICartonesRepository
    {
        Task AddCards(int[] winners);
    }
}