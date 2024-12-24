using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacija.Interfaces;
using Aplikacija.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacija.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            this._pizzaService = pizzaService;
        }

        [HttpPost("AddPizza")]
        public async Task<IActionResult> AddPizza(Pizza pizza)
        {
            await _pizzaService.AddPizza(pizza);
            return Ok();
        }
        [HttpGet("GetAllPizzas")]
        public async Task<ActionResult<List<Pizza>>> GetAllPizzas()
        {
            return Ok(await _pizzaService.GetPizzas());
        }

        [HttpGet("GetPizzaById/{id}")]
        public async Task<ActionResult<Pizza>> GetPizzaById(Guid id)
        {
            return Ok(await _pizzaService.GetPizzaById(id));
        }

        [HttpPut("UpdatePizza")]
        public async Task<IActionResult> UpdatePizza(Guid oldId, Pizza newPizza)
        {
            await _pizzaService.UpdatePizza(oldId, newPizza);
            return Ok();
        }

        [HttpDelete("RemovePizza")]
        public async Task<IActionResult> RemovePizza(Guid oldId)
        {
            await _pizzaService.RemovePizza(oldId);
            return Ok();
        }
        
    }
}