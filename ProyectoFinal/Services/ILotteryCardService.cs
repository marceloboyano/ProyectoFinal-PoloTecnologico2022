using ProyectoFinal.Models.Data;

namespace ProyectoFinal.Services
{
    public interface ILotteryCardService
    {
        int[,] CreateLotteryCard();
        IEnumerable<LotteryCard> GetLotteryCards();
    }
}