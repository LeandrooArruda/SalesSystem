//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SalesSystem.Sales.Domain.Entitites;

//namespace SalesSystem.Sales.Data.Relationship
//{
//    class ClientAndCars : IEntityTypeConfiguration<Client>
//    {
//        public void Configure(EntityTypeBuilder<Client> builder)
//        {
//            builder.HasMany(prop => prop.Cars)
//                .WithOne(prop => prop.Client)
//                .HasForeignKey(prop => prop.ClientId);
               
//        }
//    }
//}
