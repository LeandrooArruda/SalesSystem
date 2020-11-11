using SalesSystem.Sales.Domain.EntitiesBase;
using SalesSystem.Sales.Domain.Enums;
using System;

namespace SalesSystem.Sales.Domain.Entitites
{
    public class Car : EntityBase
    {
        public string Description { get; set; }

        public DateTime Year { get; set; }
        public string Model { get; set; }
        public Manufacturer Type { get; set; }
        public decimal Price { get; set; }

    }
}
