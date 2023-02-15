using ProyectoFinal.Models.Data.Repositories;

namespace ProyectoFinal.Services
{
    public class BolilleroService : IBolilleroService
    {

      
        private readonly IBolilleroRepository _repo;
        private readonly ILotteryCardRepository _lotteryRepo;

        private Random _random = new Random(DateTime.Now.Millisecond);

        public BolilleroService(
            ILotteryCardRepository lotteryRepo,
            IBolilleroRepository repo)
        {
            _repo = repo;
            _lotteryRepo = lotteryRepo;
        }


    public async Task InsertBall(int ball)
        {

            await _repo.AddBall(ball);
        }


        public int CreateBall()
        {
            var repeat = false;
            int number = new();
            
            while (!repeat)
            {
                number = _random.Next(1, 91);
                _lotteryRepo.TryStoreBall(number, out repeat);
            }

            return number;
        }

        public void ResetGame()
        {
            _lotteryRepo.ResetBalls();
        }
    }


}


   
