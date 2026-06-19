using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SaleTree.Domain.Entities;

namespace SaleTree.Persistence.Configurations;

public sealed class ReviewConfiguration
    : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable("Reviews");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Comment)
            .HasMaxLength(1000);

        builder.Property(x => x.Rating)
            .IsRequired();

        builder.HasOne(x => x.Product)
            .WithMany(x => x.Reviews)
            .HasForeignKey(x => x.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
