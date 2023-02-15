using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Data;
using ProyectoFinal.Services;

namespace ProyectoFinal.Controllers.Api
{

    [ApiController]
    [Route("Api/[controller]")]
    public class BolilleroController : ControllerBase
    {
        private readonly IBolilleroService _bolilleroService;

        public BolilleroController(IBolilleroService bolilleroService)
        {
            _bolilleroService = bolilleroService;
        }


        [HttpGet]
        public async Task<IActionResult> GetBalls()
        {
            var bolilla = _bolilleroService.CreateBall();
            await _bolilleroService.InsertBall(bolilla);

            return Ok(bolilla);
        }

        [HttpPost]
        public IActionResult ResetGame()
        {
            _bolilleroService.ResetGame();
            return Ok();
        }
    }
}

