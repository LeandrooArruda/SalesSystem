using SalesSystem.Sales.Data.ORM;
using SalesSystem.Sales.Domain.Entitites;
using SalesSystem.Sales.Domain.Enums;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

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
            else
            {
                Manufacturer vw = Manufacturer.Vw;
                Manufacturer bmw = Manufacturer.Bmw;
                Manufacturer ferrari = Manufacturer.Ferrari;
                Manufacturer audi = Manufacturer.Audi;
                Manufacturer ford = Manufacturer.Ford;
                Manufacturer fiat = Manufacturer.Fiat;

                Gender man = Gender.Man;
                Gender woman = Gender.Woman;



                Client store = new Client
                {
                    Id = 1,
                    Name = "Loja",
                    LastName = "Carros SA",
                    BirthDate = new DateTime(2020, 01, 11),
                    Document = "111.111.111-11",
                    RegistrationDate = new DateTime(2020, 01, 11),
                    Gender = man
                };

                Car car1 = new Car
                {
                    Id = 1,
                    Name = "Up",
                    Model = "ConfortLine",
                    Type = vw,
                    Year = new DateTime(2020, 10, 10),
                    Description = "O mais completo da linha, com sistema inteligente de computador de bordo!",
                    Price = 75000,
                    RegistrationDate = new DateTime(2020, 09, 20)
                };

                Car car2 = new Car
                {
                    Id = 2,
                    Name = "Ferrari 812",
                    Model = "Superfast",
                    Type = ferrari,
                    Year = new DateTime(2018, 05, 08),
                    Description = "A Ferrari 812 Superfast é o modelo mais potente e rápido já produzido em série pela marca.",
                    Price = 5000000,
                    RegistrationDate = new DateTime(2020, 09, 20)
                };

                Car car3 = new Car
                {
                    Id = 3,
                    Name = "Mustang",
                    Model = "Mustang de 6ª geração",
                    Type = ford,
                    Year = new DateTime(2010, 05, 08),
                    Description = "Ford Mustang de 6ª geração. O Ford Mustang é um automóvel desportivo produzido pela Ford Motor Company.",
                    Price = 1000000,
                    RegistrationDate = new DateTime(2020, 09, 20)
                };

                _context.Clients.AddRangeAsync(store);
                _context.Cars.AddRangeAsync(car1, car2, car3);
                _context.SaveChangesAsync();
            }

            

        }
    }
}
