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
    public class CartonesController : Controller
    {

        private readonly ICartonesServices _cartones;
        public CartonesController(ICartonesServices cartones)
        {
            _cartones = cartones;
        }

        // GET: Cartones/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(List<int> winningCards)
        {

            await _cartones.InsertCards(winningCards);           
            return View();
        }

    }
}
