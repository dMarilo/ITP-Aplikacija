using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacija.Data;
using Aplikacija.DTO;
using Aplikacija.Interfaces;
using Aplikacija.Models;
using Microsoft.EntityFrameworkCore;

namespace Aplikacija.Services.service
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _context;

        public OrderService(DataContext context)
        {
            this._context = context;
        }
        public async Task CreateOrder(OrderDTO orderDTO)
        {
            Order order = new Order();

            order.UserId = orderDTO.UserId;
            order.orderListId = orderDTO.orderListId;

            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task FinishOrder(int orderId)
        {
            try{
                var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == orderId);
                if(order == null)
                {
                    throw new Exception(order.ToString());
                }

                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}