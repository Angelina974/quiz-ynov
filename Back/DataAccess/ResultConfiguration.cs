
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ynov.QuizYnov.Business.Models;

public class ResultConfiguration
    : IEntityTypeConfiguration<Result>
{
    public void Configure(EntityTypeBuilder<Result> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(120);
        
        builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(120);
    }
}