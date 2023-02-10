using System;

namespace ProyectoFinal.Services
{
    public class GetBallsServices : IGetBallsServices
    {
        public List<int> Balls { get; set; } = new List<int>();
        private int Number { get; set; }
        private Random _random = new Random(DateTime.Now.Millisecond);
        private bool repeat = false;



        public int CreateBall()
        {
            BallsExist();
            Balls.Add(Number);
            return Number;
        }

        private List<int> BallsExist()
        {
            //las bolillas no se pueden repetir por juego
            while (!repeat)
            {
                Number = _random.Next(1, 91);
                if (!Balls.Contains(Number))
                    repeat = true;
            }

            return Balls;
        }


    }
}
