using System.Net;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SaleTree.Domain.Entities;

namespace SaleTree.Persistence.Configurations;

public class AddressConfiguration
    : IEntityTypeConfiguration<Address>
{
    public void Configure(
        EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Addresses");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.FullName)
            .HasMaxLength(150);

        builder.Property(x => x.City)
            .HasMaxLength(100);

        builder.Property(x => x.Country)
            .HasMaxLength(100);

        builder.Property(x => x.PhoneNumber)
            .HasMaxLength(20);
    }
}
