using SalesSystem.Sales.Domain.EntitiesBase;
using SalesSystem.Sales.Domain.Enums;
using System;
using System.Collections.Generic;

namespace SalesSystem.Sales.Domain.Entitites
{
    public class Client : EntityBase
    {
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
        public Gender Gender { get; set; }

        //public ICollection<Car> Cars { get; set; }
    }
}
