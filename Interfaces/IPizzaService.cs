using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacija.Models;

namespace Aplikacija.Interfaces
{
    public interface IPizzaService
    {
        public Task AddPizza(Pizza pizza);
        public Task RemovePizza(Guid id);
        public Task UpdatePizza(Guid oldId, Pizza newPizza);
        public Task<List<Pizza>> GetPizzas();
        public Task<Pizza> GetPizzaById(Guid id);

    }
}