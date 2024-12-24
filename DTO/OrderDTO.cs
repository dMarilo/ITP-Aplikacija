using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija.DTO
{
    public class OrderDTO
    {
        public OrderDTO()
        {
            orderListId = new List<int>();
        }
        public int UserId { get; set; }
        public List<int> orderListId { get; set; }
    }
}