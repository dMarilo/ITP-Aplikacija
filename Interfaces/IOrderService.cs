using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacija.DTO;

namespace Aplikacija.Interfaces
{
    public interface IOrderService
    {
        public Task CreateOrder(OrderDTO orderDTO);
        public Task FinishOrder(int orederId);
    }
}