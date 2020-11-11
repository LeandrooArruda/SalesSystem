using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesSystem.Sales.Domain.Entitites;

namespace SalesSystem.Sales.Data.EntitiesConfig
{
    public class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");

            builder.HasKey(prop => prop.Id).HasName("Pk_Car");

            builder.Property(prop => prop.Name).HasColumnType("varchar(80)")
                .IsRequired();

            builder.Property(prop => prop.Description).HasColumnType("varchar(400)").HasMaxLength(400)
                .IsRequired();

            builder.Property(prop => prop.Model).HasColumnType("varchar(100)").HasMaxLength(100)
                .IsRequired();

            builder.Property(prop => prop.RegistrationDate).HasColumnType("datetime")
                .HasColumnName("Registrtion_Date");

            builder.Property(prop => prop.Year).HasColumnType("datetime")
                .HasColumnName("Year_of_Manufacture");

            builder.Property(prop => prop.Price).HasColumnType("decimal(18,2)")
                .IsRequired();
   
        }
    }
}
