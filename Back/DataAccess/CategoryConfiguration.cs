using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ynov.QuizYnov.Business.Models;


public class CategoryConfiguration
    : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(120);

        builder.Property(p => p.Quizzes)
                .IsRequired();

    }
}

