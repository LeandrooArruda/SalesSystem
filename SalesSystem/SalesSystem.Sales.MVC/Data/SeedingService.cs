using SalesSystem.Sales.Data.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Sales.MVC.Data
{
    public class SeedingService
    {
        private readonly SalesContext _context;

        public SeedingService(SalesContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Cars.Any() || _context.Clients.Any())
            {
                return; //seed OK
            }
        }
    }
}
