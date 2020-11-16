using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesSystem.Sales.Domain.Entitites;

namespace SalesSystem.Sales.Data.EntitiesConfig
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("clients");

            builder.HasKey(prop => prop.Id).HasName("pk_client");

            builder.Property(prop => prop.Name).HasColumnType("varchar(50)")
                .HasMaxLength(50).IsRequired();

            builder.Property(prop => prop.LastName).HasColumnType("varchar(100)")
                .HasMaxLength(100).IsRequired();

            builder.Property(prop => prop.Document).HasColumnType("varchar(14)")
                .HasMaxLength(14).IsRequired();

            builder.Property(prop => prop.BirthDate).HasColumnType("datetime")
                .HasColumnName("birth_date").IsRequired();

            builder.Property(prop => prop.RegistrationDate).HasColumnType("datetime")
                .HasColumnName("registration_date");
            
        }
    }
}
