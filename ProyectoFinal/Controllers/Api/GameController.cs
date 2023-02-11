using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Services;

namespace ProyectoFinal.Controllers.Api
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGetBallsServices _ballService;
        private readonly IBolilleroService _bolilleroService;

        public GameController(
            IBolilleroService bolilleroService,
            IGetBallsServices ballService)
        {
            _ballService = ballService;
            _bolilleroService = bolilleroService;
        }

        [HttpGet]
        public IActionResult  GetBalls()
        {
           var bolilla = _ballService.CreateBall();
           _bolilleroService.InsertBall(bolilla);

            return Ok(bolilla);
        }

      

    }
}
