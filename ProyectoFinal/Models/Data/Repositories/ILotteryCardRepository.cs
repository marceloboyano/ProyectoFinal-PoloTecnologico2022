namespace ProyectoFinal.Models.Data.Repositories
{
    public interface ILotteryCardRepository
    {
        LotteryCard GetOrCreateLotteryCard(int? id);
        IEnumerable<LotteryCard> GetAll();
        void ResetBalls();
        void TryStoreBall(int number, out bool result);
    }
}