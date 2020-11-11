using System;

namespace SalesSystem.Sales.Domain.EntitiesBase
{
    public class EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
