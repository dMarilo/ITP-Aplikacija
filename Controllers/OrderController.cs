using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacija.DTO;
using Aplikacija.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacija.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            this._orderService = orderService;
        }

        [HttpPost("AddOrder")]
        public async Task<IActionResult> AddOrder(OrderDTO order)
        {
            await _orderService.CreateOrder(order);                
            return Ok();
        }

        [HttpDelete("FinishOrder")]
        public async Task<IActionResult> DeleteOrder(int orderId)
        {
            await _orderService.FinishOrder(orderId);
            return Ok();
        }
    }
}