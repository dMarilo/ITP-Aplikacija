using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacija.Data;
using Aplikacija.Interfaces;
using Aplikacija.Models;
using Microsoft.EntityFrameworkCore;

namespace Aplikacija.Services.service
{
    public class PizzaService : IPizzaService
    {
        private readonly DataContext _context;

        public PizzaService(DataContext context)
        {
            this._context = context;
        }
        public async Task AddPizza(Pizza pizza)
        {
            await _context.Pizzas.AddAsync(pizza);
            await _context.SaveChangesAsync();
        }

        public async Task<Pizza> GetPizzaById(Guid id)
        {
            try{
                var pizza = await _context.Pizzas.FirstOrDefaultAsync(p => p.Id == id);
                if(pizza == null)
                {
                    throw new Exception("Pizza with this ID does not exist");
                }
                return pizza;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }

        public async Task<List<Pizza>> GetPizzas()
        {
            List<Pizza> pizzas = await _context.Pizzas.ToListAsync();
            return pizzas;
        }

        public async Task RemovePizza(Guid id)
        {
            try{
                var pizza = await _context.Pizzas.FirstOrDefaultAsync(p => p.Id == id);
                if(pizza == null)
                {
                    throw new Exception("Pizza with this id does not exist!");
                }
                 _context.Pizzas.Remove(pizza);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdatePizza(Guid oldId, Pizza newPizza)
        {
              try{
                var pizza = await _context.Pizzas.FirstOrDefaultAsync(p => p.Id == oldId);
                if(pizza == null)
                {
                    throw new Exception("Pizza with this ID does not exist");
                }

                pizza.Naziv = newPizza.Naziv;
                pizza.Slika = newPizza.Slika;
                pizza.Cijena = newPizza.Cijena;

                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}