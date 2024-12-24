using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija.Models
{
    public class Pizza
    {
        public Guid Id { get; set; }
        public string Naziv { get; set; }
        public float Cijena {get; set;}

        public string Slika { get; set; }
        
    }
}