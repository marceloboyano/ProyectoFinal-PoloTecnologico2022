using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinal.Controllers.Components
{
    public class LotteryCardRow : ViewComponent
    {
        public IViewComponentResult Invoke(int id, int[,] matrix)
        {
            return View((id, matrix));
        }
       
    }
}
