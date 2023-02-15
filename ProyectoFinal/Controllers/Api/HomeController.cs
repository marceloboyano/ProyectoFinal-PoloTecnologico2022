using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Models.Data;
using ProyectoFinal.Services;
using System.Diagnostics;

namespace ProyectoFinal.Controllers.Api
{
    public class HomeController : Controller
    {

        private readonly ILotteryCardService _service;

        public HomeController(ILotteryCardService service)
        {

            _service = service;
        }

        public IActionResult Index()
        {
            var cartones = _service.GetLotteryCards()
                .Select(lc => lc.Matrix);

            return View(cartones);
        }
    }
}

