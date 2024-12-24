using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija.Models
{
    public class Order
    {
        public Order()
        {
            orderListId = new List<int>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<int> orderListId {get; set;}
    }
}