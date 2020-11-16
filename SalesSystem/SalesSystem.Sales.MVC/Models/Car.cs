using SalesSystem.Sales.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Sales.MVC.Models
{
    public class Car
    {
        public string Description { get; set; }

        public DateTime Year { get; set; }
        public string Model { get; set; }
        public Manufacturer Type { get; set; }
        public decimal Price { get; set; }
    }
}
