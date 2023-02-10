using ProyectoFinal.Models.Data;
using ProyectoFinal.Models.Data.Repositories;
using System;

namespace ProyectoFinal.Services
{
    public class LotteryCardService : ILotteryCardService
    {

        public int[,] lotteryCard = new int[3, 9];        
        private readonly ILotteryCardRepository _repo; 

        public LotteryCardService(ILotteryCardRepository repo)
        {
            _repo = repo;
        }
        public int[,] CreateLotteryCard()
        {
            var lotteryCard = _repo.GetOrCreateLotteryCard(null);
            
            SortLotteryCard(lotteryCard);
            
            return lotteryCard.Matrix;

        }
        private void SortLotteryCard(LotteryCard lotteryCard) //ordenamos el carton generado
        {
            for (int c = 0; c < 9; c++)
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int k = f + 1; k < 3; k++)
                    {
                        if (lotteryCard.Matrix[f, c] > lotteryCard.Matrix[k, c])
                        {
                            int? aux = lotteryCard.Matrix[f, c];
                            lotteryCard.Matrix[f, c] = lotteryCard.Matrix[k, c];
                            lotteryCard.Matrix[k, c] = aux.Value;
                        }
                    }
                }
            }
        }
       
        public IEnumerable<LotteryCard> GetLotteryCards()
        {
            var cartones = _repo.GetAll();

            return cartones;
        }
    }
}
