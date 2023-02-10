namespace ProyectoFinal.Models.Data
{
    public class LotteryCard
    {
        public int Id { get; set; }
        public int[,] Matrix { get; set; } = new int[3, 9];

    }
}
