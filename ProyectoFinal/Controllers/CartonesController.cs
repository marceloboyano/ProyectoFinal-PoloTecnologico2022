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
    [Route("Api/Winner/[controller]")]
    public class CartonesController : ControllerBase
    {


        private readonly ICartonesServices _cartones;
        public CartonesController(ICartonesServices cartones)
        {
            _cartones = cartones;
        }

        [HttpPost]
        public async Task<IActionResult>SendWinner([FromBody] int[] winners)
        {
            await _cartones.InsertCards(winners);
            return Ok();
        }
      

    }
}
