using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Data;
using ProyectoFinal.Models.Data.Repositories;

namespace ProyectoFinal.Services
{
    public class BolilleroService : IBolilleroService
    {

      
        private readonly IBolilleroRepository _repo;
        private List<int> Balls { get; set; } = new List<int>();
        private int _Number { get; set; }
        private Random _random = new Random(DateTime.Now.Millisecond);
        private bool _repeat = false;


        public BolilleroService(IBolilleroRepository repo)
        {
            _repo = repo;      
        }


    public async Task InsertBall(int ball)
        {

            await _repo.AddBall(ball);
        }


        public int CreateBall()
        {

            while (!_repeat)
            {
                _Number = _random.Next(1, 91);
                if (!Balls.Contains(_Number))
                    _repeat = true;
            }

            Balls.Add(_Number);
            return _Number;
        }


    }


}


   
