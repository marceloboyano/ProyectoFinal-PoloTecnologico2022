using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Data;
using ProyectoFinal.Services;

namespace ProyectoFinal.Controllers
{

    [ApiController]
    [Route("Game/[controller]")]
    public class BolilleroController : ControllerBase
    {
        private readonly IBolilleroService _bolilleroService;

        public BolilleroController(IBolilleroService bolilleroService)
        {
            _bolilleroService = bolilleroService;
        }


        [HttpGet]
        public IActionResult GetBalls()
        {
            var bolilla = _bolilleroService.CreateBall();
            _bolilleroService.InsertBall(bolilla);

            return Ok(bolilla);
        }

        [HttpPost]
        public IActionResult SendWinner([FromBody] int[] winners)
        {
            return Ok();
        }

    }
}

