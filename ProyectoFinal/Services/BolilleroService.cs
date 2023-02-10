using ProyectoFinal.Models.Data.Repositories;

namespace ProyectoFinal.Services
{
    public sealed  class BolilleroService : IBolilleroService
    {

        private static BolilleroService instance = null;
        private static readonly object padlock = new object();
        private readonly IBolilleroRepository _repo;
        private List<int> Balls { get; set; } = new List<int>();
        private int Number { get; set; }
        private Random _random = new Random(DateTime.Now.Millisecond);
        private bool repeat = false;

      
        public BolilleroService(IBolilleroRepository repo)
        {
            _repo = repo;
        }

        public static BolilleroService Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new BolilleroService(new BolilleroRepository());
                    }
                    return instance;
                }
            }
        }
        public async Task InsertBall(int ball)
        {

            await _repo.AddBall(ball);
        }


        public int CreateBall()
        {

            while (!repeat)
            {
                Number = _random.Next(1, 91);
                if (!Balls.Contains(Number))
                    repeat = true;
            }

            Balls.Add(Number);
            return Number;
        }


    }


}


   
