namespace ProyectoFinal.Models.Data.Repositories
{
    public interface ILotteryCardRepository
    {
        LotteryCard GetOrCreateLotteryCard(int? id);
        IEnumerable<LotteryCard> GetAll();
    }
}