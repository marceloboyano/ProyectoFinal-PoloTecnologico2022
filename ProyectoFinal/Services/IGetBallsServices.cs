namespace ProyectoFinal.Services
{
    public interface IGetBallsServices
    {
        List<int> Balls { get; set; }

        int CreateBall();
    }
}