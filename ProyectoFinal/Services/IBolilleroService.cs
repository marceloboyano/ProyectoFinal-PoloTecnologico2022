namespace ProyectoFinal.Services
{
    public interface IBolilleroService
    {
        int CreateBall();
        Task InsertBall(int ball);
    }
}